using Assignment2.StateCommandMemento.MementoClass;
using Assignment2.StateCommandMemento.MachineClass;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        public Memento Memento { get; set; }
        public void Run()
        {
            Console.WriteLine("Press 1 to turn your Machine on/off");
            Console.WriteLine("Press 2 to enter your text");
            Console.WriteLine("Press 3 to Save Machine as is now");
            Console.WriteLine("Press 4 to Load Machine Memento");

            Machine machine = new();

            while (true)
            {
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        machine.PowerSwitch();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Enter the text you want to Print: ");
                        string userText = Console.ReadLine();
                        machine.Print(userText);
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Memento = machine.CreateMemento();
                        Console.WriteLine("Saved");
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Memento.LoadMemento();
                        Console.WriteLine("Loaded");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}