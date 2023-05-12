using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 7;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Clear();
                txtShowDisplay.Focus();
                count = 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtShowDisplay.Text != "")
                {
                    num1 = float.Parse(this.txtShowDisplay.Text);
                    this.txtShowDisplay.Clear();
                    txtShowDisplay.Focus();
                    count = 1;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }

        private void btnmultipication_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Clear();
                this.txtShowDisplay.Focus();
                count = 3;
            }catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Clear();
                this.txtShowDisplay.Focus();
                count = 4;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void calculate(int count)
        {
            if (count == 1)
            {
                ans = num1 - float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Text = ans.ToString();
            }
            else if (count == 2)
            {
                ans = num1 + float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Text = ans.ToString();
            }
            else if (count == 3)
            {
                ans = num1 * float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Text = ans.ToString();
            }
            else if (count == 4)
            {
                ans = num1 / float.Parse(this.txtShowDisplay.Text);
                this.txtShowDisplay.Text = ans.ToString();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            calculate(count);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Clear();
            count = 0;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int c = this.txtShowDisplay.TextLength;
            int flag = 0;
            string text = this.txtShowDisplay.Text;
            int a = 0;

            while (a < c)
            {
                if (text[a].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
                a++;
            }

            if (flag == 0)
            {
                this.txtShowDisplay.Text = this.txtShowDisplay.Text + ".";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtShowDisplay.Text = this.txtShowDisplay.Text + 7;
        }


    }
}
