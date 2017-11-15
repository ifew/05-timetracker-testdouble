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

            TimeSpan time1 = new TimeSpan(8,0,0);
            TimeSpan time2 = new TimeSpan(8,0,0);
            int actual = TimeSpan.Compare(time1, time2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTimeSpanTime1MoreThanTime2()
        {
            int expected = 1;

            TimeSpan time1 = new TimeSpan(9,0,0);
            TimeSpan time2 = new TimeSpan(8,0,0);
            int actual = TimeSpan.Compare(time1, time2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputTimeSpanTime1LessThanTime2()
        {
            int expected = -1;

            TimeSpan time1 = new TimeSpan(8,0,0);
            TimeSpan time2 = new TimeSpan(9,0,0);
            int actual = TimeSpan.Compare(time1, time2);

            Assert.Equal(expected, actual);
        }
    }
}
