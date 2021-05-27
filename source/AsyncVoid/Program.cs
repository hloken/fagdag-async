using System;
using System.Threading.Tasks;

namespace AsyncVoid
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ResolveIssue(); // Cannot await a method that is async void so this is fire-and-forget

            Console.WriteLine("I am quitting now");
        }

        public static async void ResolveIssue()
        {
            await Task.Delay(10000);

            Console.WriteLine("I finished!");
        }
    }
}
