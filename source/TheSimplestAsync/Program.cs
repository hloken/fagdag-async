using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheSimplestAsync
{
    class Program
    {
        static async Task Main()  // Async main method added in C# 7.1
        {
            using var client = new HttpClient();

            var result = await client.GetAsync("http://www.google.com");

            Console.WriteLine($"HTTP Status Code:{result.StatusCode}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
