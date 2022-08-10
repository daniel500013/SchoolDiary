using SchoolDiary.api.Dto;

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

        public async Task<List<RoleManagerViewModel>> GetUserRoles(Guid uuid)
        {
            if (uuid == Guid.Empty)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var UserRoles = await DiaryDbContext.PersonRole
                .Include(x => x.Role)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (UserRoles is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            List<RoleManagerViewModel> roleList = new List<RoleManagerViewModel>();

            for (int i = 0; i < UserRoles.Count; i++)
            {
                roleList.Add(new RoleManagerViewModel()
                {
                    PersonRoleID = UserRoles[i].PersonRoleID,
                    RoleName = UserRoles[i].Role.Name,
                    UserUUID = UserRoles[i].FK_UserUUID
                });
            }

            return roleList;
        }

        public async Task AssignUserRole(RoleDto roleDto)
        {
            var UserExist = await DiaryDbContext.Person.SingleOrDefaultAsync(x => x.UserUUID == roleDto.UserUUID);

            if (UserExist is null)
            {
                throw new ArgumentNullException("Invalid User uuid");
            }

            var RoleExist = await DiaryDbContext.Role.SingleOrDefaultAsync(x => x.RoleID == roleDto.RoleID);

            if (RoleExist is null)
            {
                throw new ArgumentNullException("Invalid Role");
            }

            await DiaryDbContext.PersonRole.AddAsync(new PersonRole()
            {
                FK_RoleID = roleDto.RoleID,
                FK_UserUUID = roleDto.UserUUID
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

        public async Task RemoveUserRole(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var RoleToDelete = await DiaryDbContext.PersonRole
                .FirstOrDefaultAsync(x => x.PersonRoleID == id);

            if (RoleToDelete is null)
            {
                throw new ArgumentNullException("Assigment dosen't exist");
            }

            DiaryDbContext.PersonRole.Remove(RoleToDelete);

            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
