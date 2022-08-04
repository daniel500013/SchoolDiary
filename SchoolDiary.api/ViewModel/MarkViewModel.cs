namespace SchoolDiary.api.ViewModel
{
    public class MarkViewModel
    {
        public int MarkID { get; set; }
        public bool Present { get; set; }
        public DateTime Date { get; set; }
        public Guid FK_UserUUID { get; set; }
    }
}
