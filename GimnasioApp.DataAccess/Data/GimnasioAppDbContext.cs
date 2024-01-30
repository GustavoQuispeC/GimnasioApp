using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.DataAccess.Data
{
    public class GimnasioAppDbContext : DbContext
    {
        public GimnasioAppDbContext(DbContextOptions<GimnasioAppDbContext>options)
            : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GimnasioAppDbContext).Assembly);
        }
    }
}
