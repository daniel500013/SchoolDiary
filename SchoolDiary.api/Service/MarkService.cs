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

        public async Task AddMark(MarkViewModel mark)
        {
            if (mark is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Mark()
            {
                Date = DateTime.Now,
                Present = mark.Present,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeMark(int id, MarkViewModel mark)
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
