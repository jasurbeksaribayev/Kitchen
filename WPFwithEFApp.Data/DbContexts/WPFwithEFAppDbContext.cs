using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFwithEFApp.Domain.Entities;

namespace WPFwithEFApp.Data.DbContexts
{
    public class WPFwithEFAppDbContext : DbContext
    {
            public DbSet<User> Users { get; set; }
            public DbSet<Meals> Meals { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Username=postgres; Password=coderfrom2022; Database=WPFwithEFApp");
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<User>().
                HasIndex(u => u.UserName).
                IsUnique(true);

                modelBuilder.Entity<Meals>().
                HasIndex(u => u.Name).
                IsUnique(true);
        }
    }
}

