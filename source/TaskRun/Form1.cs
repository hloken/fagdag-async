using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable PossibleNullReferenceException

namespace TaskRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputStartMessage(MethodBase.GetCurrentMethod().Name);
        }

        private void buttonBlocking_Click(object sender, EventArgs e)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            OutputStartMessage(methodName);

            Task.Delay(10000).Wait();

            OutputEndMessage(methodName);
        }

        private void buttonTaskRun_Click(object sender, EventArgs e)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            OutputStartMessage(methodName);

            Task.Run(() =>
            {
                OutputStartMessage(methodName + "Lambda");
                return Task.Delay(10000);
            }).Wait();

            OutputEndMessage(methodName);
        }

        private async void buttonAwaitableTaskRun_Click(object sender, EventArgs e)
        {
            var methodName = "buttonAwaitableTaskRun_Click";
            OutputStartMessage(methodName);

            await Task.Run(() =>
            {
                OutputStartMessage(methodName + "Lambda");
                return Task.Delay(10000);
            });

            OutputEndMessage(methodName);
        }

        private void buttonTaskRunOnAwaitable_Click(object sender, EventArgs e)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            OutputStartMessage(methodName);

            Task.Run(async () =>
            {
                OutputStartMessage(methodName + "Lambda");
                await Task.Delay(10000);
                OutputEndMessage(methodName + "Lambda");
            }).Wait();

            OutputEndMessage(methodName);
        }
        
        private void OutputStartMessage(string methodName, int? threadId = null)
        {
            var threadIdToUse = threadId ?? Thread.CurrentThread.ManagedThreadId;

            if (InvokeRequired)
            {
                Invoke(new Action<string, int?>(OutputStartMessage), new object[] { methodName, threadIdToUse });
                return;
            }

            textBox1.Text += $"Method: {methodName} is starting in thread: {threadIdToUse} \r\n";
        }

        private void OutputEndMessage(string methodName, int? threadId = null)
        {
            var threadIdToUse = threadId ?? Thread.CurrentThread.ManagedThreadId;

            if (InvokeRequired)
            {
                Invoke(new Action<string, int?>(OutputStartMessage), new object[] { methodName, threadIdToUse });
                return;
            }

            textBox1.Text += $"Method: {methodName} is ending in thread: {threadIdToUse} \r\n";
        }
    }
}
