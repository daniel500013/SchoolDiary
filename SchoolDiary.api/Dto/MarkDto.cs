namespace SchoolDiary.api.Dto
{
    public class MarkDto
    {
        public bool Present { get; set; }
        public Guid UserUUID { get; set; }
        public string? Lesson { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Class { get; set; }
    }
}
