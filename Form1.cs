using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        double fstNum,SecNum;
        String Oper;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == " ")
            {
                txtDisplay.Text = " ";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "";
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            Oper = "+";
            txtDisplay.Text = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            Oper = "-";
            txtDisplay.Text = " ";
        }

        private void btnKhon_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            Oper = "*";
            txtDisplay.Text = " ";
        }

        private void btnHan_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            Oper = "/";
            txtDisplay.Text = " ";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double q))
            {
                txtDisplay.Text = (-1 * q).ToString();
            }
            else
            {
                txtDisplay.Text = "Invalid input";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = " ";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "  ";
            string f, s ;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(SecNum);

            f = " ";
            s = " ";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == " ")
            {
                txtDisplay.Text = "  ";
            }
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            SecNum = double.Parse(txtDisplay.Text);

            SecNum = double.Parse(txtDisplay.Text);

            switch (Oper)
            {
                case "+":
                    txtDisplay.Text = (fstNum + SecNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (fstNum - SecNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (fstNum * SecNum).ToString();
                    break;
                case "/":
                    if (SecNum != 0)
                        txtDisplay.Text = (fstNum / SecNum).ToString();
                    else
                        txtDisplay.Text = "Cannot divide by zero";
                    break;
                default:
                    txtDisplay.Text = "Unknown operation";
                    break;

            }
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == ".")
            {
                txtDisplay.Text = ".";

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
