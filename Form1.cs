using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = " "; //label3 ü gizledik

        }

        private void notHesapla(object sender, EventArgs e)
        {
            double vize, final, ortalama;

            try
            {

                vize = Convert.ToDouble(textBox1.Text);
                final = Convert.ToDouble(textBox2.Text);
                ortalama = vize * 0.4 + final * 0.6;
                label3.Text = ortalama.ToString();
            }


            catch (Exception ex)
            {
                if (textBox1.Text != "" & textBox2.Text != "")
                {
                    MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
                }
                
            }
        }
    }
}


