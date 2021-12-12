using System;

namespace Assignment2.StateCommandMemento.Machine
{
    public class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning Machine OFF");
        }
    }
}