using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using User.API.Models;

namespace User.API.Data
{
    public class AppUserContext:DbContext
    {

        public AppUserContext(DbContextOptions<AppUserContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().ToTable("Users").HasKey(u => u.Id);
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<AppUser> Users { get;set; }
    }
}
