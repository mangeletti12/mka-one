using System;
using Microsoft.EntityFrameworkCore;
using mka_one.Data.Models;

namespace mka_one.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map Entity names to DB Table names
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Country>().ToTable("Countries");

        }

        //
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }



           

        

    }
}
