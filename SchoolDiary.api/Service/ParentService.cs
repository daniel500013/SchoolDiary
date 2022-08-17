using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Service
{
    public class ParentService
    {
        private readonly DiaryDbContext DiaryDbContext;

        public ParentService(DiaryDbContext diaryDbContext)
        {
            DiaryDbContext = diaryDbContext;
        }

        public async Task<List<ParentViewModel>> GetAllParents()
        {
            var parents = await DiaryDbContext.Parent.ToListAsync();

            var parentsModel = new List<ParentViewModel>();

            for (int i = 0; i < parents.Count; i++)
            {
                parentsModel.Add(new ParentViewModel()
                {
                    ParentID = parents[i].ParentID,
                    FirstName = parents[i].FirstName,
                    LastName = parents[i].LastName,
                    Email = parents[i].Email,
                    Phone = parents[i].Phone
                });
            }

            return parentsModel;
        }

        public async Task<List<ParentViewModel>> GetUserParents(Guid uuid)
        {
            if (uuid == Guid.Empty)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Parents = await DiaryDbContext.PersonParent
                .Include(x => x.Parent)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (Parents.Count <= 0)
            {
                throw new ArgumentNullException("No parents");
            }

            List<ParentViewModel> ParentsModel = new List<ParentViewModel>();

            for (int i = 0; i < Parents.Count; i++)
            {
                ParentsModel.Add(new ParentViewModel()
                {
                    ParentID = Parents[i].Parent.ParentID,
                    FirstName = Parents[i].Parent.FirstName,
                    LastName = Parents[i].Parent.LastName,
                    Email = Parents[i].Parent.Email,
                    Phone = Parents[i].Parent.Phone
                });
            }

            return ParentsModel;
        }

        public async Task CreateParent(ParentDto ParentDto)
        {
            if (ParentDto is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var EmailValidation = new EmailAddressAttribute().IsValid(ParentDto.Email);

            if (!EmailValidation)
            {
                throw new ArgumentOutOfRangeException("Invalid email");
            }

            var parent = new Parent()
            {
                Email = ParentDto.Email,
                FirstName = ParentDto.FirstName,
                LastName = ParentDto.LastName,
                Phone = ParentDto.Phone
            };

            await DiaryDbContext.AddAsync(parent);
            await DiaryDbContext.SaveChangesAsync();

            await DiaryDbContext.PersonParent.AddAsync(new PersonParent()
            {
                FK_UserUUID = ParentDto.UserUUID,
                FK_ParentID = parent.ParentID
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeParent(int id, ParentDto ParentViewModel)
        {
            if (ParentViewModel is null || id.Equals(0))
            {
                throw new ArgumentNullException("Invalid data");
            }

            var ParentToChange = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == id);

            if (ParentToChange is null)
            {
                throw new ArgumentNullException("Parent parent dosen't exist");
            }

            ParentToChange.FirstName = ParentViewModel.FirstName;
            ParentToChange.LastName = ParentViewModel.LastName;
            ParentToChange.Email = ParentViewModel.Email;
            ParentToChange.Phone = ParentViewModel.Phone;

            DiaryDbContext.Update(ParentToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteParent(int id)
        {
            if (id.Equals(0))
            {
                throw new ArgumentOutOfRangeException("Invalid id");
            }

            var ParentPerson = await DiaryDbContext.PersonParent.FirstOrDefaultAsync(x => x.FK_ParentID == id);

            if (ParentPerson is null)
            {
                throw new ArgumentNullException("Parent dosen't exist");
            }

            var Parent = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == id);

            if (Parent is null)
            {
                throw new ArgumentNullException("Parent dosen't exist");
            }

            DiaryDbContext.Remove(ParentPerson);
            DiaryDbContext.Remove(Parent);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
