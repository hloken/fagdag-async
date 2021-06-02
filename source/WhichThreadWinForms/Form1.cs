using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhichThreadWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonAwaitConfigureAwaitTrue_Click(object sender, EventArgs e)
        {
            OutputMessage("Starting await Delay with ConfigureAwait(true)");

            await Delay(true).ConfigureAwait(true);

            OutputMessage("Ending await Delay with ConfigureAwait(true)");
        }

        private async void buttonbuttonAwaitConfigureAwaitFalse_Click(object sender, EventArgs e)
        {
            OutputMessage("Starting await Delay with ConfigureAwait(false)");

            await Delay(false).ConfigureAwait(false);

            OutputMessage("Ending await Delay with ConfigureAwait(false)");
        }

        private async Task Delay(bool configureAwait)
        {
            OutputMessage("Starting Delay method");

            await Task.Delay(10000).ConfigureAwait(configureAwait);

            OutputMessage("Ending Delay method");
        }


        private void OutputMessage(string message)
        {
            var threadIdToUse = Thread.CurrentThread.ManagedThreadId;

            Debug.WriteLine($"Thread: {threadIdToUse} Message: {message}");
        }

        
    }
}
