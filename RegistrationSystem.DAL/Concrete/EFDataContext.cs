using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RegistrationSystem.Entities;

namespace RegistrationSystem.DAL.Concrete
{
    public class EfDataContext : DbContext
    {
        public EfDataContext() : base("RegistrationContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Kindergarten> Kindergartens { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
        public DbSet<Staff> Staves { get; set; }
        public DbSet<StaffPosition> StaffPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kindergarten>()
            //        .HasRequired(p => p.Address)
            //        .WithOptional(c => c.Kindergarten);
            // Prevents table names from being pluralized. 
            // If you didn't do this, the generated tables in the database would be named Categories, CreditCards, and User. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}
