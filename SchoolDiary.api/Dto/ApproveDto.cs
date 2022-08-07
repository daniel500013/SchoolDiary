namespace SchoolDiary.api.Dto
{
    public class ApproveDto
    {
        public bool Positive { get; set; }
        public string? Description { get; set; }
        public Guid UserUUID { get; set; }
    }
}
