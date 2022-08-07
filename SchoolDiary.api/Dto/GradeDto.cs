namespace SchoolDiary.api.Dto
{
    public class GradeDto
    {
        public int GradeValue { get; set; }
        public int Weight { get; set; }
        public string? Description { get; set; }
        public Guid UserUUID { get; set; }
        public string? Lesson { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Class { get; set; }
    }
}
