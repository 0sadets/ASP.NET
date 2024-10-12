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
    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x => x.PublisherName)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasMany(x => x.Books)
                .WithOne(x => x.Publisher)
                .HasForeignKey(x => x.PublisherId);
        }
    }
}
