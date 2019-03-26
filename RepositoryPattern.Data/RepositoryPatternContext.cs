using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Data
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext() {}

        public RepositoryPatternContext(DbContextOptions<RepositoryPatternContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=cx\sqlexpress;Database=RepositoryPattern;Trusted_Connection=True;ConnectRetryCount=0";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Part> Parts { get; set; }
    }
}
