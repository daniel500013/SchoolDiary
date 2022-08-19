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

            var userRoles = await DiaryDbContext.PersonRole
                .Include(x => x.Role)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (userRoles is null)
            {
                throw new ArgumentNullException("User dosen't exist");
            }

            return userRoles.Select(t => new RoleManagerViewModel()
                {
                    PersonRoleID = t.PersonRoleID,
                    RoleName = t.Role.Name,
                    UserUUID = t.FK_UserUUID
                }).ToList();
        }

        public async Task AssignUserRole(RoleDto roleDto)
        {
            var userExist = await DiaryDbContext.Person.SingleOrDefaultAsync(x => x.UserUUID == roleDto.UserUUID);

            if (userExist is null)
            {
                throw new ArgumentNullException("Invalid User uuid");
            }

            var roleExist = await DiaryDbContext.Role.SingleOrDefaultAsync(x => x.RoleID == roleDto.RoleID);

            if (roleExist is null)
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

        public async Task ChangeUserRole(Guid userUuid, int oldRoleId, int newRoleId)
        {
            if (oldRoleId.Equals(0) || newRoleId.Equals(0))
            {
                throw new ArgumentOutOfRangeException("Empty new or old role");
            }

            var userExist = await DiaryDbContext.PersonRole
                .FirstOrDefaultAsync(x => x.FK_UserUUID == userUuid);

            if (userExist is null)
            {
                throw new ArgumentNullException("Invalid user uuid");
            }

            var oldRoleAssign = await DiaryDbContext.PersonRole
                .Where(x => x.FK_UserUUID == userUuid)
                .SingleOrDefaultAsync(x => x.FK_RoleID == oldRoleId);

            if (oldRoleAssign is null)
            {
                throw new ArgumentNullException("Given user uuid are dosen't assign to given role");
            }

            oldRoleAssign.FK_RoleID = newRoleId;

            DiaryDbContext.PersonRole.Update(oldRoleAssign);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task RemoveUserRole(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var roleToDelete = await DiaryDbContext.PersonRole
                .FirstOrDefaultAsync(x => x.PersonRoleID == id);

            if (roleToDelete is null)
            {
                throw new ArgumentNullException("Assigment dosen't exist");
            }

            DiaryDbContext.PersonRole.Remove(roleToDelete);

            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
