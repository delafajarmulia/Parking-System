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
        public DbSet<ViewMasterMember> ViewMasterMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ViewMasterMember>(c =>
            {
                c.HasKey(x => x.IdMember);
                c.ToView("ViewMasterMember");
            });
        }
        //public DbQuery<ViewMasterMember> ViewMasterMembers { get; set; }
        //public System.Data.SqlClient.SqlCommand SelectCommand { get; set; }

        /*public IQueryable<ViewMasterMember> viewMasterMembers
        {
            get
            {
                return this.Database.SqlQuery<ViewMasterMember>("select * from dbo.ViewMasterMember");
            }
        }*/
    }

}
