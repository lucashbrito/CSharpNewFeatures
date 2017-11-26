using static System.Console;
using System;
namespace CSharpSevenFeatures
{
    public class LocalFunctions
    {
        public void Run()
        {
            WriteLine(Fibonacci(6));
            //1,1,2,3,5,8,13
        }
        public int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Must be at least 0", nameof(x));
            {
                return Fib(x).current;
            }
            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (current, previous) = Fib(i - 1);
                return (current + previous, current);
            }

        }
    }
}
