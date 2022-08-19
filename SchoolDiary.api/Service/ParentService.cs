using SchoolDiary.api.Dto;
using SchoolDiary.api.Exceptions;
using InvalidDataException = SchoolDiary.api.Exceptions.InvalidDataException;

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

            return parents.Select(t => new ParentViewModel()
                {
                    ParentID = t.ParentID,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Email = t.Email,
                    Phone = t.Phone
                }).ToList();
        }

        public async Task<List<ParentViewModel>> GetUserParents(Guid uuid)
        {
            if (uuid == Guid.Empty)
            {
                throw new InvalidDataException("Invalid data");
            }

            var parents = await DiaryDbContext.PersonParent
                .Include(x => x.Parent)
                .Where(x => x.FK_UserUUID == uuid)
                .ToListAsync();

            if (parents.Count <= 0)
            {
                throw new NotFoundException("No parents");
            }

            return parents.Select(t => new ParentViewModel()
                {
                    ParentID = t.Parent.ParentID,
                    FirstName = t.Parent.FirstName,
                    LastName = t.Parent.LastName,
                    Email = t.Parent.Email,
                    Phone = t.Parent.Phone
                }).ToList();
        }

        public async Task CreateParent(ParentDto parentDto)
        {
            if (parentDto is null)
            {
                throw new InvalidDataException("Invalid data");
            }

            var emailValidation = new EmailAddressAttribute().IsValid(parentDto.Email);

            if (!emailValidation)
            {
                throw new InvalidEmailException("Invalid email");
            }

            var parent = new Parent()
            {
                Email = parentDto.Email,
                FirstName = parentDto.FirstName,
                LastName = parentDto.LastName,
                Phone = parentDto.Phone
            };

            await DiaryDbContext.AddAsync(parent);
            await DiaryDbContext.SaveChangesAsync();

            await DiaryDbContext.PersonParent.AddAsync(new PersonParent()
            {
                FK_UserUUID = parentDto.UserUUID,
                FK_ParentID = parent.ParentID
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task ChangeParent(int id, ParentDto parentViewModel)
        {
            if (parentViewModel is null || id.Equals(0))
            {
                throw new InvalidDataException("Invalid data");
            }

            var parentToChange = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == id);

            if (parentToChange is null)
            {
                throw new NotFoundException("Parent parent doesn't exist");
            }

            parentToChange.FirstName = parentViewModel.FirstName;
            parentToChange.LastName = parentViewModel.LastName;
            parentToChange.Email = parentViewModel.Email;
            parentToChange.Phone = parentViewModel.Phone;

            DiaryDbContext.Update(parentToChange);
            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task DeleteParent(int id)
        {
            if (id.Equals(0))
            {
                throw new InvalidDataException("Invalid id");
            }

            var parentPerson = await DiaryDbContext.PersonParent.FirstOrDefaultAsync(x => x.FK_ParentID == id);

            if (parentPerson is null)
            {
                throw new NotFoundException("Parent doesn't exist");
            }

            var parent = await DiaryDbContext.Parent.FirstOrDefaultAsync(x => x.ParentID == id);

            if (parent is null)
            {
                throw new NotFoundException("Parent doesn't exist");
            }

            DiaryDbContext.Remove(parentPerson);
            DiaryDbContext.Remove(parent);
            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
