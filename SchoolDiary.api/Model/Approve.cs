using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Approve
    {
        [Key]
        public int ApproveID { get; set; }
        public bool Positive { get; set; }
        public string? Description { get; set; }

        [ForeignKey("FK_ApproveID")]
        public ICollection<LessonApprove>? LessonApproves { get; set; }
    }
}
