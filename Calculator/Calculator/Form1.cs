using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Classes;
using Calculator.Interfaces;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string generaltext;

        string number;

        bool control = false;

        calculate cal1 = new calculate();

        ILog log1 = new log();

        
        

        
        public Form1()
        {
            
            InitializeComponent();
        }

        #region Sayilar

        private void button0_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "0";
                number += "0";
                textBox1.Text = generaltext;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "1";
                number += "1";
                textBox1.Text = generaltext;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "2";
                number += "2";
                textBox1.Text = generaltext;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "3";
                number += "3";
                textBox1.Text = generaltext;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "4";
                number += "4";
                textBox1.Text = generaltext;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "5";
                number += "5";
                textBox1.Text = generaltext;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "6";
                number += "6";
                textBox1.Text = generaltext;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "7";
                number += "7";
                textBox1.Text = generaltext;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "8";
                number += "8";
                textBox1.Text = generaltext;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!control)
            {
                generaltext += "9";
                number += "9";
                textBox1.Text = generaltext;
            }
        }
        


        #endregion


        #region islemler
        private void eksi_button_Click(object sender, EventArgs e)
        {
            if (control)
            {
                generaltext += "ANS";
                textBox1.Text = generaltext;
                control = false;
            }
            else
            {
                cal1.Numbers.Add(Convert.ToDouble(number));
            }

            generaltext += "-";
            textBox1.Text = generaltext;
            number = "";
            cal1.Operations.Add("-");
            
        }

        private void bolme_button_Click(object sender, EventArgs e)
        {
            if (control)
            {
                generaltext += "ANS";
                textBox1.Text = generaltext;
                control = false;
            }
            else
            {
                cal1.Numbers.Add(Convert.ToDouble(number));
            }

            generaltext += "/";
            textBox1.Text = generaltext;

            
            number = "";
            cal1.Operations.Add("/");
        }

        private void carpi_button_Click(object sender, EventArgs e)
        {
            if (control)
            {
                generaltext += "ANS";
                textBox1.Text = generaltext;
                control = false;
            }
            else
            {
                cal1.Numbers.Add(Convert.ToDouble(number));
            }

            generaltext += "*";
            textBox1.Text = generaltext;
            number = "";
            cal1.Operations.Add("*");
        }

        private void arti_button_Click(object sender, EventArgs e)
        {
            if (control)
            {
                generaltext += "ANS";
                textBox1.Text = generaltext;
                control = false;
            }
            else
            {
                cal1.Numbers.Add(Convert.ToDouble(number));
            }

            generaltext += "+";
            textBox1.Text = generaltext;
            number = "";
            cal1.Operations.Add("+");
        }


        #endregion


        private void nokta_button_Click(object sender, EventArgs e)
        {
            generaltext += ".";
            number += ".";
            textBox1.Text = generaltext;
        }

        private void esit_button_Click(object sender, EventArgs e)
        {
            
            
            cal1.Numbers.Add(Convert.ToDouble(number));
            number = "";
            control = true;
            if (generaltext.Contains("ANS"))
                generaltext = generaltext.Replace("ANS", Convert.ToString(cal1.Numbers[0]));
            cal1.Calculate();
            log1.logging(generaltext, cal1.Sum);
            generaltext = Convert.ToString(cal1.Sum);
            textBox1.Text = generaltext;
            generaltext = "";
            cal1.Numbers.Clear();
            cal1.Operations.Clear();
            cal1.Numbers.Add(cal1.Sum);
            if(!cal1.Control0)
            ac_button_Click(sender,e);

        }

        

        private void ac_button_Click(object sender, EventArgs e)
        {
            generaltext = "";
            textBox1.Text = generaltext;
            number = "";
            cal1.Numbers.Clear();
            cal1.Operations.Clear();
            control = false;
            cal1.Sum = 0;
        }
    }
}
