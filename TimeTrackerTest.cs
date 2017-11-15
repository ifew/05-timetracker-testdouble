using System;
using Xunit;

namespace _05_timetracker_testdouble
{
    public class TimeTrackerTest
    {
        //[Fact]
        public void InputTimeNowGetTrue()
        {
            bool expected = true;

            TimeTracker timetracker = new TimeTracker();
            bool actual = timetracker.isOpen();

            Assert.Equal(expected, actual);
        }

        //[Fact]
        public void InputTimeNowGetFalse()
        {
            bool expected = false;

            TimeTracker timetracker = new TimeTracker();
            bool actual = timetracker.isOpen();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTimeSpanGetEqual()
        {
            int expected = 0;

            TimeSpan time1 = new TimeSpan(8,9,50);
            TimeSpan time2 = new TimeSpan(8,9,50);
            int actual = TimeSpan.Compare(time1, time2);

            Assert.Equal(expected, actual);
        }
    }
}
