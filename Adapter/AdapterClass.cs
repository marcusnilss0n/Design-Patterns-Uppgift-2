using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class AdapterClass
    {
        public void PrintingStringAsInts()
        {
            ReturningStrings returnString = new();
            PrintingInts printingInts = new();

            var inputString = returnString.ReturnString();
            var StringToInt = Int32.Parse(inputString);

            printingInts.Print(StringToInt);
        }
    }
}
