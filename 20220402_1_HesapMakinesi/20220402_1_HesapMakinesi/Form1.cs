using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220402_1_HesapMakinesi
{
    public partial class Form1 : Form
    {
        double sayi1 = 0, sayi2 = 0, sonuc = 0;
        string islem = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sonuc > 0)
            {
                sonuc = 0;
                sayi1 = 0;
                sayi2 = 0;
                islem = string.Empty;
                lblSonuc.Text = "0";
            }


            Button btn = (Button)sender;
            var basamak = lblSonuc.Text.Split(',');

            if (basamak.Length == 1)
            {
                if (basamak[0].Length < 16)
                {
                    Yazdir(sender);
                }
            }
            else
            {
                if (basamak[1].Length < 6)
                {
                    Yazdir(sender);
                }
            }

            if (btn.Text == ",")
            {
                if (!lblSonuc.Text.Contains(","))
                {
                    if (lblSonuc.Text.Length == 0)
                    {
                        lblSonuc.Text = "0";
                    }
                    lblSonuc.Text += btn.Text;
                }
            }

        }

        private void Yazdir(object sender)
        {
            Button btn = (Button)sender;
            if (btn.Text != ",")
            {
                if (btn.Text == "0")
                {
                    if (!(lblSonuc.Text.Length == 1 && lblSonuc.Text == "0"))
                    {
                        lblSonuc.Text += btn.Text;
                    }
                }
                else
                {
                    if (lblSonuc.Text.Length == 1 && lblSonuc.Text == "0")
                    {
                        lblSonuc.Text = string.Empty;
                    }
                    lblSonuc.Text += btn.Text;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islem = ((Button)sender).Text;
            sayi1 = double.Parse(lblSonuc.Text);
            lblSonuc.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(lblSonuc.Text);
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
            }

            lblSonuc.Text = sonuc.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text.Length > 1)
            {
                lblSonuc.Text = lblSonuc.Text.Substring(0, lblSonuc.Text.Length - 1);
            }
            else
            {
                lblSonuc.Text = "0";
            }
        }
    }
}
