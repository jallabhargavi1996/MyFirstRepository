using Microsoft.EntityFrameworkCore;
using MyFirstApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp.Providers
{
    public class StudentDbContext:DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-UQ8DNKD\SQLEXPRESS;initial catalog=EliteCollegeDb;integrated security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
        }
    }
}
