using System;
using Xunit;

namespace _05_timetracker_testdouble
{
    public class TimeTrackerLoggerTest
    {

        [Fact]
        public void CheckLoggerCalled()
        {
            TimeTracker timetracker = new TimeTracker();
            MockLogger mocklogger = new MockLogger();
            timetracker.SetLogger(mocklogger);
            
            bool actual = timetracker.isOpen();

            Assert.Equal(1, mocklogger.called);
        }

        [Fact]
        public void CheckLoggerCalledWithExpected()
        {
            TimeTracker timetracker = new TimeTracker();
            MockLogger mocklogger = new MockLogger();
            timetracker.SetLogger(mocklogger);
            
            String expected = DateTime.Now.ToString();
            String actual = mocklogger.lines;

            Assert.Equal(expected, actual);
        }
    }
}
