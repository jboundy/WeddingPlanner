using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WeddingPlanner.Data.Repository
{
    public class DataContextInitializer : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;database=WeddingPlanner;trusted_connection=true;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}