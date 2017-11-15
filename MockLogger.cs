using System;

namespace _05_timetracker_testdouble
{
    public class MockLogger:Logger
    {
        public int called = 0;
        public string lines = DateTime.Now.ToString();

        public override void Write(String lines)
        {
            called++;
            this.lines = lines;
        }
    }
}