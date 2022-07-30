namespace SchoolDiary.api.ViewModel
{
    public class GradeViewModel
    {
        public int GradeValue { get; set; }
        public int Weight { get; set; }
        public string? Description { get; set; }
        public Guid UserUUID { get; set; }
    }
}
