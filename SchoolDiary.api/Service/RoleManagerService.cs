namespace SchoolDiary.api.Service
{
    public class RoleManagerService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public RoleManagerService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<string?>?> GetRoles()
        {
            var roles = await DiaryDbContext.Role
                .Select(x => x.Name)
                .ToListAsync();

            return roles;
        }

        public async Task AssignUserRole(Guid UserUUID, int RoleID)
        {
            var UserExist = await DiaryDbContext.Person.SingleOrDefaultAsync(x => x.UserUUID == UserUUID);

            if (UserExist is null)
            {
                throw new ArgumentNullException("Invalid User uuid");
            }

            var RoleExist = await DiaryDbContext.Role.SingleOrDefaultAsync(x => x.RoleID == RoleID);

            if (RoleExist is null)
            {
                throw new ArgumentNullException("Invalid Role");
            }

            await DiaryDbContext.PersonRole.AddAsync(new PersonRole()
            {
                FK_RoleID = RoleID,
                FK_UserUUID = UserUUID
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeUserRole(Guid UserUUID, int OldRoleID, int NewRoleID)
        {
            if (OldRoleID.Equals(0) || NewRoleID.Equals(0))
            {
                throw new ArgumentOutOfRangeException("Empty new or old role");
            }

            var UserExist = await DiaryDbContext.PersonRole
                .FirstOrDefaultAsync(x => x.FK_UserUUID == UserUUID);

            if (UserExist is null)
            {
                throw new ArgumentNullException("Invalid user uuid");
            }

            var OldRoleAssign = await DiaryDbContext.PersonRole
                .Where(x => x.FK_UserUUID == UserUUID)
                .SingleOrDefaultAsync(x => x.FK_RoleID == OldRoleID);

            if (OldRoleAssign is null)
            {
                throw new ArgumentNullException("Given user uuid are dosen't assign to given role");
            }

            OldRoleAssign.FK_RoleID = NewRoleID;

            DiaryDbContext.PersonRole.Update(OldRoleAssign);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task RemoveUserRole(Guid UserUUID, int RoleID)
        {
            var UserExist = await DiaryDbContext.Person.SingleOrDefaultAsync(x => x.UserUUID == UserUUID);

            if (UserExist is null)
            {
                throw new ArgumentNullException("Invalid User uuid");
            }

            var RoleExist = await DiaryDbContext.Role.SingleOrDefaultAsync(x => x.RoleID == RoleID);

            if (RoleExist is null)
            {
                throw new ArgumentNullException("Invalid Role");
            }

            var RoleToRemove = await DiaryDbContext.PersonRole
                .Where(x => x.FK_UserUUID == UserUUID)
                .SingleOrDefaultAsync(x => x.FK_RoleID == RoleID);

            if (RoleToRemove is null)
            {
                throw new ArgumentNullException("Given role assign dosen't exist");
            }

            DiaryDbContext.PersonRole.Remove(RoleToRemove);

            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
