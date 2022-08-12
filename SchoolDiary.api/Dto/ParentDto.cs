namespace SchoolDiary.api.Dto
{
    public class ParentDto
    {
        public Guid UserUUID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
