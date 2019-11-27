using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSevenFeatures.Delegate
{
    public class NumberSubscriber
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private PrintHelperEvent _printHelper;

        public NumberSubscriber(int val)
        {
            _value = val;

            _printHelper = new PrintHelperEvent();
            //subscribe to beforePrintEvent event
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            _printHelper.beforePrintWitArgument += printHelper_beforePrintEvent;
        }

        //beforePrintevent handler
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine($"BeforPrintEventHandler: fires from {message}");
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
