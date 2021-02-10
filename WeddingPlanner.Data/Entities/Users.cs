using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Data.Entities
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int id { get; set; }
        public Roles roles { get; set; }

    }
}
