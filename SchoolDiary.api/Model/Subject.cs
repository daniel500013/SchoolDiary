using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        public int FK_TeacherID { get; set; }

        [JsonIgnore]
        [InverseProperty("Subject")]
        public virtual Teacher? Teacher { get; set; }

        public int FK_Class { get; set; }

        [JsonIgnore]
        [InverseProperty("Subject")]
        public virtual Class? Class { get; set; }

        public int FK_LessonID { get; set; }

        [JsonIgnore]
        [InverseProperty("Subjects")]
        public virtual Lesson? Lesson { get; set; }
    }
}
