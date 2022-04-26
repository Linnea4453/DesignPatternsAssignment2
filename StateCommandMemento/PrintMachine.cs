using Assignment2.StateCommandMemento.CommandPattern;
using Assignment2.StateCommandMemento.MementoPattern;
using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento.Machine
{
    public class PrintMachine : IMachineState
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> ListOfWord { get; set; } 

        public PrintMachine()
        {
            MachineState = new MachineStateOff();
            ListOfWord = new List<MachineCommand>();
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
        public void Print(string word) 
        {
            Console.WriteLine($"Printing word : {word}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, ListOfWord);
        }
    }
}