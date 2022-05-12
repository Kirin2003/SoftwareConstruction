using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppsCalculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double result = 0;
        string op = "";
        bool c = false;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button7_MouseClick(object sender, MouseEventArgs e) // 对应数字7按钮
        {
            if(c == true) // 说明输入的是第二个数
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 7;
        }

        private void button8_MouseClick(object sender, MouseEventArgs e) // 对应数字8按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 8;

        }

        private void button9_MouseClick(object sender, MouseEventArgs e) // 对应数字9按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 9;

        }

        private void button4_MouseClick(object sender, MouseEventArgs e) // 对应数字4按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 4;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e) // 对应数字5按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 5;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e) // 对应数字6按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 6;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) // 对应数字1按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 1;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e) // 对应数字2按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 2;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e) // 对应数字3按钮
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 3;
        }

        private void button0_MouseClick(object sender, MouseEventArgs e) // 对应数字0按钮
        { 
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += 0;

            // 除数为零不合法
            if(op == "/")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_MouseClick(object sender, MouseEventArgs e) // 对应"c"按钮
        {

            textBox1.Text = "";
        }

        private void button_equal_MouseClick(object sender, MouseEventArgs e) // 对应"="按钮
        {
            switch (op)
            {
                case "+":
                    result = num1 + double.Parse(textBox1.Text);
                    break;
                case "-":
                    result = num1 - double.Parse(textBox1.Text);
                    break;
                case "*":
                    result = num1 * double.Parse(textBox1.Text);
                    break;
                case "/":
                    result = num1 / double.Parse(textBox1.Text);
                    break;
                case "squ":
                    result = num1 * num1;
                    break;
                case "sqrt":
                    result = Math.Sqrt(num1);
                    break;
                case "log":
                    result = Math.Log(num1, double.Parse(textBox1.Text));
                    break;
                case "ln":
                    result = Math.Log(num1, Math.E);
                    break;
                case "":
                    MessageBox.Show("没有输入运算符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
            textBox1.Text = result + "";
            c = true;
        }

        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "+";
        }

        private void button_sub_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "-";
        }

        private void button_mul_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "*";
        }

        private void button_div_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "/";
        }

        private void button_squ_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "squ";
        }

        private void button_sqrt_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "sqrt";
        }

        private void button_log_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "log";
        }

        private void button_ln_MouseClick(object sender, MouseEventArgs e)
        {
            c = true;
            num1 = double.Parse(textBox1.Text);
            op = "ln";
        }
    }
}
