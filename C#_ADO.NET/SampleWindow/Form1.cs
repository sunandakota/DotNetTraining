using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good morning");
            if ((txtfirst.Text == "") || (txtsecond.Text == ""))
            {
                MessageBox.Show("fields cannot be blank,enter data", "Input data");
            }
            else
            {
                double n1, n2;
                n1 = double.Parse(txtfirst.Text);
                n2 = double.Parse(txtsecond.Text);
                double result = 0;
                if (rdbadd.Checked)
                {
                    result = (n1 + n2);
                    lblsolution.Text = "sum:" + result;
                }
                else if (rdbsubtract.Checked)
                {
                    result = (n1 - n2);
                    lblsolution.Text = "subtract:" + result;
                }
                else if (rdbmultiply.Checked)
                {
                    result = (n1 * n2);
                    lblsolution.Text = "multiply:" + result;
                }
                else if (rdbdivide.Checked)
                {
                    result = (n1 / n2);
                    lblsolution.Text = "divide:" + result;
                }
                else
                    lblsolution.Text = "enter your choice first";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
