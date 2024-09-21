﻿using DataAccess.Entities;
using DataAccess.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Book> Books {  get; set; }
        public DbSet<Author> Authors {  get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HSQMI6V\SQLEXPRESS;
                                            Initial Catalog = Book_Shop_DB;
                                            Integrated Security=True;
                                            Connect Timeout=30;
                                            Encrypt=True;
                                            Trust Server Certificate=True;
                                            Application Intent=ReadWrite;
                                            Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedAuthor();
            modelBuilder.SeedBooks();
            modelBuilder.SeedCategory();
            modelBuilder.SeedCustomer();
            modelBuilder.SeedPublisher();
        }
    }
}
