using Microsoft.EntityFrameworkCore;
using MVCTestEFCore.Models;
namespace MVCTestEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<MVCTestEFCore.Models.FirstTable>? FirstTable { get; set; }
    }
}
