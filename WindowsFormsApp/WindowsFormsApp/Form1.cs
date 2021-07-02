using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            label1.Text = s;
        }

        private void CheckedBox1Checked(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            if (check)
            {
                label1.Text = "ON";
                label1.ForeColor = Color.Red;
                label1.Refresh();
                
            }
            else
            {
                label1.Text = "OFF";
            }
        }
    }
}
