﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("boş girme");
            }
            else {
                comboBox1.Items.Add(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
            MessageBox.Show("Selamın aleyküm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 && label1.Text == "0")
            {
                label1.Text =  "9";
            }
            else {
                label1.Text = label1.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                label1.Text = label1.Text + "0";
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
