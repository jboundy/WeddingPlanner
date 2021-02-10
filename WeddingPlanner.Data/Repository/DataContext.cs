using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Data.Entities;

namespace WeddingPlanner.Data.Repository
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<Permissions> Permissions { get; set; }

        public virtual DbSet<Roles> Roles { get; set; }

        public virtual DbSet<Vendors> Vendors { get; set; }

        public virtual DbSet<AffiliateLinks> AffiliateLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
