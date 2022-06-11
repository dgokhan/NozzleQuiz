﻿using Microsoft.EntityFrameworkCore;

namespace NozzleQuiz.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
