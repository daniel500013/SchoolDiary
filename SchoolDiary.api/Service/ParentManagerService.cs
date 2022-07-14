namespace SchoolDiary.api.Service
{
    public class ParentManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public ParentManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<PersonParent>> GetAllPersonParent()
        {
            var PersonParent = await DiaryDbContext.PersonParent.ToListAsync();

            return PersonParent;
        }

        public async Task AssignParentToUser(Guid UserUUID, int ParentID)
        {
            if (UserUUID.ToString().Length <= 0 || ParentID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckUserExist = await DiaryDbContext.Person.FirstOrDefaultAsync(x => x.UserUUID == UserUUID);

            if (CheckUserExist is null)
            {
                throw new ArgumentNullException("Given user dosen't exist");
            }

            var CheckParentExist = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == ParentID);

            if (CheckParentExist is null)
            {
                throw new ArgumentNullException("Given parent dosen't exist");
            }

            await DiaryDbContext.PersonParent.AddAsync(new PersonParent()
            {
                FK_UserUUID = UserUUID,
                FK_ParentID = ParentID
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeUserParent(int id, int ParentID)
        {
            if (id.Equals(0) || ParentID.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var CheckParentExist = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == ParentID);

            if (CheckParentExist is null)
            {
                throw new ArgumentNullException("Given parent dosen't exist");
            }

            var UserToChange = await DiaryDbContext.PersonParent.FirstOrDefaultAsync(x => x.PersonParentID == id);

            if (UserToChange is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            UserToChange.FK_ParentID = ParentID;

            DiaryDbContext.Update(UserToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteParentFromUser(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ToDelete = await DiaryDbContext.PersonParent.FirstOrDefaultAsync(x => x.PersonParentID == id);

            if (ToDelete is null)
            {
                throw new ArgumentNullException("Given id dosen't exist");
            }

            DiaryDbContext.Remove(ToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
