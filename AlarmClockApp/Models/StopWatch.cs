using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockApp.Models
{
    internal class StopWatch
    {
        public DateTime StartTime { get; set; }
        public TimeSpan ElapsedTime { get; set; }

        public TimeSpan TotalElapsedTime  = TimeSpan.Zero;
    }
}
