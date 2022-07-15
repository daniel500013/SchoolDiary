using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class Mark
    {
        [Key]
        public int MarkID { get; set; }
        public bool Present { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("FK_MarkID")]
        public ICollection<LessonMark>? LessonMarks { get; set; }
    }
}
