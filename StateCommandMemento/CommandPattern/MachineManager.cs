namespace Assignment2.StateCommandMemento.CommandPattern
{
    public class MachineManager
    {
        public Machine.Machine Machine { get; set; }

        public MachineManager(Machine.Machine machine)
        {
            Machine = machine;
        }

        public void PrintWord()
        {
        }
    }
}