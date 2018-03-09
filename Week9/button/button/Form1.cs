using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
    public partial class Form1 : Form
    {
        Button b;
        TextBox t;
        Label l;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 500;
            Height = 500;


            b = new Button();
            b.Size = new Size(100, 100);
            b.Text = "Magzhan";

            b.Click += Tap;
            b.BackColor = Color.Gray;
            Controls.Add(b);

            l = new Label();
            l.Location = new Point(0, 100);
            //l.BackColor = Color.Red;
            l.Size = new Size(200, 15);
            l.Text = "Enter the number and press the button";
            Controls.Add(l);

            t = new TextBox();
            t.Location = new Point(100, 20);
            Controls.Add(t);
        }
        bool ok = true;
        int a = -1;
        private void Tap(object sender, EventArgs e)
        {
            a++;
            a = a % 2;
            if(a == 0)
            {
                l.BackColor = Color.Bisque;
            }
            else
            {
                l.BackColor = Color.Cyan;
            }
            int n = int.Parse(t.Text);
            for(int i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                    ok = false;
            }
            if (!ok)
            {
                l.Text = "NO";
                ok = true;
            }
            else
            {
                l.Text = "YES";
                ok = true;
            }
        }

        
    }
}
