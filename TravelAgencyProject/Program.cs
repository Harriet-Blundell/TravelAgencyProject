using System.Threading;

namespace TravelAgencyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 1000;

            var console = new ConsoleService();
            console.Question();
            console.UserInputAndResponse();
            
            Thread.Sleep(milliseconds);
            console.DisplayMenu();
        }
    }
}
