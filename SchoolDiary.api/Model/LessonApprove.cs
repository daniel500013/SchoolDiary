using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class LessonApprove
    {
        [Key]
        public int LessonApproveID { get; set; }

        public int FK_LessonID { get; set; }

        [JsonIgnore]
        [InverseProperty("LessonApproves")]
        public virtual Lesson? Lesson { get; set; }

        public int FK_ApproveID { get; set; }

        [JsonIgnore]
        [InverseProperty("LessonApproves")]
        public virtual Approve? Approve { get; set; }
    }
}
