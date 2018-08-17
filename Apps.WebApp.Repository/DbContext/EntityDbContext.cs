using System;
using System.Collections.Generic;
using System.Text;
using Apps.WebApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apps.WebApp.Repository.DbContext
{
    public class EntityDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public EntityDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<WeeklyReport> WeeklyReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
