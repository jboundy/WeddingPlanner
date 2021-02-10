using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("expenses")]
    public class Expenses
    {
        [Key]
        public int id { get; set; }

        public string description { get; set; }
    }
}
