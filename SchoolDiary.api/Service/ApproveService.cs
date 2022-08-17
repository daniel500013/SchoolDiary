using SchoolDiary.api.Dto;

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

        public async Task CreateApprove(ApproveDto approveDto)
        {
            if (approveDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var x = await DiaryDbContext.Lesson.ToListAsync();

            var Lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == approveDto.Lesson)
                .Where(x => x.Day == approveDto.Day)
                .Where(x => x.Hour == approveDto.Hour)
                .Where(x => x.Subjects.FirstOrDefault(x => x.FK_Class == approveDto.Class).FK_Class == approveDto.Class)
                .FirstOrDefaultAsync();

            if (Lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var Approve = new Approve()
            {
                Description = approveDto.Description,
                Positive = approveDto.Positive,
                FK_UserUUID = approveDto.UserUUID
            };

            await DiaryDbContext.AddAsync(Approve);
            await DiaryDbContext.SaveChangesAsync();

            var LessonApprove = new LessonApprove()
            {
                FK_ApproveID = Approve.ApproveID,
                FK_LessonID = Lesson.LessonID
            };

            await DiaryDbContext.AddAsync(LessonApprove);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeApprove(int id, ApproveDto approve)
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
