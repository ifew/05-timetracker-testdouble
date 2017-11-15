using System;

namespace _05_timetracker_testdouble
{
    internal class TimeTracker
    {
        public TimeTracker()
        {
        }

        internal int isOpen()
        {
            TimeSpan TimeNow = DateTime.Now.TimeOfDay;
            
            TimeSpan TimeOpenStart = new TimeSpan(8,0,0);
            int CheckOpen = TimeSpan.Compare(TimeNow, TimeOpenStart);

            return CheckOpen;
        }
        
    }
}