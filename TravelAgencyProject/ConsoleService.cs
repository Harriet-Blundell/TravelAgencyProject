using System;

namespace TravelAgencyProject
{
    public class ConsoleService
    {

        public void Question()
        {
            Console.WriteLine("Hello there, what is your name?");
        }

        public void UserInputAndResponse()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"It is very nice to meet you, {name}");
        }
    }
}
