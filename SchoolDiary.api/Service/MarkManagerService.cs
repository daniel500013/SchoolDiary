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
