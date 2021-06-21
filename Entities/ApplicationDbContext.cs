using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<PasswordRecord> Passwords { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PasswordsRole> PasswordsRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.HasDefaultSchema("public");

        }
    }
}
