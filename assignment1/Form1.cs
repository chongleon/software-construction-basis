//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Calculatorplus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        String type;
        double x;
        double y;
        bool c = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            //form
            this.CenterToScreen();
            this.Text = "张乐遥的计算器";
            //以下三行代码自己写的时候不会也没想到，是上网搜到的资料。
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            textBox1.ReadOnly = true;//文本框只读
            textBox2.TabIndex = 0;//光标焦点在textbox2中

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text1
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //text2
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //4
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //5
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //6
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //7
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //8
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //9
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //0
            if (c == true)
            {
                c = false;
                textBox1.Text = "";
            }
            textBox1.Text += "0";
            textBox2.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //.
            textBox1.Text += ".";
            textBox2.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //C
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //+
            c = true;
            type = "+";
            x = double.Parse(textBox1.Text);
            textBox2.Text += "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //-
            c = true;
            type = "-";
            x = double.Parse(textBox1.Text);
            textBox2.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //*
            c = true;
            type = "*";
            x = double.Parse(textBox1.Text);
            textBox2.Text += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ///
            c = true;
            type = "/";
            x = double.Parse(textBox1.Text);
            textBox2.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //=
            y = double.Parse(textBox1.Text);
            textBox2.Text += "=";
            while (type == "+")
            {
                textBox1.Text = (x + y).ToString();
                textBox2.Text += textBox1.Text;
                return;
            }
            while (type == "-")
            {
                textBox1.Text = (x - y).ToString();
                textBox2.Text += textBox1.Text;
                return;
            }
            while (type == "*")
            {
                textBox1.Text = (x * y).ToString();
                textBox2.Text += textBox1.Text;
                return;
            }
            while (type == "/")
            {
                textBox1.Text = (x / y).ToString();
                textBox2.Text += textBox1.Text;
                return;
            }
        }
    }
}
