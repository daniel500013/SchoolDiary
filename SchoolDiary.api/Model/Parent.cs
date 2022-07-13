namespace SchoolDiary.api.Model
{
    public class Parent
    {
        [Key]
        public int ParentID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
