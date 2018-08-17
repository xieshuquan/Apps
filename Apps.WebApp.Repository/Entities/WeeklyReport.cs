using System;
using System.Collections.Generic;
using System.Text;

namespace Apps.WebApp.Repository.Entities
{
    public class WeeklyReport
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string CurrentTasks { get; set; }

        public string NextTasks { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
