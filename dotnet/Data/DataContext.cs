using HallHeroes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HallHeroes.Data
{
    public class DataContext : DbContext
    {
        public DataContext() 
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NATHAN_LO;Database=Hall;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Knight> Knights { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
