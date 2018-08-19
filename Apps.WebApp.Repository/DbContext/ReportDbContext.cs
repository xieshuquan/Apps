using Apps.WebApp.Repository.Entity.Report;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apps.WebApp.Repository.DbContext
{
    public class ReportDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ReportDbContext(DbContextOptions options) : base(options) { }

        public DbSet<WeeklyReportDetail> WeeklyReportDetails { get; set; }

        public DbSet<WeeklyReportGroup> WeeklyReportGroups { get; set; }

        public DbSet<WeeklyReportUserConfig> WeeklyReportUserConfigs { get; set; }

    }
}
