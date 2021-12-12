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
            Console.WriteLine("Machine");
            Console.WriteLine("Press Enter for On/OFF");
            Console.WriteLine("Press Space to Exit Program");

            Machine.Machine machine = new Machine.Machine();
            while (true)
            {
                var userinput = Console.ReadKey().Key;
                switch (userinput)
                {
                    case ConsoleKey.Enter:
                        machine.PowerSwitch();
                        break;

                    case ConsoleKey.Spacebar:
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