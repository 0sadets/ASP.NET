using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(p=> p.Id);
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Biography)
                .IsRequired()
                .HasMaxLength(4000);
			builder.Property(b => b.ImagePath)
				.HasMaxLength(2048);

			builder.HasMany(b => b.Books)
                .WithOne(a => a.Author)
                .HasForeignKey(a => a.AuthorId);



        }
    }
}
