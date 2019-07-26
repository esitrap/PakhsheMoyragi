using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PakhsheMoyragi.Models
{
    public class PakhshDbContext : DbContext
    {
        public PakhshDbContext(DbContextOptions<PakhshDbContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        
    }

   
}
