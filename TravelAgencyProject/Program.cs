using System.Threading;

namespace TravelAgencyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 2000;

            var console = new ConsoleService();
            console.Question();
            console.UserInputAndResponse();
            
            Thread.Sleep(milliseconds);
            console.ChooseOptions();
        }
    }
}
