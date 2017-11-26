using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpSevenFeatures
{
    class PatternMatching
    {
        public void Run()
        {
            PrintSum(34);
            PrintSum2("45");

        }
        public void PrintSum(object o)
        {
            if (o is null) return; // Constant pattern
            if (!(o is int i)) return;// Type pattern (int)
            int sum = 0;
            for (int j = 0; j < i; j++)
            {
                sum += j;
            }
            WriteLine($"The sum of 1 to {i} is {sum}");
        }
        public void PrintSum2(object o)
        {
            //here, we are able to compare if o is a type of int 
            //or if is type of string and if o is a string, it will be able to parse a int.
            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                int sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += j;
                }
                WriteLine($"The sum of 1 to {i} is {sum}");
            }
        }
    }
}
