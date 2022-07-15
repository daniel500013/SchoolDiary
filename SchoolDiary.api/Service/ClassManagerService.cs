﻿namespace SchoolDiary.api.Service
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

        public async Task AssignPersonToClass(Guid UserUUID, int ClassID)
        {
            if (UserUUID.ToString().Length <= 0 || ClassID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == UserUUID);
            
            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == ClassID);

            if (CheckClassExist is null)
            {
                throw new ArgumentNullException("Class dosen't exist");
            }

            await DiaryDbContext.PersonClass.AddAsync(new PersonClass()
            {
                FK_UserUUID = UserUUID,
                FK_ClassID = ClassID,
            });
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangePersonClass(Guid UserUUID, int id, int NewClassID)
        {
            if (id.Equals(0) || NewClassID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == UserUUID);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("Given user dosen't exist");
            }

            var CheckClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == id);

            if (CheckClassExist is null)
            {
                throw new ArgumentNullException("Given class dosen't exist");
            }

            var CheckNewClassExist = await DiaryDbContext.Class.FirstOrDefaultAsync(x => x.ClassID == NewClassID);

            if (CheckNewClassExist is null)
            {
                throw new ArgumentNullException("Given class dosen't exist");
            }

            var PersonToChange = await DiaryDbContext.PersonClass
                .Where(x => x.FK_UserUUID == UserUUID)
                .FirstOrDefaultAsync(x => x.FK_ClassID == id);

            if (PersonToChange is null)
            {
                throw new ArgumentNullException("Given user with typed role dosen't exist");
            }

            PersonToChange.FK_ClassID = NewClassID;

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