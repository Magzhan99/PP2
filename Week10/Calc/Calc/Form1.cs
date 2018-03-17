using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator : Form
    {
        int i = 0, o = 0;
        double memory = 0, first_number = 0, second_number = 0, res = 0, res2 = 0, res3 = 0;
        string operation, operation2;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Input.Text = 0 + "";
        }

        private void numbers_click(object sender, EventArgs e)
        {
            i++;
            Button btn = sender as Button;
            if (i == 1 )
            {
                Input.Text = btn.Text;
            }
            else
            {
                Input.Text = Input.Text + btn.Text;
            }
            label.Text += btn.Text;
        }
        
        private void Operation_with_Equal(object sender, EventArgs e) // NUMBER then NUMBER then EQUAL
        {
            Button btn = sender as Button;
            first_number = double.Parse(Input.Text);
            label.Text = first_number.ToString();
            Input.Text = "0";
            if (btn.Text == "x^y")
            {
                label.Text = label.Text + " " + "^" + " ";
            }
            else if(btn.Text == "x^1/y")
            {
                label.Text = label.Text + " " + "y_root" + " ";
            }
            else
            {
                label.Text = label.Text + " " + btn.Text + " ";
            }
            operation = btn.Text;
            i = 0;
        }

        private void Witout_secondNumber(object sender, EventArgs e) //ne trebuet vtorogo chisla
        {
            Button btn = sender as Button;
            first_number = double.Parse(Input.Text);
            operation2 = btn.Text;
            if (btn.Text == "x^3")
            {
                label.Text = "cube(" + first_number + ")";
            }
            else if (btn.Text == "x^2")
            {
                label.Text = "sqr(" + first_number + ")";
            }
            else if(btn.Text == "n!")
            {
                label.Text = "fact(" + first_number + ")";
            }
            else if (btn.Text == "x^1/3")
            {
                label.Text = "cuberoot(" + first_number + ")";
            }
            else if (btn.Text == "10^x")
            {
                label.Text = "pow10(" + first_number + ")";
            }
            else if(btn.Text == "1/x")
            {
                label.Text = "reciproc(" + first_number + ")";
            }
            else if (btn.Text == "√")
            {
                label.Text = "sqrt(" + first_number + ")";
            }

            switch (operation2)
            {
                case "x^3":
                    res2 = Math.Pow(first_number , 3);
                    break;
                case "x^2":
                    res2 = Math.Pow(first_number, 2);
                    break;
                case "x^1/3":
                    res2 = Math.Pow(first_number, 0.333333333333333333333333);
                    break;
                case "n!":
                    res2 = 1;
                    for (int i = 1; i <= first_number; i++)
                        res2 *= i;
                    break;
                case "10^x":
                    res2 = Math.Pow(10, first_number);
                    break;
                case "1/x":
                    res2 = 1 / first_number;
                    break;
                case "√":
                    res2 = Math.Sqrt(first_number);
                    break;
            }
            Input.Text = res2.ToString();
            i = 0;
        }

        private void Result_click(object sender, EventArgs e)
        {
            if (label.Text != "")
            {
                string[] u = label.Text.Split(' ');
                first_number = double.Parse(u[0]);
                second_number = double.Parse(u[u.Length - 1]);
            }
            else
            {
                first_number = double.Parse(Input.Text);
            }
            label.Text = "";
            switch (operation)
            {
                case "+":
                    res = first_number + second_number;
                    break;
                case "-":
                    res = first_number - second_number;
                    break;
                case "*":
                    res = first_number * second_number;
                    break;
                case "/":
                    res = first_number / second_number;
                    break;
                case "%":
                    res = first_number * second_number / 100;
                    break;
                case "x^y":
                    res = Math.Pow(first_number, second_number);
                    break;
                case "x^1/y":
                    res = Math.Pow(first_number, 1 / second_number);
                    break;
            }
            Input.Text = res.ToString();
            i = 0;
            o++;
        }

        private void function_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            first_number = double.Parse(Input.Text);
            label.Text = btn.Text + "(" + first_number + ")";
            if (!Degree.Checked)
            {
                switch (btn.Text)
                {
                    case "log":
                        res3 = Math.Log10(first_number);
                        break;
                    case "ln":
                        res3 = Math.Log(first_number);
                        break;
                    case "sin":
                        res3 = Math.Sin(first_number * Math.PI / 180);
                        break;
                    case "cos":
                        res3 = Math.Cos(first_number * Math.PI / 180);
                        break;
                    case "tan":
                        res3 = Math.Tan(first_number * Math.PI / 180);
                        break;
                    case "ctg":
                        res3 = Math.Cos(first_number * Math.PI / 180) / Math.Sin(first_number * Math.PI / 180);
                        break;
                    case "asin":
                        res3 = Math.Asin(first_number);
                        break;
                    case "acos":
                        res3 = Math.Acos(first_number);
                        break;
                    case "atan":
                        res3 = Math.Atan(first_number);
                        break;
                    case "actg":
                        res3 = Math.Atan(1 / first_number);
                        break;
                }
                Input.Text = res3.ToString();
                i = 0;
            }
            else
            {
                switch (btn.Text)
                {
                    case "log":
                        res3 = Math.Log10(first_number);
                        break;
                    case "ln":
                        res3 = Math.Log(first_number);
                        break;
                    case "sin":
                        res3 = Math.Sin(first_number);
                        break;
                    case "cos":
                        res3 = Math.Cos(first_number);
                        break;
                    case "tan":
                        res3 = Math.Tan(first_number);
                        break;
                    case "ctg":
                        res3 = Math.Cos(first_number) / Math.Sin(first_number);
                        break;
                    case "asin":
                        res3 = Math.Asin(first_number);
                        break;
                    case "acos":
                        res3 = Math.Acos(first_number);
                        break;
                    case "atan":
                        res3 = Math.Atan(first_number);
                        break;
                    case "actg":
                        res3 = Math.Atan(1 / first_number);
                        break;
                }
                Input.Text = res3.ToString();
                i = 0;
            } 
        }


        private void MS_Click(object sender, EventArgs e)
        {
            M_label.Text = "M";
            label.Text = "";
            memory = double.Parse(Input.Text);
            i = 0;
        }

        private void memory_read(object sender, EventArgs e)
        {
            Input.Text = memory.ToString();
            label.Text = "";
        }

        private void memory_plus(object sender, EventArgs e)
        {
            memory = memory + double.Parse(Input.Text);
            label.Text = "";
        }

        private void memory_minus(object sender, EventArgs e)
        {
            memory = memory - double.Parse(Input.Text);
            label.Text = "";
        }

        private void memory_clear(object sender, EventArgs e)
        {
            memory = 0;
            M_label.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            string[] y = label.Text.Split(' ');
            if(y.Length == 3)
            {
                label.Text = y[0] + " " + y[1] + " ";
                Input.Text = "0";
                i = 0;
            }
            else
            {
                label.Text = "";
                Input.Text = "0";
                i = 0;
            }
        }

        int f = 0;

        private void Del_Click(object sender, EventArgs e)
        {
            f++;
            string s = Input.Text;
            string t = "";
            for (int i = 0; i < s.Length - f; i++)
            {
                t += s[i];
            }
            Input.Text = t;
            label.Text = t; 
            f = 0;
            if (Input.Text == "")
            {
                Input.Text = "0";
            }
            i = 0;
        }

        private void Clear_click(object sender, EventArgs e)
        {
            Input.Text = "0";
            label.Text = "";
            first_number = 0;
            second_number = 0;
            res = 0;
            res2 = 0;
            res3 = 0;
            i = 0;
        }

        private void Negativ_Click(object sender, EventArgs e)
        {
            double d = -1 * int.Parse(Input.Text);
            Input.Text = d.ToString();
        }


        int k = 0;
        private void Arc_Checked(object sender, EventArgs e)
        {
            k = k % 2;
            if (k == 1)
            {
                sinus.Text = "sin";
                cosinus.Text = "cos";
                tangent.Text = "tan";
                cotangent.Text = "ctg";
            }
            else
            {
                sinus.Text = "asin";
                cosinus.Text = "acos";
                tangent.Text = "atan";
                cotangent.Text = "actg";
            }
            k++;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label.Text += "Exp";
            double d = Math.Exp(1);
            Input.Text = d.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label.Text += "PI";
            double l = Math.PI;
            Input.Text = l.ToString();
        }
    }
}
