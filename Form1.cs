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
        private bool HasDecimalPoint = false;
        private string CurrentInput = "";
        private bool IsFirstClick = true;
        private bool IsClickOp = false;
        private char OpType = ' ';
        private char prevOpType = ' ';
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

        private void ShowNumInTextbox1(double Num)
        {
            // to ignore any zeros on the left-hand side
            if (CurrentInput == "0")
                return;

            if (IsClickOp)
            {
                prevOpType = OpType;
                prevResult = (Result == 0 ? prevResult : Result);
                IsFirstClick = false;
                CurrentInput = "";
                IsClickOp = false;
                HasDecimalPoint = false;
            }
            
            CurrentInput += Num.ToString();
            textBox1.Text += Num.ToString();


            if (IsFirstClick)
            {
                Num1 = Convert.ToDouble(CurrentInput);
                prevResult = Num1;

            }
            else
            {

                Num2 = Convert.ToDouble(CurrentInput);
              OpType = prevOpType;
                CalcRes();

            }
        }

        private void ShowOpTypeInTextbox1(char Op)
        {

            if (OpType != ' ')
            {
               textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
              
            }

            IsClickOp = true;
            textBox1.Text +=  Op ;
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
                    if(Num2 == 0)// to prevent any exceptions from occurring
                    {
                        textBox2.Text = "Error";
                        break;
                    }
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

            prevOpType = OpType;
            OpType = ' ';
        }

        //private void ClacSingleThings(char SingleOp)
        //{
        //    switch(SingleOp)
        //    {
        //        case '⎷':
        //            double Value = Convert.ToDouble(CurrentInput);
        //            if(Value < 0)
        //            {
        //                textBox2.Text = "Error";
        //                return;
        //            }
        //            Result = Math.Sqrt(Value);
        //            break;

        //            case ''
        //    }
        //}
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Result.ToString();  
            textBox1.Text = textBox2.Text;
            textBox2.Text = "0";
            CurrentInput = textBox1.Text;
            prevResult = Result;
        }

        private void AC_Enter(object sender, EventArgs e)
        {
            //button3.BackColor = Color.LightGreen;
        }

        private void AC_Leave(object sender, EventArgs e)
        {
            //button3.BackColor = SystemColors.Control;
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
            CurrentInput = "";
            Result = 0;
            prevResult = 0;
            OpType = ' ';
            IsFirstClick = true;
            IsClickOp = false;
            HasDecimalPoint = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ShowOpTypeInTextbox1('%');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowNumInTextbox1(0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Result);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (!IsBlack)
            { // Black Mode

                // form
                this.BackColor = Color.Black;

                // button20
                button20.ForeColor = Color.Black;
                panel2.BackColor = Color.White;
                button20.Text = "White Mode";

                // rest of the buttons
                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                button6.ForeColor = Color.White;
                button7.ForeColor = Color.White;
                button8.ForeColor = Color.White;
                button9.ForeColor = Color.White;
                button10.ForeColor = Color.White;
                button11.ForeColor = Color.White;
                button12.ForeColor = Color.White;
                button13.ForeColor = Color.White;
                button14.ForeColor = Color.White;
                button15.ForeColor = Color.White;
                button16.ForeColor = Color.White;
                button17.ForeColor = Color.White;
                button18.ForeColor = Color.White;
                button21.ForeColor = Color.White;
                button22.ForeColor = Color.White;
                button23.ForeColor = Color.White;


                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.DarkOrange;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button7.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;
                button10.BackColor = Color.Black;
                button11.BackColor = Color.Black;
                button12.BackColor = Color.Black;
                button13.BackColor = Color.DarkOrange;
                button14.BackColor = Color.DarkOrange;
                button15.BackColor = Color.DarkOrange;
                button16.BackColor = Color.Black;
                button17.BackColor = Color.Black;
                button18.BackColor = Color.DarkOrange;
                button23.BackColor = Color.Black;
                button22.BackColor = Color.Black;
                button21.BackColor = Color.Black;

                //textbox
                textBox2.BackColor = Color.Black;
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;

                panel1.BackColor = Color.Black;

                IsBlack = true;
            }
            else
            {
                //White Mode

                this.BackColor = SystemColors.Control;

                // button20
                button20.ForeColor = Color.White;
                panel2.BackColor = Color.Black;
                button20.Text = "Dark Mode";

                // rest of the buttons
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                button18.ForeColor = Color.Black;
                button21.ForeColor = Color.Black;
                button22.ForeColor = Color.Black;
                button23.ForeColor = Color.Black;


                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = SystemColors.MenuHighlight;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;

                //textbox
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;

                panel1.BackColor = Color.White;

                IsBlack = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!HasDecimalPoint)
            {
                CurrentInput += ".";
                textBox1.Text += ".";
                HasDecimalPoint = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            char LastChar = textBox1.Text[textBox1.Text.Length - 1];
            char[] arr = { '+' , '-', 'x', '/', '%'};

            foreach(char ch in arr)
            {
                if(ch ==LastChar )
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    OpType = ' ';
                    return;
                }
            }

            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            CurrentInput = CurrentInput.Remove(CurrentInput.Length - 1, 1);
            if(CurrentInput != "")
                Num2 = Convert.ToDouble(CurrentInput);
            else
                Num2 = 0;
            OpType = prevOpType;
            CalcRes();
            OpType = prevOpType;
        }

        //private void button21_Click(object sender, EventArgs e)
        //{
        //    ShowOpTypeInTextbox1('√');
        //}
    }
}
