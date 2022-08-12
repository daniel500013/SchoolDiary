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

        public async Task<List<ParentDto>> GetAllParents()
        {
            var parents = await DiaryDbContext.Parent.ToListAsync();

            var parentsToViewModel = new List<ParentDto>();

            for (int i = 0; i < parents.Count; i++)
            {
                parentsToViewModel.Add(new ParentDto()
                {
                    FirstName = parents[i].FirstName,
                    LastName = parents[i].LastName,
                    Email = parents[i].Email,
                    Phone = parents[i].Phone,
                });
            }

            return parentsToViewModel;
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

        public async Task CreateParent(ParentDto ParentViewModel)
        {
            if (ParentViewModel is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var EmailValidation = new EmailAddressAttribute().IsValid(ParentViewModel.Email);

            if (!EmailValidation)
            {
                throw new ArgumentOutOfRangeException("Invalid email");
            }

            var parent = new Parent()
            {
                Email = ParentViewModel.Email,
                FirstName = ParentViewModel.FirstName,
                LastName = ParentViewModel.LastName,
                Phone = ParentViewModel.Phone
            };

            await DiaryDbContext.AddAsync(parent);
            await DiaryDbContext.SaveChangesAsync();

            await DiaryDbContext.PersonParent.AddAsync(new PersonParent()
            {
                FK_UserUUID = ParentViewModel.UserUUID,
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

            var ParentToDelete = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == id);

            if (ParentToDelete is null)
            {
                throw new ArgumentNullException("Parent dosen't exist");
            }

            DiaryDbContext.Remove(ParentToDelete);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
