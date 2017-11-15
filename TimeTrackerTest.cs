using System;
using Xunit;

namespace _05_timetracker_testdouble
{
    public class TimeTrackerTest
    {
        [Fact]
        public void InputTimeNowGetTrue()
        {
            bool expected = true;

            TimeTracker timetracker = new TimeTracker();
            bool actual = timetracker.isOpen();

            Assert.Equal(expected, actual);
        }
    }
}
