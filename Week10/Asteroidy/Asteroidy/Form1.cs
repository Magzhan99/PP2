using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroidy
{
    public partial class Form1 : Form
    {
        int k = 0, score = 0;
        List<Button> body= new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        public bool Collision()
        {
            int x_1 = btn.Location.X;
            int y_1 = btn.Location.Y;
            int w_1 = btn.Width;
            int h_1 = btn.Height;

            for (int j = 0; j <body.Count; j++)
            {
                int w_h = body[j].Width;
                int a = body[j].Location.X;
                int b = body[j].Location.Y;

                if (a >= x_1 - w_h && a <= x_1 + w_1)
                {
                    if (y_1 == b+ h_1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tr.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (btn.Location.X > 1)
                    {
                        btn.Location = new Point(btn.Location.X - 20, btn.Location.Y);
                    }
                    break;
                case Keys.D:
                    if (btn.Location.X < 440)
                    {
                        btn.Location = new Point(btn.Location.X + 20, btn.Location.Y);
                    }
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btn.Location + "");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(k % 8 == 0)
            {
                Random R = new Random();
                Button button1 = new Button();
                button1.Location = new Point(R.Next(0, 515), 0);
                button1.Size = new Size(25, 25);
                body.Add(button1);
                Controls.Add(button1);
            }

            for (int i = 0; i < body.Count; i++)
            {
                int x = body[i].Location.X;
                int y = body[i].Location.Y;
                y ++;
                if (y < btn.Location.Y + 100)
                {
                    body[i].Location = new Point(x, y);
                }
                else if(y >= btn.Location.Y + 100)
                {
                    score++;
                    body.Remove(body[i]);
                    Controls.Remove(body[i]);
                }
                y = body[i].Location.Y;
            }

            if (!Collision())
            {
                tr.Stop();
                MessageBox.Show("GAME OVER" + "\n" + "your score is " + score.ToString());
            }

            k++;
        }
    }
}
