using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Machine_Test.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Emp_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
