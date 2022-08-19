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

            var checkUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == uuid);

            if (checkUserExist is null)
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

            var approveLessons = await DiaryDbContext.LessonApprove
                .Include(x => x.Lesson)
                .Select(x => x.Approve)
                .Where(x => x.FK_UserUUID == uuid)
                .Select(x => x.LessonApproves!.Select(x => x.Lesson))
                .SelectMany(x => x)
                .Select(x => x.Name)
                .ToListAsync();

            return Approves.Select((t, i) => new ApproveManagerDto()
                {
                    Positive = t.Positive,
                    Description = t.Description,
                    LessonName = approveLessons[i]
                }).ToList();
        }

        public async Task CreateApprove(ApproveDto approveDto)
        {
            if (approveDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var x = await DiaryDbContext.Lesson.ToListAsync();

            var lesson = await DiaryDbContext.Lesson
                .Include(x => x.Subjects)
                .Where(x => x.Name == approveDto.Lesson)
                .Where(x => x.Day == approveDto.Day)
                .Where(x => x.Hour == approveDto.Hour)
                .Where(x => x.Subjects!.FirstOrDefault(x => x.FK_Class == approveDto.Class)!.FK_Class == approveDto.Class)
                .FirstOrDefaultAsync();

            if (lesson is null)
            {
                throw new ArgumentNullException("Lesson dosen't exist");
            }

            var approve = new Approve()
            {
                Description = approveDto.Description,
                Positive = approveDto.Positive,
                FK_UserUUID = approveDto.UserUUID
            };

            await DiaryDbContext.AddAsync(approve);
            await DiaryDbContext.SaveChangesAsync();

            var lessonApprove = new LessonApprove()
            {
                FK_ApproveID = approve.ApproveID,
                FK_LessonID = lesson.LessonID
            };

            await DiaryDbContext.AddAsync(lessonApprove);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeApprove(int id, ApproveDto approve)
        {
            if (id.Equals(0) || approve is null)
            {
                throw new NullReferenceException("Invalid data");
            }

            var checkApproveExist = await DiaryDbContext.Approve.FirstOrDefaultAsync(x => x.ApproveID == id);

            if (checkApproveExist is null)
            {
                throw new ArgumentNullException("Given approve dosen't exist");
            }

            checkApproveExist.Positive = approve.Positive;
            checkApproveExist.Description = approve.Description;

            DiaryDbContext.Update(checkApproveExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteApprove(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var approveToRemove = await DiaryDbContext.Approve.FirstOrDefaultAsync(x => x.ApproveID == id);

            if (approveToRemove is null)
            {
                throw new ArgumentNullException("Given approve dosen't exist");
            }

            DiaryDbContext.Remove(approveToRemove);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
