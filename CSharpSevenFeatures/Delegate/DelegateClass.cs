using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.Delegate
{
    public class DelegateClass
    {
        //Delegate is a function pointer. It is reference type data type.
        //Syntax: public delegate void <function name>(<parameters>)
        //A method that is going to assign to delegate must have same signature as delegate.
        //Delegates can be invoke like a normal function or Invoke() method.
        //Multiple methods can be assigned to the delegate using "+" operator. It is called multicast delegate.

        public delegate void Print(int value);

        public void Initializer()
        {
            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
