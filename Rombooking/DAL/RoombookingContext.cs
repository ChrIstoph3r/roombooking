using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Rombooking.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Rombooking.DAL
{
    public class RoombookingContext : DbContext
    {
        public RoombookingContext() : base("RoombookingContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RoombookingContext>());
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
 
    }
}