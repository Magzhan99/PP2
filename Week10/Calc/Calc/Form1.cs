using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary; //poslednee izmenenie  6 + 5 / 4 ....
using System.Text;                                    
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator : Form
    {
        int i = 0, o = 0;
        double memory = 0, first_number = 0, second_number = 0, res = 0, res2 = 0, res3 = 0;
        string[] str1, str2;
        string operation, operation2, result = "";
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
            Button btn = sender as Button;
            i++;
            if(i == 1)
            {
                //!label.Text.Contains("ctg") && !label.Text.Contains("tan") && !label.Text.Contains("cos") && !label.Text.Contains("sin") && !label.Text.Contains("sqr") && !label.Text.Contains("fact") && !label.Text.Contains("cube") && !label.Text.Contains("log") && !label.Text.Contains("reciproc") && !label.Text.Contains("cuberoot") && !label.Text.Contains("ln")
                if (!label.Text.Contains('(') && !label.Text.Contains(')') && label.Text != Math.Exp(1).ToString() && label.Text != Math.PI.ToString())
                {
                    Input.Text = btn.Text;
                    label.Text += btn.Text;
                }
                else
                {
                    Input.Text = btn.Text;
                    label.Text = btn.Text;
                }
            }
            else
            {
                if (Input.Text == "0" && Input.Text.Contains('.') == false)
                {
                    Input.Text = btn.Text;
                    label.Text += btn.Text;
                }
                else
                {
                    Input.Text += btn.Text;
                    label.Text += btn.Text;
                }
            }
        }
        private void Zero_click(object sender, EventArgs e)
        {
            if (Input.Text != "0")
            {
                if (i != 0)
                {
                    Input.Text += "0";
                    label.Text += "0";
                }
            }
            if (Input.Text != "0" && label.Text == "")
            {
                Input.Text = "0";
            }
            if (Input.Text != "0" && label.Text != "")
            {
                if (i == 0)
                {
                    label.Text = "";
                    Input.Text = "0";
                }
            }
        }

        private void Operation_with_Equal(object sender, EventArgs e) //NUMBER then NUMBER then EQUAL
        {
            Button btn = sender as Button;
            str1 = label.Text.Split(' ');
            if (str1.Length == 1 || label.Text == "")
            {
                first_number = double.Parse(Input.Text);
                label.Text = first_number.ToString();
                Input.Text = "0";
                //Input.Text = first_number.ToString();
                if (btn.Text == "x^y")
                {
                    label.Text = label.Text + " " + "^" + " ";
                }
                else if (btn.Text == "x^1/y")
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
            else if (str1[2] == "")
            {
                string[] str3 = label.Text.Split(' ');
                label.Text = str3[0] + " " + btn.Text + " ";
                operation = btn.Text;
                i = 0;
            }
            else if (str1.Length == 3 && str1[2] != "")
            {
                str2 = label.Text.Split(' ');
                first_number = double.Parse(str2[0]);
                if (str2[1] == "+")
                {
                    Input.Text = "0";
                    label.Text = (first_number + double.Parse(str2[2])).ToString() + " " + btn.Text + " ";
                    operation = btn.Text;
                    /*
                    Input.Text = (first_number + double.Parse(str2[2])).ToString();
                    label.Text = Input.Text + " " + btn.Text + " ";
                    operation = btn.Text;
                    */
                    i = 0;
                }
                if (str2[1] == "-")
                {
                    Input.Text = "0";
                    label.Text = (first_number - double.Parse(str2[2])).ToString() + " " + btn.Text + " ";
                    operation = btn.Text;
                    i = 0;
                }
                if (str2[1] == "/")
                {
                    Input.Text = "0";
                    label.Text = (first_number / double.Parse(str2[2])).ToString() + " " + btn.Text + " ";
                    operation = btn.Text;
                    i = 0;
                }
                if (str2[1] == "*")
                {
                    Input.Text = "0";
                    label.Text = (first_number * double.Parse(str2[2])).ToString() + " " + btn.Text + " ";
                    operation = btn.Text;
                    i = 0;
                }
            }
        }
        bool ok = true;
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
            else if (btn.Text == "n!")
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
            else if (btn.Text == "1/x")
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
                    res2 = Math.Pow(first_number, 3);
                    break;
                case "x^2":
                    res2 = Math.Pow(first_number, 2);
                    break;
                case "x^1/3":
                    if (first_number >= 0)
                    {
                        res2 = Math.Pow(first_number, 0.333333333333333333333333);
                    }
                    else
                    {
                        res2 = Math.Pow(first_number * -1, 0.333333333333333333333333) * -1;
                    }
                    break;
                case "n!":
                    res2 = 1;
                    if (first_number > 0)
                    {
                        for (int i = 1; i <= first_number; i++)
                        {
                            res2 *= i;
                        }
                    }
                    if (first_number < 0)
                    {
                        ok = false;
                    }
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
            if (ok == false)
            {
                Input.Text = "error";

            }
            i = 0;
        }

        private void Result_click(object sender, EventArgs e)
        {
            string[] u = label.Text.Split(' ');
            if (Input.Text != label.Text)
            {
                if (label.Text != "" && Input.Text != "error" && u[2] != "")
                {
                    first_number = double.Parse(u[0]);
                    second_number = double.Parse(u[2]);
                }
                if (label.Text == "" && Input.Text != "error")
                {
                    first_number = double.Parse(Input.Text);
                }
                else if (u[2] == "")
                {
                    second_number = first_number;
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
            }
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
                        if (first_number == 180)
                        {
                            res3 = 0;
                        }
                        else
                        {
                            res3 = Math.Sin(first_number * Math.PI / 180);
                        }
                        break;
                    case "cos":
                        if (first_number == 90 || first_number == 270)
                        {
                            res3 = 0;
                        }
                        else
                        {
                            res3 = Math.Cos(first_number * Math.PI / 180);
                        }
                        break;
                    case "tan":
                        if (first_number == 90 || first_number == 270)
                        {
                            result = "wrong run";
                        }
                        else if (first_number == 180)
                        {
                            res3 = 0;
                        }
                        else
                        {
                            res3 = Math.Tan(first_number * Math.PI / 180);
                        }
                        break;
                    case "ctg":
                        if (first_number == 90 || first_number == 270)
                        {
                            res3 = 0;
                        }
                        else if (first_number == 180 || first_number == 0)
                        {
                            result = "wrong run";
                        }
                        else
                        {
                            res3 = Math.Cos(first_number * Math.PI / 180) / Math.Sin(first_number * Math.PI / 180);
                        }
                        break;
                }
                if (result == "")
                {
                    Input.Text = res3.ToString();
                }
                else
                {
                    Input.Text = result;
                    result = "";
                }
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
                }
                Input.Text = res3.ToString();
                i = 0;
            }
        }

        static void Memory_Save(double a)
        {
            FileStream fs = new FileStream(@"Memory.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bn = new BinaryFormatter();
            bn.Serialize(fs, a);
            fs.Close();
        }
        static double Memory_read()
        {
            FileStream fs = new FileStream(@"Memory.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bn = new BinaryFormatter();
            double mem = (double) bn.Deserialize(fs);
            fs.Close();
            return mem;
        }

        private void MS_Click(object sender, EventArgs e)
        {
            M_label.Text = "M";
            label.Text = "";
            memory = double.Parse(Input.Text);
            Memory_Save(memory);
            i = 0;
        }

        private void MRead_Click(object sender, EventArgs e) 
        {
            Input.Text = Memory_read().ToString();
            label.Text = "";
            i = 0;
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            double f = Memory_read() + double.Parse(Input.Text);
            Memory_Save(f);
            label.Text = "";
            i = 0;
        }

        private void MMinus_Click(object sender, EventArgs e)
        {
            double f = Memory_read() - double.Parse(Input.Text);
            Memory_Save(f);
            label.Text = "";
            i = 0;
        }

        private void MClear_Click(object sender, EventArgs e)
        {
            Memory_Save(0);
            M_label.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            string[] y = label.Text.Split(' ');
            if (y.Length == 3)
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

        private void Point_click(object sender, EventArgs e)
        {
            i++;
            string[] str6 = label.Text.Split(' ');

            if (Input.Text.Contains('.') == false)
            {
                if (Input.Text == "0")
                {
                    Input.Text += ".";
                    label.Text += "0.";
                }
                else
                {
                    Input.Text += ".";
                    label.Text += ".";
                }
            }
        }

        //int f = 0;
        private void Del_Click(object sender, EventArgs e)
        {
            //!label.Text.Contains("ln") && !label.Text.Contains("ctg") && !label.Text.Contains("tan") && !label.Text.Contains("cos") && !label.Text.Contains("sin") && !label.Text.Contains("sqr") && !label.Text.Contains("log") && !label.Text.Contains("fact") && !label.Text.Contains("ln") && !label.Text.Contains("ro")
            if (!label.Text.Contains('(') && !label.Text.Contains(')'))
            {
                if (Input.Text != "0" && label.Text != "")
                {
                    if (Input.Text.Length != 1 )
                    {
                        Input.Text = Input.Text.Remove(Input.Text.Length - 1);
                        label.Text = label.Text.Remove(label.Text.Length - 1);
                    }
                    else
                    {
                        Input.Text = "0";
                        label.Text = label.Text.Remove(label.Text.Length - 1);
                    }
                }
            }
            //i = 0;
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
            string[] y = label.Text.Split(' ');

            if (y.Length == 1 && Input.Text != "0")
            {
                double d = -1 * int.Parse(Input.Text);
                Input.Text = d.ToString();
                label.Text = d.ToString();
            }
            if (y.Length == 3 && Input.Text != "0")
            {
                double d = -1 * int.Parse(Input.Text);
                Input.Text = d.ToString();
                label.Text = y[0] + " " + y[1] + " " + d.ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string[] m = label.Text.Split(' ');
            double l = Math.Exp(1);
            if (m.Length == 1)
            {
                label.Text = l.ToString();
            }
            if (m.Length == 2)
            {
                label.Text = label.Text + " " + l.ToString();
            }
            if (m.Length == 3)
            {
                label.Text = m[0] + " " + m[1] + " " + l.ToString();
            }
            Input.Text = l.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string[] m = label.Text.Split(' ');
            double l = Math.PI;
            if (m.Length == 1)
            {
                label.Text = l.ToString();
            }
            if (m.Length == 2)
            {
                label.Text = label.Text + " " + l.ToString();
            }
            if (m.Length == 3)
            {
                label.Text =  m[0] + " " + m[1] + " " + l.ToString(); 
            }
            Input.Text = l.ToString();
        }
    }
}