using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Spotify_login_interface
{

    public partial class Form1 : Form
    {
        private double Num1 = 0;
        private double Num2 = 0;
        private double Num3 = 0;
        private bool IsFirstClick = true;
        private bool IsClickOp = false;
        private char OpType;
        private double Result;
        private double prevResult = 0;
        private bool IsBlack = false;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void ShowNumInTextbox1(int Num)
        {
            //textBox2.Text = "";
            //textBox1.Text += Convert.ToString(Num);
            if (IsClickOp)
            {
                prevResult = (Result == 0 ? prevResult : Result);
                IsFirstClick = false;
                Num3 = 0;
                IsClickOp = false;
            }

            if (IsFirstClick)
            {
                textBox1.Text += Convert.ToString(Num);

                Num3 = Num3 * 10 + Num;
                Num1 = Num3;
                prevResult = Num1;

                //textBox2.Text = Convert.ToString(Num);

            }
            else
            {
                textBox1.Text += Convert.ToString(Num);

                Num3 = Num3 * 10 + Num;
                Num2 = Num3;
                CalcRes();

            }
        }

        private void ShowOpTypeInTextbox1(char Op)
        {
            IsClickOp = true;
            textBox1.Text += " " + Op + " ";
            OpType = Op;
        }
        private void CalcRes()
        {
            switch (OpType)
            {

                case '+':
                    //prevResult = Num1;
                    Result = prevResult + Num2;
                    // Num1 = Result;
                    textBox2.Text = Convert.ToString(Result);
                    break;

                case 'x':
                    Result = prevResult * Num2;
                    //Num1 = Result;
                    textBox2.Text = Convert.ToString(Result);
                    break;

                case '-':
                    Result = prevResult - Num2;
                    //Num1 = Result;
                    textBox2.Text = Convert.ToString(Result);
                    break;

                case '/':
                    Result = prevResult / Num2;
                    //Num1 = Result;
                    textBox2.Text = Convert.ToString(Result);
                    break;

                case '%':
                    Result = prevResult % Num2;
                    //Num1 = Result;
                    textBox2.Text = Convert.ToString(Result);
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = "0";
        }

        private void AC_Enter(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGreen;
        }

        private void AC_Leave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Control;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(1);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(2);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('+');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('-');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('x');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('/');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
            Num1 = 0;
            Num2 = 0;
            Num3 = 0;
            Result = 0;
            prevResult = 0;
            OpType = ' ';
            IsFirstClick = true;
            IsClickOp = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('%');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(0);
        }

        //private void button20_Click(object sender, EventArgs e)
        //{
        //    if(!IsBlack)
        //   { // Black Mode

        //    // form
        //    this.BackColor = Color.Black;

        //    // button20
        //    button20.ForeColor = Color.Black;
        //    panel2.BackColor = Color.White;
        //    button20.Text = "White Mode";

        //    // rest of the buttons
        //    button1.ForeColor = Color.White;
        //    button2.ForeColor = Color.White;
        //    button3.ForeColor = Color.White;
        //    button4.ForeColor = Color.White;
        //    button5.ForeColor = Color.White;
        //    button6.ForeColor = Color.White;
        //    button7.ForeColor = Color.White;
        //    button8.ForeColor = Color.White;
        //    button9.ForeColor = Color.White;
        //    button10.ForeColor = Color.White;
        //    button11.ForeColor = Color.White;
        //    button12.ForeColor = Color.White;
        //    button13.ForeColor = Color.White;
        //    button14.ForeColor = Color.White;
        //    button15.ForeColor = Color.White;
        //    button16.ForeColor = Color.White;
        //    button17.ForeColor = Color.White;
        //    button18.ForeColor = Color.White;

        //    //textbox
        //    textBox2.BackColor = Color.Black;
        //    textBox1.BackColor = Color.Black;
        //    textBox1.ForeColor = Color.White;
        //    textBox2.ForeColor = Color.White;

        //        panel1.BackColor = Color.Black;
        //    }
        //    else
        //    {
        //        this.BackColor = SystemColors.Control;

        //        // button20
        //        button20.ForeColor = Color.White;
        //        panel2.BackColor = Color.Black;
        //        button20.Text = "Dark Mode";

        //        // rest of the buttons
        //        button1.ForeColor = Color.Black;
        //        button2.ForeColor = Color.Black;
        //        button3.ForeColor = Color.Black;
        //        button4.ForeColor = Color.Black;
        //        button5.ForeColor = Color.Black;
        //        button6.ForeColor = Color.Black;
        //        button7.ForeColor = Color.Black;
        //        button8.ForeColor = Color.Black;
        //        button9.ForeColor = Color.Black;
        //        button10.ForeColor = Color.Black;
        //        button11.ForeColor = Color.Black;
        //        button12.ForeColor = Color.Black;
        //        button13.ForeColor = Color.Black;
        //        button14.ForeColor = Color.Black;
        //        button15.ForeColor = Color.Black;
        //        button16.ForeColor = Color.Black;
        //        button17.ForeColor = Color.Black;
        //        button18.ForeColor = Color.Black;

        //        //textbox
        //        textBox2.BackColor = Color.White;
        //        textBox1.BackColor = Color.White;
        //        textBox1.ForeColor = Color.Black;
        //        textBox2.ForeColor = Color.Black;

        //        panel1.BackColor = Color.White;
        //    }

        //}
    }
}
