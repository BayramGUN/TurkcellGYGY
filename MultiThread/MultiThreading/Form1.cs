using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        Thread thread = null!;
        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();
            thread.Join();
            MessageBox.Show("Bitti");
        }
        private void counter()
        {
            for (int i = 0; i <= 10000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 100;
                label2.Text = (i / 100).ToString() + "%";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show!");
        }
    }
}
