using System;

namespace CSharpSevenFeatures.Delegate
{
    public class PrintHelperEvent
    {
        // declare delegate 
        public delegate void BeforePrint();
        public delegate void BeforePrintWitArgument(string message);

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;
        public event BeforePrintWitArgument beforePrintWitArgument;

        public PrintHelperEvent()
        {

        }

        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            beforePrintEvent?.Invoke();
            beforePrintWitArgument?.Invoke("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            beforePrintEvent?.Invoke();
            beforePrintWitArgument?.Invoke("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            beforePrintEvent?.Invoke();
            beforePrintWitArgument?.Invoke("PrintMoney");

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            beforePrintEvent?.Invoke();
            beforePrintWitArgument?.Invoke("PrintTemperature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            beforePrintEvent?.Invoke();
            beforePrintWitArgument?.Invoke("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
