using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class PersonClass
    {
        [Key]
        public int UserClassID { get; set; }

        public Guid FK_UserUUID { get; set; }

        [JsonIgnore]
        [InverseProperty("Class")]
        public virtual Person? Person { get; set; }

        public int FK_ClassID { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(FK_ClassID))]
        public virtual Class? Class { get; set; }

        [ForeignKey("FK_PersonClass")]
        public ICollection<Subject>? Subject { get; set; }
    }
}
