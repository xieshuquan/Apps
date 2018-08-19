using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apps.WebApp.Repository.Entity.Report
{
    [Table("weekly_report")]
    public class WeeklyReportDetail
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("current_tasks")]
        public string CurrentTasks { get; set; }

        [Column("next_tasks")]
        public string NextTasks { get; set; }

        public int WeekId { get; set; }
    }
}
