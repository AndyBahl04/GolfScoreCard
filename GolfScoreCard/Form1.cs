using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfScoreCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hole 2";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Hole 1";
        }
    }
}
