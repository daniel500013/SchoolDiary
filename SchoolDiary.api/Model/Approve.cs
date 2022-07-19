using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Approve
    {
        [Key]
        public int ApproveID { get; set; }
        public bool Positive { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_ApproveID")]
        public ICollection<LessonApprove>? LessonApproves { get; set; }

        public Guid FK_UserUUID { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(FK_UserUUID))]
        public virtual Person? Person { get; set; }
    }
}
