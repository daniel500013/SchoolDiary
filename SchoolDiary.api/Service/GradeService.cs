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

        public async Task CreateGrade(GradeViewModel grade)
        {
            if (grade is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Grade()
            {
                Description = grade.Description,
                GradeValue = grade.GradeValue,
                Weight = grade.Weight,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteGrade(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckGradeExist = await DiaryDbContext.Grade.FirstOrDefaultAsync(x => x.GradeID == id);

            if (CheckGradeExist is null)
            {
                throw new ArgumentNullException("Grade dosen't exist");
            }

            DiaryDbContext.Remove(CheckGradeExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
