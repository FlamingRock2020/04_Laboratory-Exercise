using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            Console.WriteLine("-Before starting thread-");
            Thread ThreadA = new Thread(threadStart);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(threadStart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblThread.Text = "-End of Thread-";






        }
    }
}
