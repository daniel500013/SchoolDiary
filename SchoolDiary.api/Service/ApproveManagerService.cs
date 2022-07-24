using SchoolDiary.api.Dto;

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

        public async Task<List<ApproveManagerDto>> GetUserApproves(Guid uuid)
        {
            if (uuid == Guid.Empty)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == uuid);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            var Approves = await DiaryDbContext.LessonApprove
                .Include(x => x.Approve)
                .Select(x => x.Approve)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (Approves.Count <= 0)
            {
                throw new ArgumentNullException("No approves");
            }

            var ApproveLessons = await DiaryDbContext.LessonApprove
                .Include(x => x.Lesson)
                .Select(x => x.Approve)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonApproves.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            List<ApproveManagerDto> ApproovesDto = new List<ApproveManagerDto>();

            for (int i = 0; i < Approves.Count; i++)
            {
                ApproovesDto.Add(new ApproveManagerDto() { Positive = Approves[i].Positive, Description = Approves[i].Description, LessonName = ApproveLessons[i] });
            }

            return ApproovesDto;
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
