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
        public string? Password { get; set; }
        
        public string? PasswordHashed { get; set; }
    }
}
