using Microsoft.EntityFrameworkCore;

namespace AspNetHangfireUsingPostgres
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
