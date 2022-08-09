using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class MarkManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public MarkManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<LessonMark>> GetAll()
        {
            var LessonMark = await DiaryDbContext.LessonMark.ToListAsync();

            return LessonMark;
        }

        public async Task<List<MarkManagerDto>> GetUserMarks(Guid uuid)
        {
            if (uuid.ToString().Length <= 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Marks = await DiaryDbContext.LessonMark
                .Include(x => x.Mark)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (Marks.Count <= 0)
            {
                throw new ArgumentNullException("No marks");
            }

            var MarkLesson = await DiaryDbContext.LessonMark
                .Include(x => x.Lesson)
                .Select(x => x.Mark)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonMarks.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            List<MarkManagerDto> MarksDto = new List<MarkManagerDto>();

            for (int i = 0; i < Marks.Count; i++)
            {
                MarksDto.Add(new MarkManagerDto() { Present = Marks[i].Present, Data = Marks[i].Date, LessonName = MarkLesson[i] });
            }

            return MarksDto;
        }

        public async Task AssignMark(LessonMarkViewModel lessonMark)
        {
            if (lessonMark is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new LessonMark()
            {
                FK_LessonID = lessonMark.FK_LessonID,
                FK_MarkID = lessonMark.FK_MarkID
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeAssign(int id, LessonMarkViewModel lessonMark)
        {
            if (id.Equals(0) || lessonMark is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckLessonMarkExist = await DiaryDbContext.LessonMark.FirstOrDefaultAsync(x => x.LessonMarkID == id);

            if (CheckLessonMarkExist is null)
            {
                throw new ArgumentNullException("Given Lesson-Mark dosen't exist");
            }

            CheckLessonMarkExist.FK_LessonID = lessonMark.FK_LessonID;
            CheckLessonMarkExist.FK_MarkID = lessonMark.FK_MarkID;

            DiaryDbContext.Update(CheckLessonMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteAssign(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ToDelete = await DiaryDbContext.LessonMark.FirstOrDefaultAsync(x => x.LessonMarkID == id);

            if (ToDelete is null)
            {
                throw new ArgumentNullException("Mark dosen't exist");
            }

            DiaryDbContext.Remove(ToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
