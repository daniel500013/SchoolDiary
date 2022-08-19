using SchoolDiary.api.Dto;
using SchoolDiary.api.Exceptions;
using InvalidDataException = SchoolDiary.api.Exceptions.InvalidDataException;

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
                throw new InvalidDataException("Invalid data");
            }

            var users = await DiaryDbContext.PersonClass
                .Include(x => x.Person)
                .Include(x => x.Class)
                .Where(x => x.Class!.ClassNumber == id)
                .ToListAsync();

            if (users.Count <= 0)
            {
                throw new NotFoundException("Class doesn't exist");
            }

            return users.Select((t, i) => new ClassManagerViewModel()
                {
                    UserUUID = users.Select(x => x.Person.UserUUID).ToList()[i],
                    FirstName = users.Select(x => x.Person.FirstName).ToList()[i],
                    LastName = users.Select(x => x.Person.LastName).ToList()[i],
                    Class = users.Select(x => x.Class.ClassNumber).ToList()[i],
                }).ToList();
        }

        public async Task AssignPersonToClass(ClassManagerDto classManagerDto)
        {
            if (classManagerDto.UserUUID == Guid.Empty || classManagerDto.ClassID.Equals(0))
            {
                throw new InvalidDataException("Invalid data");
            }

            var checkUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == classManagerDto.UserUUID);
            
            if (checkUserExist is null)
            {
                throw new NotFoundException("User doesn't exist");
            }

            var checkClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == classManagerDto.ClassID);

            if (checkClassExist is null)
            {
                throw new NotFoundException("Class doesn't exist");
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
                throw new InvalidDataException("Invalid data");
            }

            var checkUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == classManagerDto.UserUUID);

            if (checkUserExist is null)
            {
                throw new NotFoundException("Given user doesn't exist");
            }

            var checkClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (checkClassExist is null)
            {
                throw new NotFoundException("Given class doesn't exist");
            }

            var checkNewClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == classManagerDto.ClassID);

            if (checkNewClassExist is null)
            {
                throw new NotFoundException("Given class doesn't exist");
            }

            var personToChange = await DiaryDbContext.PersonClass
                .Where(x => x.FK_UserUUID == classManagerDto.UserUUID)
                .FirstOrDefaultAsync(x => x.FK_ClassID == id);

            if (personToChange is null)
            {
                throw new NotFoundException("Given user with typed role doesn't exist");
            }

            personToChange.FK_ClassID = classManagerDto.ClassID;

            DiaryDbContext.Update(personToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task RemovePersonFromClass(int id)
        {
            if (id.Equals(0))
            {
                throw new InvalidDataException("Invalid data");
            }

            var checkRelationExist = await DiaryDbContext.PersonClass.FirstOrDefaultAsync(x => x.UserClassID == id);

            if (checkRelationExist is null)
            {
                throw new NotFoundException("User assign doesn't exist");
            }

            DiaryDbContext.Remove(checkRelationExist);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
