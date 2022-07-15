namespace SchoolDiary.api.Service
{
    public class ApproveService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public ApproveService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Approve>> GetAllApprove()
        {
            var approves = await DiaryDbContext.Approve.ToListAsync();

            return approves;
        }

        public async Task CreateApprove(ApproveViewModel approve)
        {
            if (approve is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Approve()
            {
                Description = approve.Description,
                Positive = approve.Positive,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeApprove(int id, ApproveViewModel approve)
        {
            if (id.Equals(0) || approve is null)
            {
                throw new NullReferenceException("Invalid data");
            }

            var CheckApproveExist = await DiaryDbContext.Approve.FirstOrDefaultAsync(x => x.ApproveID == id);

            if (CheckApproveExist is null)
            {
                throw new ArgumentNullException("Given approve dosen't exist");
            }

            CheckApproveExist.Positive = approve.Positive;
            CheckApproveExist.Description = approve.Description;

            DiaryDbContext.Update(CheckApproveExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteApprove(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ApproveToRemove = await DiaryDbContext.Approve.FirstOrDefaultAsync(x => x.ApproveID == id);

            if (ApproveToRemove is null)
            {
                throw new ArgumentNullException("Given approve dosen't exist");
            }

            DiaryDbContext.Remove(ApproveToRemove);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
