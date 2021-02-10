using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("schedule")]
    public class Schedule
    {
        [Key]
        public int id { get; set; }


    }
}
