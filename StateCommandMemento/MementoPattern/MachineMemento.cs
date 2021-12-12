using System;

namespace Assignment2.StateCommandMemento.MementoPattern
{
    public class MachineMemento
    {
        public Machine.Machine Machine { get; set; }

        public MachineMemento(Machine.Machine machine)
        {
            Machine = machine;
        }

        public void Restore()
        {
            Console.WriteLine("Restore ");
        }
    }
}