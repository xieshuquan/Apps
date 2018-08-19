using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apps.WebApp.Repository.Entity.Report
{
    [Table("weekly_report_group")]
    public class WeeklyReportGroup : Base
    {
        [Column("display_name")]
        public string DisplayName { get; set; }

        [Column("description")]
        public string Description { get; set; }

    }
}
