using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("budget")]
    public class Budget
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("FK_UserBudger")]
        public int userid { get; set; }

        public decimal taxrate { get; set; }

        public decimal totalcost { get; set; }

        public List<Expenses> expenses { get; set; }
    }
}
