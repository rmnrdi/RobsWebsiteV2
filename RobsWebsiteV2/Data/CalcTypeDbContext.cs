using Microsoft.EntityFrameworkCore;
using RobsWebsiteV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
