using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using atmcc.Models;

namespace atmcc.Data
{
    public class atmccContext : DbContext
    {
        public atmccContext (DbContextOptions<atmccContext> options)
            : base(options)
        {
        }

        public DbSet<atmcc.Models.ATMComplaint> ATMComplaint { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ATMComplaint>().ToTable("ATMComplaint", "atmcomplaint");

            // Configure database attributes
        }
    }
}
