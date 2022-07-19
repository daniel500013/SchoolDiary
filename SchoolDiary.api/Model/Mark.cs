using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Mark
    {
        [Key]
        public int MarkID { get; set; }
        public bool Present { get; set; }
        public DateTime Date { get; set; }

        [JsonIgnore]
        [ForeignKey("FK_MarkID")]
        public ICollection<LessonMark>? LessonMarks { get; set; }

        public Guid FK_UserUUID { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(FK_UserUUID))]
        public virtual Person? Person { get; set; }
    }
}
