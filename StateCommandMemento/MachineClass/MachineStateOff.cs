using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MachineClass
{
    internal class MachineStateOff  :  IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine OFF");
        }

        public void Print(string text)
        {
            Console.WriteLine("Cannot print when machine is OFF");
        }
    }
}
