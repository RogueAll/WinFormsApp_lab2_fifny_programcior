﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables.Cost_2 = label1.Text;
            button3_Click(sender, e);
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
            //int BDSM = int.Parse(label3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.SelectedItem.ToString();
            temp = temp.Replace("procesor ", "");
            label1.Text = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp2 = comboBox2.SelectedItem.ToString();

            string temp3 = temp2.Substring(temp2.Length - 2);
            label2.Text = temp3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int uno = int.Parse(label1.Text);
            int dos = int.Parse(label2.Text);
            int tres = uno + dos;
            GlobalVariables.Cost_1 = tres.ToString();
            label3.Text = GlobalVariables.Cost_1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
