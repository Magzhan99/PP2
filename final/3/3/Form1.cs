using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        bool ok1, ok2, ok3, ok4;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            ok1 = true;
            ok2 = true;
            ok3 = true;
            ok4 = true;
        }
        static Random r = new Random();
        int k = r.Next(0, 1);
        private void Buttons_click(object sender, EventArgs e)
        {
            k++;
            Button b = sender as Button;
            int x = b.Location.X;
            int y = b.Location.Y ;
            if (k % 2 == 0)
                b.Text = "X";
            else
                b.Text = "O";

            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "")
                {
                    if (x == buttons[i].Location.X  && y != buttons[i].Location.Y )
                    {
                        //MessageBox.Show("ok1");
                        if (buttons[i].Text != b.Text)
                        {
                            ok1 = false;
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "")
                {
                    if (y == buttons[i].Location.Y  && x != buttons[i].Location.X )
                    {
                        //MessageBox.Show("ok2");
                        if (buttons[i].Text != b.Text)
                        {
                            ok2 = false;
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "")
                {
                    if (x == y && buttons[i].Location.Y == buttons[i].Location.X && x != buttons[i].Location.X )
                    {
                        //MessageBox.Show("ok3");
                        if (buttons[i].Text != b.Text)
                        {
                            ok3 = false;
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "")
                {
                    if (x + y == buttons[i].Location.Y + buttons[i].Location.X && x != buttons[i].Location.X)
                    {
                        //MessageBox.Show("ok4");
                        if (buttons[i].Text != b.Text)
                        {
                            ok4 = false;
                        }
                    }
                }
                
            }
            if (ok1)
            {
                MessageBox.Show("Game over");
            }
            if (ok2)
            {
                MessageBox.Show("Game over");
            }
            if (ok3)
            {
                MessageBox.Show("Game over");
            }
            if (ok4)
            {
                MessageBox.Show("Game over");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i= 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30 , 30);
                    btn.Location = new Point(j * 30, i * 30);
                    btn.Text = "";
                    Controls.Add(btn);
                    buttons.Add(btn);
                    btn.Click += Buttons_click;
                }
            }
        }
    }
}
