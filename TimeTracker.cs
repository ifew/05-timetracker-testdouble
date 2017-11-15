using System;

namespace _05_timetracker_testdouble
{
    internal class TimeTracker
    {
        
        TimeSpan TimeNow = DateTime.Now.TimeOfDay;

        public TimeTracker()
        {
        }

        public TimeTracker(TimeSpan setTime)
        {
            TimeNow = setTime;
        }

        internal bool isOpen()
        {
            
            TimeSpan TimeOpenStart = new TimeSpan(8,0,0);
            TimeSpan TimeOpenEnd = new TimeSpan(17,0,0);

            int CheckOpenStart = TimeSpan.Compare(TimeNow, TimeOpenStart);
            int CheckOpenEnd = TimeSpan.Compare(TimeNow, TimeOpenEnd);
            
            if((CheckOpenStart >= 0) && (CheckOpenEnd <= 0)) {
                return true;
            }

            return false;
        }
        
    }
}