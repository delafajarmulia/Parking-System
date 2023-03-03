using Microsoft.EntityFrameworkCore;
using ParkingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ParkingSystem
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;database=parkingdb2;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<MembershipType> MemberShipTypes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<HourlyRate> HourlyRates { get; set; }
        public DbSet<ParkingData> ParkingData { get; set; }

        // VIEW //
        public DbSet<ViewMasterMember> ViewMasterMembers { get; set; }
        public DbSet<ViewMasterVehicle> ViewMasterVehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ViewMasterMember>(c =>
            {
                c.HasKey(x => x.IdMember);
                c.ToView("ViewMasterMember");
            });

            modelBuilder.Entity<ViewMasterVehicle>(c =>
            {
                c.HasKey(x => x.VehicleId);
                c.ToView("ViewMasterVehicle");
            });
        }

    }

}
