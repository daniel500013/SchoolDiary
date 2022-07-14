using System.ComponentModel.DataAnnotations.Schema;

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

        [JsonIgnore]
        [ForeignKey("FK_UserUUID")]
        public ICollection<PersonRole>? Roles { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_UserUUID")]
        public ICollection<PersonParent>? Parent { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_UserUUID")]
        public ICollection<PersonClass>? Class { get; set; }
    }
}
