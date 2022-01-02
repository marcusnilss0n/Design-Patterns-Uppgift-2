using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            AdapterClass adapterClass = new();
            adapterClass.PrintingStringAsInts();          
        }
    }
}
