using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class MarkService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public MarkService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Mark>> GetAllMarks()
        {
            var marks = await DiaryDbContext.Mark.ToListAsync();

            return marks;
        }

        public async Task<List<Mark>> GetClassMarks(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassNumber == id);

            if (CheckClassExist is null)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            var users = await DiaryDbContext.PersonClass
                .Where(x => x.FK_ClassID == id)
                .Select(x => x.FK_UserUUID)
                .ToListAsync();

            if (users.Count <= 0)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            List<Mark> marks = new List<Mark>();

            for (int i = 0; i < users.Count; i++)
            {
                var tmp_mark = await DiaryDbContext.Mark
                    .Where(x => x.FK_UserUUID == users[i])
                    .ToListAsync();

                if (tmp_mark is null)
                {
                    throw new ArgumentNullException("Person dosen't exist");
                }

                for (int j = 0; j < tmp_mark.Count; j++)
                {
                    marks.Add(tmp_mark[j]);
                }
            }

            return marks;
        }

        public async Task AddMark(MarkDto mark)
        {
            if (mark is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Mark()
            {
                Date = DateTime.Now.Date,
                Present = mark.Present,
                FK_UserUUID = mark.UserUUID
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeMark(int id, MarkDto mark)
        {
            if (mark is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (CheckMarkExist is null)
            {
                throw new ArgumentNullException("Given mark id dosen't exist");
            }

            CheckMarkExist.Present = mark.Present;

            DiaryDbContext.Update(CheckMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteMark(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckMarkExist = await DiaryDbContext.Mark.FirstOrDefaultAsync(x => x.MarkID == id);

            if (CheckMarkExist is null)
            {
                throw new ArgumentNullException("Mark dosen't exist");
            }

            DiaryDbContext.Remove(CheckMarkExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
