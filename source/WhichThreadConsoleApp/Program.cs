using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WhichThreadConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            OutputMessage("Starting main");

            await AwaitDelayWithConfigureAwaitTrue().ConfigureAwait(true);

            await AwaitDelayWithConfigureAwaitFalse().ConfigureAwait(false);

            OutputMessage("Ending main");
            ;
        }

        private static async Task AwaitDelayWithConfigureAwaitTrue()
        {
            OutputMessage("Starting await Delay with ConfigureAwait(true)");

            await Delay(true).ConfigureAwait(true);

            OutputMessage("Ending await Delay with ConfigureAwait(true)");
        }

        private static async Task AwaitDelayWithConfigureAwaitFalse()
        {
            OutputMessage("Starting await Delay with ConfigureAwait(false)");

            await Delay(false).ConfigureAwait(false);

            OutputMessage("Ending await Delay with ConfigureAwait(false)");
        }

        private static async Task Delay(bool configureAwait)
        {
            OutputMessage("Starting Delay method");

            await Task.Delay(2000).ConfigureAwait(configureAwait);

            OutputMessage("Ending Delay method");
        }

        private static void OutputMessage(string message)
        {
            var threadIdToUse = Thread.CurrentThread.ManagedThreadId;

            Debug.WriteLine($"Thread: {threadIdToUse} Message: {message}");
        }
    }
}
