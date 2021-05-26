using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Text += $"Starting in thread: {Thread.CurrentThread.ManagedThreadId} \r\n";
        }

        private void SyncException()
        {
            throw new CrazyBananaException();
        }

        private void buttonNormalException_Click(object sender, EventArgs e)
        {
            try
            {
                SyncException();
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }

        }
        
        private async void buttonAsyncException_Click(object sender, EventArgs e)
        {
            try
            {
                await ASyncException();
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }
        }

        private async Task ASyncException()
        {
            throw new CrazyBananaException();
        }

        private async void buttonMultipleAsyncExceptions_Click(object sender, EventArgs e)
        {
            try
            {
                await MultipleASyncException();
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }
        }

        private async Task MultipleASyncException()
        {
            var task1 = Task.Run(() => throw new CrazyBananaException());
            var task2 = Task.Run(() => throw new ArithmeticException("ArithmeticException is thrown."));

            await Task.WhenAll(task1, task2);
        }

        private void buttonTaskRunException_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run( SyncException).Wait();
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }
        }

        private void buttonTaskRunAsyncException_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(async () => await ASyncException()).Wait();
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }
        }

        private async void buttonAsyncTaskRunAsyncException_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(async () => await ASyncException());
            }
            catch (Exception exception)
            {
                OutputExceptionMessage(exception);
            }
        }

        private void OutputExceptionMessage(Exception exception, int? threadId = null)
        {
            var threadIdToUse = threadId ?? Thread.CurrentThread.ManagedThreadId;

            if (InvokeRequired)
            {
                Invoke(new Action<Exception, int?>(OutputExceptionMessage), new object[] { exception, threadIdToUse});
                return;
            }

            textBox1.Text += $"Got exception of type: {exception.GetType()} in thread: {threadIdToUse}\r\n";
        }
    }

    internal class CrazyBananaException : Exception
    {
    }
}
