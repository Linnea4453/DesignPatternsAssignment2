using Assignment2.StateCommandMemento.CommandPattern;
using Assignment2.StateCommandMemento.Machine;
using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento.MementoPattern
{
    public class MachineMemento
    {
        public PrintMachine Printer { get; set; }
        public List<MachineCommand> ListOfWord { get; set; }

        public MachineMemento(PrintMachine printer, List<MachineCommand> listOfWord)
        {
            Printer = printer;
            ListOfWord = listOfWord;
        }


        public void Restore()
        {
            Console.WriteLine("Reset and turning off");
            Printer.ListOfWord.Clear();
            Printer.MachineState= new MachineStateOff();

        }
    }
}


