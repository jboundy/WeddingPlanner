using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Data.Entities
{
    [Table("affiliate-links")]
    public class AffiliateLinks
    {
        [Key]
        public int id { get; set; }

        public string url { get; set; }

        [ForeignKey("FK_VendorId")]
        public int vendorid { get; set; }

        public Vendors vendors { get; set; }
    }
}
