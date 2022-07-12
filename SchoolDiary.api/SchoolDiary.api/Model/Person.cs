using System.ComponentModel.DataAnnotations;

namespace SchoolDiary.api.Model
{
    public class Person
    {
        [Key]
        public Guid UserUUID { get; set; }
        
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Phone { get; set; }
    }
}
