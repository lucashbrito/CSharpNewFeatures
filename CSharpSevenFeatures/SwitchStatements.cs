using static System.Console;

namespace CSharpSevenFeatures
{
    class SwitchStatements
    {
        public void Run()
        {
            Employee1 theEmployee = new VicePresidente
            {
                Salary = 175000,
                Years = 7,
                NumberManaged = 200,
                StockShares = 6000
            };

            Employee1 theEmployee1 = new VicePresidente();
            theEmployee1.Salary = 8000;
            theEmployee1.Years = 8;
            (theEmployee1 as VicePresidente).NumberManaged = 343;
            (theEmployee1 as VicePresidente).StockShares = 4654;

            switch (theEmployee1)
            {
                case VicePresidente vp when (vp.StockShares < 500):
                    WriteLine($"Junior VP with {vp.StockShares} sahres");
                    break;

                case Manager m:
                    WriteLine($"Manager with:{m.NumberManaged} reporting");
                    break;

                case Employee1 e:
                    WriteLine($"Employee with salary:{e.Salary}");
                    break;

                default:
                    break;
            }
        }

    }

    public class Employee1
    {
        public int Salary { get; set; }
        public int Years { get; set; }
    }

    public class Manager : Employee1
    {
        public int NumberManaged { get; set; }
    }

    public class VicePresidente : Manager
    {
        public int StockShares { get; set; }
    }
}
