using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Data.Entities
{
    [Table("vendors")]
    public class Vendors
    {
        [Key]
        public int id { get; set; }

        public string description { get; set; }

        public string website { get; set; }

        public decimal rate { get; set; }

        public RateType ratetype { get; set; }

        public ServiceType servicetype { get; set; }

        public List<AffiliateLinks> affiliatelinks { get; set; }

        public List<Images> images { get; set; }
    }

    public enum RateType
    {
        Hourly,
        Daily,
        Weekly,
        Monthly,
        Quarterly,
        Yearly
    }

    public enum ServiceType
    {
        Food,
        Travel,
        Venue,

    }
}
