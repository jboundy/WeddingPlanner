using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Data.Entities;

namespace WeddingPlanner.Data.Repository
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {

        }
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<Budget> Budget { get; set; }

        public virtual DbSet<Guests> Guests { get; set; }

        public virtual DbSet<Images> Images { get; set; }

        public virtual DbSet<Plan> Plan { get; set; }

        public virtual DbSet<Schedule> Schedule { get; set;}

        public virtual DbSet<Roles> Roles { get; set; }

        public virtual DbSet<Vendors> Vendors { get; set; }

        public virtual DbSet<AffiliateLinks> AffiliateLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //todo: need to build out indexes for tables either here or annotations
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
