using CognizantAssessment.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantAssessment.Data
{
    public class VehicleStoreContext: DbContext
    {
        public VehicleStoreContext()
        {

        }
        public VehicleStoreContext(DbContextOptions<VehicleStoreContext> options)
            :base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(p => p.Property<decimal>("price").HasColumnType("decimal(18,2)"));

            modelBuilder.Entity<Warehouse>().HasMany(p => p.Cars).WithOne(e => e.Warehouse);
        }

    }
}
