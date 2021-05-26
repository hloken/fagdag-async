using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue();
            if (asyncResolvedIssue.Result) { } // <== deadlock!
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue();
            if (await asyncResolvedIssue) { } // <== no deadlock
        }

        public async Task<bool> ResolveIssue()
        {
            await Task.Delay(10000); //.ConfigureAwait(true) - default value;

            return true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var asyncResolvedIssue = ResolveIssue2();
            if (asyncResolvedIssue.Result) { } // <== no deadlock
        }

        public async Task<bool> ResolveIssue2()
        {
            await Task.Delay(10000).ConfigureAwait(false);

            return true;
        }
    }
}
