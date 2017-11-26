using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures
{
    public class Enhancements
    {
        public void Run()
        {
            Write(GetBitNumber());
            int[] numbers = { 2, 3, 6, 7, 8 };
            ref int position = ref Substitute(8, numbers);
            position = -8;
            Write(numbers[4]);

            Employee1 joe = new Employee1("Manager");
            Write(joe.Position);

            Employee1 mary = new Employee1(null);
            WriteLine(mary.Position);
        }

        public int GetBitNumber()
        {
            return 1_234_345;
        }

        public ref int Substitute(int value, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException("Not found!");
        }
    }

    public class Employee1
    {
        public string Position { get; set; }
        public int Age { get; set; }
        public Employee1(string position, int age) => Position = position ?? throw new ArgumentNullException(); 
    }
}
