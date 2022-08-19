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
            if (Class is null || Class.ClassNumber == 0)
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

            var classToChange = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (classToChange is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            classToChange.ClassNumber = NewClass.ClassNumber;
            classToChange.Profile = NewClass.Profile;
            classToChange.Description = NewClass.Description;

            DiaryDbContext.Update(classToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteClass(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var classToDelete = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (classToDelete is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            DiaryDbContext.Remove(classToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
