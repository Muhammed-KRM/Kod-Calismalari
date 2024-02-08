using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {


            float deger;

            float sayi1 = Convert.ToInt32(textBox1.Text);
            float sayi2 = Convert.ToInt32(textBox2.Text);
            
           

            if (radioButton1.Checked)
            {
                deger = sayi1 + sayi2;
                textBox3.Text = deger.ToString();
                label1.Text = "Toplam";
            }

            else if (radioButton2.Checked)
            {
                deger = sayi1 - sayi2;
                textBox3.Text = deger.ToString();
                label1.Text = "Fark";
            }
            else if (radioButton3.Checked)
            {
                deger = sayi1 * sayi2;
                textBox3.Text = deger.ToString();
                label1.Text = "Çarpım";
            }

            else if (radioButton4.Checked)
            {
                if (sayi1 == 0)
                {
                    MessageBox.Show("sıfıra bölemezsin");
                }
                deger = sayi1 / sayi2;
                textBox3.Text = deger.ToString();
                label1.Text = "Bölüm";
            }

        }
    }
}
