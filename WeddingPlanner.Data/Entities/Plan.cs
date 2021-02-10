using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("plan")]
    public class Plan
    {
        [Key]
        public int id { get; set; }

        public List<Users> Users { get; set; }
        
        public List<Vendors> Vendors { get; set; }

        [ForeignKey("FK_PlanBudget")]
        public int budgetid { get; set; }

        public List<Guests> Guests { get; set; }

        public Schedule Schedule { get; set;s }
    }
}
