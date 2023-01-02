using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingImageGetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled= false;
            button2.Enabled = false;
            button4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled =   true;
            button2.Enabled =   true;
            button4.Enabled =   true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button3.Enabled= false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            timer1.Enabled = true;
            toolStripStatusLabel1.Text= DateTime.Now.ToLocalTime().ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
