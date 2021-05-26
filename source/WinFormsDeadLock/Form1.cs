using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDeadLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        // Deadlock
        //
        private void button1_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue();
            if (asyncResolvedIssue.Result) { } // <== deadlock!
        }

        public async Task<bool> ResolveIssue()
        {
            await Task.Delay(10000); //.ConfigureAwait(true) - default value, means continuation must be on same thread, i.e will wait for GUI thread;

            return true; // Since await statement above waits for GUI-thread which is blocked by .Result above (which waits for end of this method) this statement will never be reached => Deadlock!
        }

        //
        // Deadlock Fix #1
        //
        private async void button2_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue2();
            if (await asyncResolvedIssue) { } // <== no deadlock
        }

        public async Task<bool> ResolveIssue2()
        {
            await Task.Delay(10000); //.ConfigureAwait(true) - default value;

            return true;
        }

        //
        // Deadlock Fix #2
        //
        private void button3_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue3();
            if (asyncResolvedIssue.Result) { } // <== no deadlock
        }

        public async Task<bool> ResolveIssue3()
        {
            await Task.Delay(10000).ConfigureAwait(false); // ConfigureAwait(false) means continuation after await may proceed on different thread so therefore will not deadlock

            return true;
        }
    }
}
