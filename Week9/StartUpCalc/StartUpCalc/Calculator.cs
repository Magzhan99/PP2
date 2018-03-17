using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartUpCalc
{
    public partial class Calculator : Form
    {
        double first_number, second_number, res, memory;
        string symbol;
        int initial = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input.TextAlign = HorizontalAlignment.Right;
            Input.Text = initial.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(Input.Text);
            Input.Text = initial.ToString();
        }

        private void memory_read(object sender, EventArgs e)
        {
            Input.Text = memory.ToString();
        }

        private void memory_plus(object sender, EventArgs e)
        {
            memory = memory + double.Parse(Input.Text);
        }

        private void memory_minus(object sender, EventArgs e)
        {
            memory = memory - double.Parse(Input.Text);
        }

        private void memory_clear(object sender, EventArgs e)
        {
            memory = 0;
            Input.Text = initial.ToString();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button num = sender as Button;
            Input.Text = Input.Text + num.Text;
        }
       
        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "ln" && btn.Text != "log" && btn.Text != "sin" && btn.Text != "cos" && btn.Text != "tan")
                first_number = double.Parse(Input.Text);
            else
                first_number = 0;
            symbol = btn.Text;         //type of operation
            if (btn.Text != "ln" && btn.Text != "log" && btn.Text != "sin" && btn.Text != "cos" && btn.Text != "tan")
                Input.Text = initial.ToString();
            else
                Input.Text = symbol;
        }
        int cnt = 0;
        private void Equal_click(object sender, EventArgs e)
        {
            cnt++;
            if (symbol != "x^1/3" && symbol != "x^1/2" && symbol != "n!" && symbol != "log" && symbol != "ln" && symbol != "cos" && symbol != "sin" && symbol != "tan")
                second_number = double.Parse(Input.Text);
            else
                second_number = 0;
            switch (symbol)
            {
                case "+":
                    res = first_number + second_number;
                    break;
                case "-":
                    res = first_number - second_number;
                    break;
                case "/":
                    res = first_number / second_number;
                    break;
                case "*":
                    res = first_number * second_number;
                    break;
                case "x^y":
                    res = Math.Pow(first_number, second_number);                   
                    break;
                case "x^1/y":
                    res = Math.Pow(first_number, 1 / second_number);
                    break;
                case "x^1/3":
                    res = Math.Pow(first_number, 0.333333333333333333333333333333333333333);
                    break;
                case "%":
                    res = first_number * second_number / 100;
                    break;
                case "x^1/2":
                    res = Math.Sqrt(first_number);
                    break;
                case "n!":
                    res = 1;
                    if (first_number > 0)
                    {
                        for (int j = 1; j <= first_number; j++)
                            res = res * j;
                    } else if (first_number < 0)
                    {
                        for (int j = -1; j >= first_number; j--)
                            res = res * j;
                    }
                    else
                    {
                        res = 1;
                    }
                    break;
                case "log":
                    string a = "";
                    for (int i = 3; i < Input.Text.Length; i++)
                        a += Input.Text[i];
                    double z = double.Parse(a);
                    res = Math.Log10(z);
                    break;
                case "ln":
                    string A = "";
                    for (int i = 2; i < Input.Text.Length; i++)
                        A  += Input.Text[i];
                    double x = double.Parse(A);
                    res = Math.Log(x);
                    break;
                case "sin":       
                    string s = "";
                    for (int i = 3; i < Input.Text.Length; i++)
                        s += Input.Text[i];
                    double c = double.Parse(s);
                    res = Math.Sin(c * Math.PI / 180);
                    break;
                case "cos":
                    string d = "";
                    for (int i = 3; i < Input.Text.Length; i++)
                        d += Input.Text[i];
                    double v = double.Parse(d);
                    res = Math.Cos(v * Math.PI /180);
                    break;
                case "tan":
                    string f = "";
                    for (int i = 3; i < Input.Text.Length; i++)
                        f += Input.Text[i];
                    double b = double.Parse(f);
                    res = Math.Sin(b * Math.PI / 180) /Math.Cos(b * Math.PI / 180);
                    break;
            }
            Input.Text = res.ToString();
        }
        int k = 0;
        private void del_Click(object sender, EventArgs e)
        {
            k++;
            string s = Input.Text;
            string t = "";
            for (int i = 0; i < s.Length-k; i++)
            {
                t += s[i];
            }
            Input.Text = t; ;
            k = 0;
        }
        

        private void clear_click(object sender, EventArgs e)
        {
            Input.Text = initial.ToString(); ;
            first_number = 0;
            second_number = 0;
            res = 0;
        }

        private void negativ_Click(object sender, EventArgs e)
        {
            double d = -1 * int.Parse(Input.Text);
            Input.Text = d.ToString();
        }
    }
}
