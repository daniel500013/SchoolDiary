using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class PersonParent
    {
        [Key]
        public int PersonParentID { get; set; }
        
        public Guid FK_UserUUID { get; set; }

        [InverseProperty("Parent")]
        public virtual Person? Person { get; set; }

        public int? FK_ParentID { get; set; }
        [ForeignKey(nameof(FK_ParentID))]
        public virtual Parent? Parent { get; set; }
    }
}
