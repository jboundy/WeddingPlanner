using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("roles")]
    public class Roles
    {
        [Key]
        public int id { get; set; }
        public string description { get; set; }

        [ForeignKey("FK_UserId")]
        public int userid { get; set; }

        public List<Users> users { get; set; }
    }
}
