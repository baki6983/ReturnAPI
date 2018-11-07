using ExpressReturnAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressReturnAPI
{
    public class ReturnHeadDbContext:DbContext
    {
        public ReturnHeadDbContext(DbContextOptions<ReturnHeadDbContext> options)
            : base(options)
        {
        }
        public DbSet<ReturnHead> ReturnHeadDTOs { get; set; }
        public DbSet<Customer> CustomerDTOs { get; set; }
        public DbSet<Line> LineDTOs { get; set; }
    }
}
