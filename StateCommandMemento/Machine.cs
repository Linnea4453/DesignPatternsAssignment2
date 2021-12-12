using Assignment2.StateCommandMemento.MementoPattern;

namespace Assignment2.StateCommandMemento.Machine
{
    public class Machine : IMachineState
    {
        private IMachineState MachineState { get; set; }

        public Machine()
        {
            MachineState = new MachineStateOff();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
            }
            else
            {
                MachineState = new MachineStateOff();
            }
        }

        public MachineMemento CreateMemento()
        {
            return null;
        }
    }
}