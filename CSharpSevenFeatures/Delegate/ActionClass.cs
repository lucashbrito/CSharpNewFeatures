using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.Delegate
{
    class ActionClass
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            //Anonymous method with Action delegate
            Action<int> printActionDel1 = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);

            //Lambda expression with Action delegate
            Action<int> printActionDel2 = i => Console.WriteLine(i);


        }
    }
}
