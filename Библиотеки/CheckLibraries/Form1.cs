using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIN_LIB;
using REG_MARK_LIB;

namespace CheckLibraries
{
    public partial class Form1 : Form
    {
        public Boolean checkTextBox(string text)
        {
            return (text.Length != 0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox(textBox1.Text))//CheckVIN (string)
            {
                label6.Text = "0";
            }
            if (checkTextBox(textBox2.Text))//GetVINCountry (string)
            {
                label7.Text = "0";
            }
            if (checkTextBox(textBox3.Text))//GetTransportYear (int)
            {
                label8.Text = "0";
            }
            if (checkTextBox(textBox4.Text))//CheckMark (string)
            {
                label9.Text = REG_MARK.CheckMark(textBox4.Text).ToString();
            }
            if (checkTextBox(textBox5.Text))//GetNextMarkAfter (string)
            {
                if (REG_MARK.CheckMark(textBox5.Text))
                {
                    label10.Text = REG_MARK.GetNextMarkAfter(textBox5.Text);
                }
                
            }
            if (checkTextBox(textBox6.Text))//GetNextMarkAfterInRange (string)
            {
                if (REG_MARK.CheckMark(textBox6.Text))
                {
                    label11.Text = REG_MARK.GetNextMarkAfterInRange(textBox6.Text,textBox8.Text,textBox9.Text);
                }
            }
            if (checkTextBox(textBox7.Text) && checkTextBox(textBox10.Text))//GetNextMarkAfterInRange (string)
            {
                if (REG_MARK.CheckMark(textBox7.Text) && REG_MARK.CheckMark(textBox10.Text))
                {
                    label15.Text = REG_MARK.GetCombinationsCountInRange(textBox7.Text,textBox10.Text).ToString();
                }
            }
        }
    }
}
