using System;
using System.Threading;

namespace TravelAgencyProject
{
    public class ConsoleService
    {
        string name;
        int milliseconds = 1000;

        public void Question()
        {
            Console.WriteLine("Hello there, what is your name?");
        }

        public void UserInputAndResponse()
        {
            name = Console.ReadLine();
            Thread.Sleep(milliseconds);
            Console.WriteLine($"It is very nice to meet you, {name}");
        }

        public void DisplayOptions()
        {
            Console.WriteLine($"Choose an option from the list:");
            Console.WriteLine("A - Read Hotels");
            Console.WriteLine("B - Read Employees");
            Console.Write("Your option: ");
            //var choice = Console.ReadLine();

            //var agency = new Agency();

            switch (Console.ReadLine())
            {
                case "A":
                    // do something here
                    break;
                case "B":
                    // do something here
                    break;
            }
        }
    }
}
