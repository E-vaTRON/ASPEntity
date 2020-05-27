using ASP_First_Poject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_First_Poject.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<HeadPhone> HeadPhones { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<MechanicalKeyboard> MechanicalKeyboards { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
    }
}
