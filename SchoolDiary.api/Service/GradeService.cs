using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class GradeService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public GradeService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Grade>> GetAllGrades()
        {
            var grades = await DiaryDbContext.Grade.ToListAsync();

            return grades;
        }

        public async Task<List<GradeManagerDto?>> GetUserGrades(Guid uuid)
        {
            if (uuid.ToString().Length <= 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == uuid);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            var Grades = await DiaryDbContext.LessonGrade
                .Include(x => x.Grade)
                .Select(x => x.Grade)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (Grades.Count <= 0)
            {
                throw new ArgumentNullException("No grades");
            }

            var GradeLessons = await DiaryDbContext.LessonGrade
                .Include(x => x.Lesson)
                .Select(x => x.Grade)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonGrades.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            List<GradeManagerDto> GradesDto = new List<GradeManagerDto>();

            for (int i = 0; i < Grades.Count; i++)
            {
                GradesDto.Add(new GradeManagerDto() { GradeValue = Grades[i].GradeValue, GradeWeight = Grades[i].Weight, LessonName = GradeLessons[i] });
            }

            return GradesDto;
        }

        public async Task CreateGrade(GradeDto gradeDto)
        {
            if (gradeDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == gradeDto.Lesson)
                .Where(x => x.Day == gradeDto.Day)
                .Where(x => x.Hour == gradeDto.Hour)
                .Where(x => x.Subjects.FirstOrDefault(x => x.FK_Class == gradeDto.Class).FK_Class == gradeDto.Class)
                .FirstOrDefaultAsync();

            if (Lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var Grade = new Grade()
            {
                Description = gradeDto.Description,
                GradeValue = gradeDto.GradeValue,
                Weight = gradeDto.Weight,
                FK_UserUUID = gradeDto.UserUUID
            };

            await DiaryDbContext.AddAsync(Grade);
            await DiaryDbContext.SaveChangesAsync();

            var LessonGrade = new LessonGrade()
            {
                FK_GradeID = Grade.GradeID,
                FK_LessonID = Lesson.LessonID
            };

            await DiaryDbContext.AddAsync(LessonGrade);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteGrade(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckGradeExist = await DiaryDbContext.Grade.FirstOrDefaultAsync(x => x.GradeID == id);

            if (CheckGradeExist is null)
            {
                throw new ArgumentNullException("Grade dosen't exist");
            }

            DiaryDbContext.Remove(CheckGradeExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
