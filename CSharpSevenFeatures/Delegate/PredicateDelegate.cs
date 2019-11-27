using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.Delegate
{
    public class PredicateDelegate
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);


            Predicate<string> isUpper2 = delegate (string s) { return s.Equals(s.ToUpper()); };
            
            bool result2 = isUpper("hello world!!");

            Console.WriteLine(result2);
        }

    }
}
