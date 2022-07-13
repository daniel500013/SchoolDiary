namespace SchoolDiary.api.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        
        [Required]
        public string? Name { get; set; }

    }
}
