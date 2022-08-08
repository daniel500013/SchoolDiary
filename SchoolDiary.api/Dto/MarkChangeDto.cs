namespace SchoolDiary.api.Dto
{
    public class MarkChangeDto
    {
        public string? Lesson { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Class { get; set; }
        public DateTime Date { get; set; }
    }
}
