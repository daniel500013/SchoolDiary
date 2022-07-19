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

        [JsonIgnore]
        [ForeignKey("FK_GradeID")]
        public ICollection<LessonGrade>? LessonGrades { get; set; }

        public Guid FK_UserUUID { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(FK_UserUUID))]
        public virtual Person? Person { get; set; }
    }
}
