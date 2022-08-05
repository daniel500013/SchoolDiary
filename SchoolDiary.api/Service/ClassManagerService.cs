using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class ClassManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public ClassManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<PersonClass>> GetPersonClass()
        {
            var classParent = await DiaryDbContext.PersonClass.ToListAsync();

            return classParent;
        }

        public async Task<List<ClassManagerViewModel>> GetUsersByClass(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Users = await DiaryDbContext.PersonClass
                .Include(x => x.Person)
                .Include(x => x.Class)
                .Where(x => x.Class.ClassNumber == id)
                .ToListAsync();

            if (Users.Count <= 0)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            List<ClassManagerViewModel> UserViewModel = new List<ClassManagerViewModel>();

            for (int i = 0; i < Users.Count; i++)
            {
                UserViewModel.Add(new ClassManagerViewModel()
                {
                    UserUUID = Users.Select(x => x.Person.UserUUID).ToList()[i],
                    FirstName = Users.Select(x => x.Person.FirstName).ToList()[i],
                    LastName = Users.Select(x => x.Person.LastName).ToList()[i],
                    Class = Users.Select(x => x.Class.ClassNumber).ToList()[i],
                });
            }

            return UserViewModel;
        }

        public async Task AssignPersonToClass(ClassManagerDto classManagerDto)
        {
            if (classManagerDto.UserUUID == Guid.Empty || classManagerDto.ClassID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == classManagerDto.UserUUID);
            
            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == classManagerDto.ClassID);

            if (CheckClassExist is null)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            await DiaryDbContext.PersonClass.AddAsync(new PersonClass()
            {
                FK_UserUUID = classManagerDto.UserUUID,
                FK_ClassID = classManagerDto.ClassID,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangePersonClass(int id, ClassManagerDto classManagerDto)
        {
            if (id.Equals(0) || classManagerDto.ClassID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == classManagerDto.UserUUID);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("Given user dosen't exist");
            }

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (CheckClassExist is null)
            {
                throw new ArgumentNullException("Given class dosen't exist");
            }

            var CheckNewClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == classManagerDto.ClassID);

            if (CheckNewClassExist is null)
            {
                throw new ArgumentNullException("Given class dosen't exist");
            }

            var PersonToChange = await DiaryDbContext.PersonClass
                .Where(x => x.FK_UserUUID == classManagerDto.UserUUID)
                .FirstOrDefaultAsync(x => x.FK_ClassID == id);

            if (PersonToChange is null)
            {
                throw new ArgumentNullException("Given user with typed role dosen't exist");
            }

            PersonToChange.FK_ClassID = classManagerDto.ClassID;

            DiaryDbContext.Update(PersonToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task RemovePersonFromClass(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckRelationExist = await DiaryDbContext.PersonClass.FirstOrDefaultAsync(x => x.UserClassID == id);

            if (CheckRelationExist is null)
            {
                throw new ArgumentNullException("User assign dosen't exist");
            }

            DiaryDbContext.Remove(CheckRelationExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
