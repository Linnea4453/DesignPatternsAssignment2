namespace Assignment2.StateCommandMemento.CommandPattern
{
    public class MachineCommand
    {
        public Machine.Machine Machine { get; set; }
        public string Text { get; set; }

        public MachineCommand(Machine.Machine machine, string text)
        {
            Machine = machine;
            Text = text;
        }
    }
}