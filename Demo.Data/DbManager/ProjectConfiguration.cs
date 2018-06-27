using Demo.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.DbManager
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
     
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(500).IsRequired(); ;
            builder.Property(s => s.Duration).HasMaxLength(500).IsRequired(); ;
       

        }
    }
}