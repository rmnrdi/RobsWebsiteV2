using Microsoft.EntityFrameworkCore;
using RobsWebsiteV2.Models;

namespace RobsWebsiteV2.Data
{
    public class CalcTypesDbContext : DbContext
    {
        public DbSet<CalcType> CalcTypes { get; set; }

        public CalcTypesDbContext(DbContextOptions<CalcTypesDbContext> options) : base (options)
        {

        }
    }
}
