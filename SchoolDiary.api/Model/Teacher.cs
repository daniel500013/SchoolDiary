using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        [ForeignKey("FK_TeacherID")]
        public ICollection<Subject>? Subject { get; set; }
    }
}
