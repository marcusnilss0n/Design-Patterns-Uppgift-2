using Assignment2.StateCommandMemento.CommandClass;
using Assignment2.StateCommandMemento.MementoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = Assignment2.StateCommandMemento.CommandClass.ICommand;

namespace Assignment2.StateCommandMemento.MachineClass
{
    class Machine  :  IMachineState
    {
        public IMachineState MachineState { get; set; }
        public List<ICommand> CommandList { get; set; }
        public Machine()
        {
            MachineState = new MachineStateOff();
            CommandList = new();
        }

        public void PowerSwitch()
        {
            if(MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                MachineState.PowerSwitch();
                foreach (var item in CommandList)
                {
                    item.Go();
                }
                CommandList.Clear();
            }
            else
            {
                MachineState = new MachineStateOff();
                MachineState.PowerSwitch();
            }
        }

        public void Print(string text)
        {
            MachineState.Print(text);
            if (MachineState is MachineStateOff)
            {
                MachineCommand command = new(this, text);
                CommandList.Add(command);
            }
        }

        public Memento CreateMemento()
        {
            Memento saveMemento = new(this, MachineState, CommandList);
            return saveMemento;
        }
    }
}
