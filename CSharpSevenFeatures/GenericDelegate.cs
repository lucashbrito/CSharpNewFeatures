using System;

namespace CSharpSevenFeatures
{
    public class GenericDelegate
    {
        //Advantages of Generics
        //    Increases the reusability of the code.
        //    Generic are type safe.You get compile time errors if you try to use a different type of data than the one specified in the definition.
        //    Generic has a performance advantage because it removes the possibilities of boxing and unboxing.

        public delegate T add<T>(T param1, T param2);

        public void Initializer()
        {
            add<int> sum = AddNumber;

            Console.WriteLine(sum(10, 20));

            add<string> conct = Concate;

            Console.WriteLine(conct("Hello", "World!!"));
        }


        public static int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concate(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
