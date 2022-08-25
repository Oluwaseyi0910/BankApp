using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BankApp.Models.DB_Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Middlename)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.MatricNo)
                .IsUnicode(false);
        }
    }
}
