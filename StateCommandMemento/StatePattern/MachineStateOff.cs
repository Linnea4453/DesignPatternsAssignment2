using System;

namespace Assignment2.StateCommandMemento.Machine
{
    internal class MachineStateOff : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning machine ON");
        }
    }
}