﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Üzerimdedir");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Üzerimde değildir");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
