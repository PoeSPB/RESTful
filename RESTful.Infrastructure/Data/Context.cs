using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RESTful.Domain;

namespace RESTful.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options) 
        { 
        }

        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Post>? Posts { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}