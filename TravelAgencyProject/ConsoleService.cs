using System;

namespace TravelAgencyProject
{
    public class ConsoleService
    {
        string name;

        public void Question()
        {
            Console.WriteLine("Hello there, what is your name?");
        }

        public void UserInputAndResponse()
        {
            name = Console.ReadLine();
            Console.WriteLine($"It is very nice to meet you, {name}");
        }

        public void DisplayMenu()
        {
            Console.WriteLine($"I have an important question for you, {name}");
            

        }
    }
}
