using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CategoryName)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasMany(p => p.Books)
                .WithOne(x => x.Category)
                .HasForeignKey(d => d.CategoryID);
        }
    }
}
