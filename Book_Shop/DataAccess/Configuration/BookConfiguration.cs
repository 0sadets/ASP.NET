using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
namespace DataAccess.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // fluent api
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Title)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.ISBN)
                .IsRequired()
                .HasMaxLength(13);
            builder.Property(b => b.PaperPrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)") 
                .HasDefaultValue(0)              
                .HasPrecision(18, 2);
            builder.Property(b => b.EBookPrice)
               .IsRequired()
               .HasColumnType("decimal(18,2)")
               .HasDefaultValue(0)
               .HasPrecision(18, 2);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000);
            builder.Property(b => b.Count)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(b => b.Year)
                .IsRequired()
                .HasDefaultValue(0);
            builder.Property(b => b.ImagePath)
                .HasMaxLength(2048);
            builder.Property(b => b.Language)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(b => b.NumberOfPages)
                .IsRequired()
                .HasDefaultValue(0);

            builder.HasOne(a => a.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(p=>p.AuthorId);
            builder.HasOne(a => a.Category)
                .WithMany(b => b.Books)
                .HasForeignKey(p => p.CategoryID);
            builder.HasOne(a => a.Publisher)
                .WithMany(b => b.Books)
                .HasForeignKey(p => p.PublisherId);
            //builder.HasMany(b => b.Carts)
            //    .WithOne(c => c.Books)
            //    .IsRequired(false);
        }
    }
}
