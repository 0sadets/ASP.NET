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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           // builder.HasKey(x=>x.Id);

            //builder.Property(x => x.FirstName)
            //    .IsRequired()
            //    .HasMaxLength(50);
            //builder.Property(x => x.LastName)
            //    .IsRequired()
            //    .HasMaxLength(50);
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(250);
            //builder.Property(x => x.Phone)
            //    .IsRequired()  
            //    .HasMaxLength(15); 

            //builder.Property(x=>x.Address)
            //    .IsRequired()
            //    .HasMaxLength(500);
        }
    }
}
