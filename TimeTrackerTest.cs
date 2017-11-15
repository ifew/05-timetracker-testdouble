using System;
using Xunit;

namespace _05_timetracker_testdouble
{
    public class TimeTrackerTest
    {
        [Fact]
        public void Input0800GetTrue()
        {
            bool expected = true;

            TimeTracker timetracker = new TimeTracker();
            bool actual = timetracker.isOpen("08:00");

            Assert.Equal(expected, actual);
        }
    }
}
