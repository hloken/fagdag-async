using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheSimplestAsync
{
    class Program
    {
        static async Task Main()
        {
            using var client = new HttpClient();

            Console.WriteLine($"Performing HTTP GET Request to Google");
            var result = await client.GetAsync("http://www.google.com");
            Console.WriteLine($"HTTP Status Code:{result.StatusCode}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
