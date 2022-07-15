using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        public int FK_TeacherID { get; set; }
        
        [InverseProperty("Subject")]
        public virtual Teacher? Teacher { get; set; }

        public int FK_PersonClass { get; set; }

        [InverseProperty("Subject")]
        public virtual PersonClass? PersonClass { get; set; }
    }
}
