using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "4";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "6";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "8";

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "9";

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "1";

        }
    }
}
