using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Task.Delay(10000));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await Task.Delay(10000));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task.Run(() => Task.Delay(10000));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task.Delay(10000).Wait();
        }
    }
}
