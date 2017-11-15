using System;

namespace _05_timetracker_testdouble
{
    internal class TimeTracker
    {
        public TimeTracker()
        {
        }

        internal bool isOpen(string v)
        {
            if((v == "08:00") || (v == "17:00")) {
                return true;
            }
            return false;
        }
    }
}