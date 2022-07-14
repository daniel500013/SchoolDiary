namespace SchoolDiary.api.ViewModel
{
    public class PersonViewModel
    {
        public Guid UserUUID { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
    }
}
