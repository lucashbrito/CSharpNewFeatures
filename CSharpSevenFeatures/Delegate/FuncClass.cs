using System;

namespace CSharpSevenFeatures.Delegate
{
    public class FuncClass
    {

        //Func is built-in delegate type.
        //Func delegate type must return a value.
        //Func delegate type can have zero to 16 input parameters.
        //Func delegate does not allow ref and out parameters.
        //Func delegate type can be used with an anonymous method or lambda expression.

        static int Sum(int x, int y)
        {
            return x + y;
        }

        void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);

            //Func with Zero Input Parameter
            Func<int> getRandomNumber;

            getRandomNumber = delegate ()
             {
                 Random rnd = new Random();
                 return rnd.Next(1, 100);
             };

            //Func with lambda expression
            getRandomNumber = () => new Random().Next(1, 100);
            //Or 
            Func<int, int, int> Sum1 = (x, y) => x + y;
        }

    }
}
