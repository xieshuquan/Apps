using System;
using System.Collections.Generic;
using System.Text;

namespace Apps.WebApp.Repository.Domain
{
    public class WeeklyReport
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CurrentTasks { get; set; }

        public string NextTasks { get; set; }

    }
}
