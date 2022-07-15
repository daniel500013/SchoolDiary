using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        [MaxLength(6)]
        public int GradeValue { get; set; }
        public int Weight { get; set; }
        public string? Description { get; set; }

        [ForeignKey("FK_GradeID")]
        public ICollection<LessonGrade>? LessonGrades { get; set; }
    }
}
