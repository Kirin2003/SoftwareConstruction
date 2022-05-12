using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Graphic g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == ""
                    || this.textBox5.Text == "" || this.textBox6.Text == "" || this.comboBox1.Text == "")
            {

                MessageBox.Show("输入不能为空！");

            }
            else
            {
                g = new Graphic();
                //判断输入是否合法
                if (new Regex("^[+-]?[0-9]*$").IsMatch(textBox1.Text) 
                    && new Regex("^[+-]?[0-9]*$").IsMatch(textBox2.Text)
                    && new Regex("^[+-]?[0-9]*$").IsMatch(textBox5.Text)
                    && new Regex("^[+-]?[0-9]*$").IsMatch(textBox6.Text)
                    && new Regex("^[+-]?[0-9]*[.][0-9]*$").IsMatch(textBox3.Text)
                    && new Regex("^[+-]?[0-9]*[.][0-9]*$").IsMatch(textBox4.Text))
                {
                    
                        g.N = int.Parse(this.textBox1.Text);
                        g.Leng = int.Parse(this.textBox2.Text);
                        g.Per1 = Double.Parse(this.textBox3.Text);
                        g.Per2 = Double.Parse(this.textBox4.Text);
                        g.Th1 = int.Parse(this.textBox5.Text) * Math.PI / 180;
                        g.Th2 = int.Parse(this.textBox6.Text) * Math.PI / 180;
                        if (graphics == null) graphics = this.CreateGraphics();
                        
                        drawCayleyTree(g.N, 400, 400, g.Leng, -Math.PI / 2, g);
                    
                    
                }
                else
                {
                    MessageBox.Show("输入不合法");
                }
            }

        }



        void drawCayleyTree(int n,//递归深度
                double x0, double y0, double leng, double th, Graphic g)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, g.Per1 * leng, th + g.Th1, g);
            drawCayleyTree(n - 1, x1, y1, g.Per2 * leng, th - g.Th2, g);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            String penColor = comboBox1.Text;
            Pen pen = Pens.Black;

            if (penColor == "红色") pen = Pens.Red;
            if (penColor == "绿色") pen = Pens.Red;
            if (penColor == "蓝色") pen = Pens.Red;
            if (penColor == "黄色") pen = Pens.Red;
            if (penColor == "黑色") pen = Pens.Red;

            
           
                graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
            

        }
     

}
    public class Graphic
    {
        int n;
        double leng;
        double per1;
        double per2;
        double th1;
        double th2;



        public int N { get => n; set => n = value; }
        public double Leng { get => leng; set => leng = value; }

        public double Per1 { get => per1; set => per1 = value; }
        public double Per2 { get => per2; set => per2 = value; }
        public double Th1 { get => th1; set => th1 = value; }
        public double Th2 { get => th2; set => th2 = value; }
    }
}


