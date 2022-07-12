namespace SchoolDiary.api.Service
{
    public class AccountService
    {
        private readonly DiaryDbContext diaryDbContext;

        public AccountService(DiaryDbContext diaryDbContext)
        {
            this.diaryDbContext = diaryDbContext;
        }

        public async Task Register()
        {

        }
    }
}
