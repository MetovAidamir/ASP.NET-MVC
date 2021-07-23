using ExampleASP.NET.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleASP.NET.Data
{
    public class content:DbContext
    {
        public content (DbContextOptions<content> options):base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> shopCartItems { get; set; }
    }
}
