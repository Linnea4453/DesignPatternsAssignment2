using Assignment2.StateCommandMemento.CommandPattern;
using Assignment2.StateCommandMemento.Machine;
using Assignment2.StateCommandMemento.MementoPattern;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!   CHECK
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        public void Run()
        {
            PrintMachine printer = new PrintMachine();
            var commandManager = new CommandManager(printer);
            MachineMemento machineMemento = printer.CreateMemento();

            //PrintMachine machine = new PrintMachine();


            Console.WriteLine("Machine");
            Console.WriteLine("Press A for On/OFF");
            Console.WriteLine("Press W to type in word and print it");
            Console.WriteLine("Press R to reset and turn off");
            Console.WriteLine("Press X to Exit Program");

                while (true)
                {
                    var userinput = Console.ReadKey(true).Key;
                    switch (userinput)
                    {
                        case ConsoleKey.A:
                            printer.PowerSwitch();
                            foreach (var word in printer.ListOfWord)
                            {
                                commandManager.PrintWord(word.Text);
                            }
                        printer.ListOfWord.Clear();
                            break;

                        case ConsoleKey.W:
                            Console.WriteLine("Enter word:");
                            var input = Console.ReadLine();
                            commandManager.PrintWord(input);
                            break;



                        case ConsoleKey.R:
                            Console.WriteLine("Reset and turn off");
                            machineMemento.Restore();
                            break;

                        case ConsoleKey.X:
                            Environment.Exit(0);
                            break;

                        default:
                         
                            Console.WriteLine("Sorry, wrong turn");
                            break;
                    }
                }
            }
        
    }
}

