using System;

namespace Assignment2.StateCommandMemento.CommandPattern
{
    public class MachineCommand : ICommand
    {
        public Machine.PrintMachine Machine { get; set; }
        public string Text { get; set; }

        public MachineCommand(Machine.PrintMachine machine, string text)
        {
            Machine = machine;
            Text = text;
        }

        public void PrintWord()
        {
            Machine.Print(Text);
        }
    }
}