using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Data.Entities
{
    [Table("images")]
    public class Images
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("FK_VendorImages")]
        public int vendorid { get; set; }

        public ImageType imagetype { get; set; }

        public string location { get; set; }
    }

    public enum ImageType
    {
        Url,
        Local,
        Cloud
    }
}
