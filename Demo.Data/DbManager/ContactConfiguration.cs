using Demo.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.DbManager
{
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(s => s.Id);
        
            builder.Property(s => s.FirstName).HasMaxLength(500).IsRequired(); ;
            builder.Property(s => s.LastName).HasMaxLength(500).IsRequired(); ;
            builder.Property(s => s.Position).HasMaxLength(500);
        }
    }
}