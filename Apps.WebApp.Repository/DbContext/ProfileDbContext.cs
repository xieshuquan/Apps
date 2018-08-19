using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Apps.WebApp.Repository.Entity.Profile;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Apps.WebApp.Repository.DbContext
{
    public class ProfileDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProfileDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
