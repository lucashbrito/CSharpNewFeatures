using System;
using static System.Console;

namespace CSharpSevenFeatures
{
    class UsingOutVariables
    {
        public void Run()
        {
            int hours;
            int minutes;
            int seconds;
            GetTime(out hours, out minutes, out seconds);
            Write($"hour{hours}:minute{minutes}:seconds{seconds}");
        }
        public void RunOutVariables()
        {
            // Here, you do not need to create the variables and after pass as param as before. 
            GetTime(out int hours, out int minutes, out int seconds);
            Write($"hour{hours}:minute{minutes}:seconds{seconds}");
        }

        public void GetTime(out int hours, out int minutes, out int seconds)
        {
            hours = 1;
            minutes = 34;
            seconds = 35;
        }
    }
}
