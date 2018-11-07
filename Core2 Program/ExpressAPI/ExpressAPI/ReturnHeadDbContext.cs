using ExpressAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressAPI
{
    public class ReturnHeadDbContext:DbContext
    {
        public DbSet<ReturnHead> ReturnHeadDTOs { get; set; }
        public DbSet<Customer> CustomerDTOs { get; set; }
        public DbSet<Line> LineDTOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=ReturnExpress;Integrated Security=True");

        }
    }
}
