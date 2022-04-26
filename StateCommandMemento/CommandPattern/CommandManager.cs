using Assignment2.StateCommandMemento;
using Assignment2.StateCommandMemento.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.CommandPattern
{
    public class CommandManager
    {
        public PrintMachine Printer { get; set; }
        public CommandManager(PrintMachine printer)
        {
            Printer = printer;
        }


        public void PrintWord(string input) 
        {
            var word = new MachineCommand(Printer, input);

            if (Printer.MachineState is MachineStateOff)
            {
                Printer.ListOfWord.Add(word);
                Console.WriteLine("Printer is off... Saving word until printer is on.");
            }
            else
            {
                word.PrintWord();
            }
        }
    }
}
