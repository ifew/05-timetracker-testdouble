using System;

namespace _05_timetracker_testdouble
{
    public class MockLogger:Logger
    {
        public int called = 0;

        public override void Write(String line)
        {
            called++;
        }
    }
}