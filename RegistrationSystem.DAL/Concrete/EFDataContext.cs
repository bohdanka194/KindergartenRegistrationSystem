using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public EfDataContext() : base("RegistrationSystem")
        {

        }

        public DbSet<User> Users { get; set; }
        
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
            
            modelBuilder.Entity<Child>()
            .HasRequired(c1 => c1.BirthCertificate)
            .WithRequiredPrincipal(c2 => c2.Child);

            //modelBuilder.Entity<Child>()
            //.HasRequired(c1 => c1.Order)
            //.WithRequiredPrincipal(c2 => c2.Child);

            //modelBuilder.Entity<Order>().Property(t => t.Id)
            //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Child>()
            //        .HasOptional(a => a.Order )
            //        .WithOptionalDependent()
            //        .WillCascadeOnDelete(true);
            //modelBuilder.Entity<Child>()
            //        .HasOptional(a => a.BirthCertificate)
            //        .WithOptionalDependent()
            //        .WillCascadeOnDelete(true);


            //modelBuilder.Entity<User>()
            //    .HasOptional(c => c.Orders)
            //    .WithOptionalDependent()
            //    .WillCascadeOnDelete(true);

            //modelBuilder.Entity<SuperHero>()
            //        .HasMany(x => x.Gadgets)
            //        .WithRequired() //use the override that doesn't 
            //           //specify a navigation property             
            //        .WillCascadeOnDelete();

            //modelBuilder.Entity<User>()
            //    .HasRequired(c => c.Orders)
            //    .WithMany()
            //    .WillCascadeOnDelete(true);

            //modelBuilder.Entity<Order>()
            //    .HasRequired(o => o.User)
            //    .WithMany()
            //    .WillCascadeOnDelete(true);

        }
    }
}
