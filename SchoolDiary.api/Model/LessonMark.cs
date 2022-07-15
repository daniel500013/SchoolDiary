using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class LessonMark
    {
        public int LessonMarkID { get; set; }

        public int FK_LessonID { get; set; }
        [InverseProperty("LessonMarks")]
        public virtual Lesson? Lesson { get; set; }

        public int FK_MarkID { get; set; }
        [InverseProperty("LessonMarks")]
        public virtual Mark? Mark { get; set; }
    }
}
