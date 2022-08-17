using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class TeacherService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public TeacherService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<Teacher>> GetAllTeacher()
        {
            var teachers = await DiaryDbContext.Teacher.ToListAsync();

            return teachers;
        }

        public async Task AddTeacher(TeacherDto teacher)
        {
            if (teacher is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var EmailValidation = new EmailAddressAttribute().IsValid(teacher.Email);

            if (!EmailValidation)
            {
                throw new ArgumentOutOfRangeException("Invalid email");
            }

            await DiaryDbContext.AddAsync(new Teacher()
            {
                Email = teacher.Email,
                FirstName = teacher.FirstName,
                Gender = teacher.Gender,
                LastName = teacher.LastName,
                Phone = teacher.Phone,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeTeacher(int id, TeacherDto teacher)
        {
            if (teacher is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckTeacherExist = await DiaryDbContext.Teacher.FirstOrDefaultAsync(x => x.TeacherID == id);

            if (CheckTeacherExist is null)
            {
                throw new ArgumentNullException("Given teacher dosen't exist");
            }

            CheckTeacherExist = new Teacher()
            { 
                Email = teacher.Email,
                FirstName = teacher.FirstName,
                Phone = teacher.Phone,
                LastName = teacher.LastName,
                Gender = teacher.Gender,
            };

            DiaryDbContext.Update(CheckTeacherExist);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteTeacher(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckTeacherExist = await DiaryDbContext.Teacher.FirstOrDefaultAsync(x => x.TeacherID == id);

            if (CheckTeacherExist is null)
            {
                throw new ArgumentNullException("Given teacher dosen't exist");
            }

            DiaryDbContext.Remove(CheckTeacherExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
