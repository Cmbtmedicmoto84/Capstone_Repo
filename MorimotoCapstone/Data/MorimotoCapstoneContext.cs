using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Data
{
    public class MorimotoCapstoneContext : DbContext
    {
        public MorimotoCapstoneContext (DbContextOptions<MorimotoCapstoneContext> options)
            : base(options)
        {
        }

        public DbSet<MorimotoCapstone.Models.Customer> Customer { get; set; }

        public DbSet<MorimotoCapstone.Models.Employee> Employee { get; set; }
    }
}
