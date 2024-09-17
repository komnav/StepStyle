using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ShoeContextDbFactory : IDesignTimeDbContextFactory<ShoeDbContext>
    {
        public ShoeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShoeDbContext>();
            optionsBuilder.UseSqlite("Data Source=shoe_test.db");

            return new ShoeDbContext(optionsBuilder.Options);
        }
    }
}
