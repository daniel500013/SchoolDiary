using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class LessonGrade
    {
        [Key]
        public int GradeLessonID { get; set; }

        public int FK_LessonID { get; set; }
        
        [JsonIgnore]
        [InverseProperty("LessonGrades")]
        public virtual Lesson? Lesson { get; set; }

        public int FK_GradeID { get; set; }

        [JsonIgnore]
        [InverseProperty("LessonGrades")]
        public virtual Grade? Grade { get; set; }
    }
}
