using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ShoeDbContext : DbContext
    {
        public ShoeDbContext(DbContextOptions options) : base(options)
        {
            if (!Users.Any())
            {
                Users.Add(new User
                {
                    UserName = "admin",
                    Password="admin"    
                });
                SaveChanges();
            }
        }

        public DbSet<User> Users { get; set; }
        //public DbSet<Shoe> Shoes { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

