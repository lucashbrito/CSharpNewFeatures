using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures
{
    class DeconstructingTuples
    {
        public void Run()
        {
            var time = GetTime();
            Write($"Time:{time.Item1}:{time.Item2}:{time.Item3}");

            var time2 = GetTime2();
            Write($"Time:{time2.hour}:{time2.minute}:{time2.second}");

            var tupleDictionary = new Dictionary<(int, int), string>();
            tupleDictionary.Add((100, 20), "your room is #20 on the 100th floor");
            tupleDictionary.Add((100, 23), "your room is on the 100th floor, room 23");

            var result = tupleDictionary[(50, 10)];
            WriteLine(result);

            (int hours, int minutes, int seconds) = GetTime2();
            Write($"Time:{time2.hour}:{time2.minute}:{time2.second}");
        }

        public (int, int, int) GetTime()
        {
            return (1, 34, 35);// tuple literal
        }

        public (int hour, int minute, int second) GetTime2()
        {
            return (1, 34, 35);// tuple literal
        }


    }
}
