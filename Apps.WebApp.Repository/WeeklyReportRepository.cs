using Apps.WebApp.Repository.DbContext;
using Apps.WebApp.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps.WebApp.Repository
{
    public class WeeklyReportRepository
    {
        private readonly ProfileDbContext _profileDbContext;
        private readonly ReportDbContext _reportDbContext;

        public WeeklyReportRepository(ProfileDbContext profileDbContext, ReportDbContext reportDbContext)
        {
            this._profileDbContext = profileDbContext;
            this._reportDbContext = reportDbContext;
        }


        public List<WeeklyReport> GetWeeklyReports(string groupName)
        {

            var userConfigs = _reportDbContext.WeeklyReportUserConfigs.Join(
                    _reportDbContext.WeeklyReportGroups,
                    x => x.GroupId,
                    y => y.Id, (x, y) => new
                    {
                        x.UserId,
                        x.Sequence,
                        y.DisplayName,
                    }
                ).Where(x => x.DisplayName == groupName).Select(x => new
                {
                    x.UserId,
                    x.Sequence,
                }).ToList();

            var userIds = userConfigs.Select(x => x.UserId).ToList();

            var users = _profileDbContext.Users.Where(x => userIds.Contains(x.Id));
            var report = _reportDbContext.WeeklyReportDetails.Where(x => userIds.Contains(x.UserId)).Select(x => new
            {
                x.UserId,
                x.CurrentTasks,
                x.NextTasks,
            });
        }

    }
}
