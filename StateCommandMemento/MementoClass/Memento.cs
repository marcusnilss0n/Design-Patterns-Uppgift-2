using Assignment2.StateCommandMemento.CommandClass;
using Assignment2.StateCommandMemento.MachineClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.MementoClass
{
    class Memento
    {
        public Machine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public List<ICommand> CommandList { get; set; }

        public Memento(Machine machine, IMachineState machineState, List<ICommand> commandList)
        {
            Machine = machine;
            MachineState = machineState;
            CommandList = new List<ICommand>(commandList);
        }

        public void LoadMemento()
        {
            Machine.MachineState = MachineState;
            Machine.CommandList = new List<ICommand>(CommandList);
        }
    }
}
