using System;

namespace _05_timetracker_testdouble
{
    public class Logger
    {
        public virtual void Write(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("./test.txt", true);
            file.WriteLine(lines);

            file.Close();
        }
    }
}