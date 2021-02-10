using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlanner.Data.Entities
{
    [Table("guests")]
    public class Guests
    {
        public int id { get; set; }

        public int planid { get; set; }
    }
}
