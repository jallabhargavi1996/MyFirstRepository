using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch  { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }
    }
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(c => c.Id).UseIdentityColumn().HasColumnName("ID");
            builder.Property(c => c.Name).HasMaxLength(100).HasColumnName("NAME").IsRequired(true);
            builder.Property(c => c.MobileNo).HasColumnName("MOBILENO").IsRequired(true);
            builder.Property(c => c.Branch).HasColumnName("BRANCH").HasMaxLength(100).IsRequired(true);
            builder.Property(c => c.Address).HasColumnName("ADDRESS").HasMaxLength(100).IsRequired(true);
            builder.HasKey(C => C.Id);
            builder.ToTable("T_ELITE_STUDENT");
        }
    }

}
