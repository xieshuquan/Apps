using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Apps.WebApp.Repository.Entity.Report
{
    [Table("weekly_report_user_config")]
    public class WeeklyReportUserConfig : Base
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("group_id")]
        public int GroupId { get; set; }

        [Column("sequence")]
        public int Sequence { get; set; }

    }
}
