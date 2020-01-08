using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaoPio.Models
{
    public class SaoPioContext : DbContext
    {
        public SaoPioContext (DbContextOptions<SaoPioContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord>  SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
