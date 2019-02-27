using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace FunApp.Web.Models
{
    public class FunAppContext : IdentityDbContext<FunAppUser>
    {
        public FunAppContext(DbContextOptions<FunAppContext> options)
            : base(options)
        {
        }

        // My Table Add

        public DbSet<Category> Categories { get; set; }

        public DbSet<Joke> Jokes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
