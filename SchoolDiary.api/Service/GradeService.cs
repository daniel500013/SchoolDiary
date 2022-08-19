using SchoolDiary.api.Dto;
using SchoolDiary.api.Exceptions;
using InvalidDataException = SchoolDiary.api.Exceptions.InvalidDataException;

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
                throw new InvalidDataException("Invalid data");
            }

            var checkUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == uuid);

            if (checkUserExist is null)
            {
                throw new NotFoundException("User doesn't exist");
            }

            var grades = await DiaryDbContext.LessonGrade
                .Include(x => x.Grade)
                .Select(x => x.Grade)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (grades.Count <= 0)
            {
                throw new NotFoundException("No grades");
            }

            var gradeLessons = await DiaryDbContext.LessonGrade
                .Include(x => x.Lesson)
                .Select(x => x.Grade)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonGrades!.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            return grades.Select((t, i) => new GradeManagerDto()
                {
                    GradeValue = t.GradeValue,
                    GradeWeight = t.Weight,
                    LessonName = gradeLessons[i]
                })
                .ToList()!;
        }

        public async Task CreateGrade(GradeDto gradeDto)
        {
            if (gradeDto is null || gradeDto.GradeValue == 0 || gradeDto.Weight == 0)
            {
                throw new InvalidDataException("Invalid data");
            }

            var lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == gradeDto.Lesson)
                .Where(x => x.Day == gradeDto.Day)
                .Where(x => x.Hour == gradeDto.Hour)
                .Where(x => x.Subjects.FirstOrDefault(x => x.FK_Class == gradeDto.Class)!.FK_Class == gradeDto.Class)
                .FirstOrDefaultAsync();

            if (lesson is null)
            {
                throw new NotFoundException("Lesson doesn't exist");
            }

            var grade = new Grade()
            {
                Description = gradeDto.Description,
                GradeValue = gradeDto.GradeValue,
                Weight = gradeDto.Weight,
                FK_UserUUID = gradeDto.UserUUID
            };

            await DiaryDbContext.AddAsync(grade);
            await DiaryDbContext.SaveChangesAsync();

            var lessonGrade = new LessonGrade()
            {
                FK_GradeID = grade.GradeID,
                FK_LessonID = lesson.LessonID
            };

            await DiaryDbContext.AddAsync(lessonGrade);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteGrade(int id)
        {
            if (id.Equals(0))
            {
                throw new InvalidDataException("Invalid data");
            }

            var checkGradeExist = await DiaryDbContext.Grade.FirstOrDefaultAsync(x => x.GradeID == id);

            if (checkGradeExist is null)
            {
                throw new NotFoundException("Grade doesn't exist");
            }

            DiaryDbContext.Remove(checkGradeExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
