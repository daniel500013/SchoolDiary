using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDiary.api.Model
{
    public class PersonRole
    {
        [Key]
        public int PersonRoleID { get; set; }

        public int FK_RoleID { get; set; }

        [ForeignKey(nameof(FK_RoleID))]
        public virtual Role? Role { get; set; }

        public Guid FK_UserUUID { get; set; }

        [InverseProperty("Roles")]
        public virtual Person? Person { get; set; }
    }
}
