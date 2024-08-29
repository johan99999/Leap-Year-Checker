using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Year_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 4)
            {
                MessageBox.Show("the length of the year input cannot be more than 4!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxInput.Text = "";
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show("year input cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Boolean kabisat = false;
                if (Convert.ToInt32(textBoxInput.Text) % 400 == 0)
                {
                    kabisat = true;
                }
                else if (Convert.ToInt32(textBoxInput.Text) % 100 == 0)
                {
                    kabisat = false;
                }
                else if (Convert.ToInt32(textBoxInput.Text) % 4 == 0)
                {
                    kabisat = true;
                }
                String output = kabisat ? "LEAP YEAR" : "NOT LEAP YEAR";
                textBoxOutput.Text = output;
            }
        }
    }
}
