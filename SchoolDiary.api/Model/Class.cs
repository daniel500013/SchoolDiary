using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public int ClassNumber { get; set; }
        public string? Profile { get; set; }
    
        public string? Description { get; set; }

        [ForeignKey("FK_Class")]
        public ICollection<Subject>? Subject { get; set; }
    }
}
