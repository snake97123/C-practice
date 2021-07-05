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
            //checkBox1.CheckState = CheckState.Indeterminate;
           
        }

        //private void CheckState1Changed(object sender, EventArgs e)
        //{
        //    CheckState state = checkBox1.CheckState;
        //    switch (state)
        //    {
        //        case CheckState.Unchecked:
        //            label1.Text = "OFF";
        //            break;
        //        case CheckState.Checked:
        //            label1.Text = "ON";
        //            break;
        //        case CheckState.Indeterminate:
        //            label1.Text = "どちらでもないです";
        //            break;
        //        default:
        //            label1.Text = "cancel";
        //            break;
        //    }
        //}

        private void RadioChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            string s = radio.Name;
            string n = radio.Text;
            label1.Text = "[" + s + n + "]を選んだ。";
        }
    }
}
