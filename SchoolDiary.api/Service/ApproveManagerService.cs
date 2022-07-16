namespace SchoolDiary.api.Service
{
    public class ApproveManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public ApproveManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<LessonApprove>> GetAllLessonApprove()
        {
            var lessonApprove = await DiaryDbContext.LessonApprove.ToListAsync();

            return lessonApprove;
        }

        public async Task AssignApproveToLesson(ApproveManagerViewModel approve)
        {
            if (approve is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new LessonApprove()
            {
                FK_ApproveID = approve.FK_ApproveID,
                FK_LessonID = approve.FK_LessonID
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeAssignApproveToLesson(int id, ApproveManagerViewModel approve)
        {
            if (id.Equals(0) || approve is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var AssignToChange = await DiaryDbContext.LessonApprove.FirstOrDefaultAsync(x => x.LessonApproveID == id);

            if (AssignToChange is null)
            {
                throw new ArgumentNullException("Approve dosen't exist");
            }

            AssignToChange.FK_ApproveID = approve.FK_ApproveID;
            AssignToChange.FK_LessonID = approve.FK_LessonID;

            DiaryDbContext.Update(AssignToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteAssignApproveToLesson(int id)
        {
            if (id.Equals(0))
            {
                throw new NullReferenceException("Invalid data");
            }

            var ToDelete = await DiaryDbContext.LessonApprove.FirstOrDefaultAsync(x => x.LessonApproveID == id);

            if (ToDelete is null)
            {
                throw new ArgumentNullException("Approve dosen't exist");
            }

            DiaryDbContext.Remove(ToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
