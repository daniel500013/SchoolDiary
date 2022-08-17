using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class ClassService
    {
        private readonly DiaryDbContext DiaryDbContext;
        public ClassService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Class>> GetAllClass()
        {
            var Class = await DiaryDbContext.Class.ToListAsync();

            return Class;
        }

        public async Task CreateClass(ClassDto Class)
        {
            if (Class is null || Class.ClassNumber != 0)
            {
                throw new ArgumentNullException("Invalid data");
            }

            await DiaryDbContext.AddAsync(new Class()
            {
                ClassNumber = Class.ClassNumber,
                Profile = Class.Profile,
                Description = Class.Description,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeClass(int id, ClassDto NewClass)
        {
            if (NewClass is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ClassToChange = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (ClassToChange is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            ClassToChange.ClassNumber = NewClass.ClassNumber;
            ClassToChange.Profile = NewClass.Profile;
            ClassToChange.Description = NewClass.Description;

            DiaryDbContext.Update(ClassToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteClass(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ClassToDelete = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (ClassToDelete is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            DiaryDbContext.Remove(ClassToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
