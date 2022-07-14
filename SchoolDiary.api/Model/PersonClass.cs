using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class PersonClass
    {
        [Key]
        public int UserClassID { get; set; }

        public Guid FK_UserUUID { get; set; }

        [InverseProperty("Class")]
        public virtual Person? Person { get; set; }

        public int FK_ClassID { get; set; }
        [ForeignKey(nameof(FK_ClassID))]
        public virtual Class? Class { get; set; }
    }
}
