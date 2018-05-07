using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        List<Button> body;
        Random r;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            body = new List<Button>();
            r = new Random();
            g = CreateGraphics();
            timer1.Start();
        }
        int l = 0;
        int dx = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            l++;
            if (l % 2 == 0)
            {
                Button b = new Button();
                b.Location = new Point(r.Next(0, 590), 0);
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = Color.Red;
                b.Size = new Size(30, 30);
                b.BackColor = Color.FromName(r.Next()) 
                b.Click += Buttons_click;

                body.Add(b);
                Controls.Add(b);
            }
            dx += 5;

            for(int i = 0; i < body.Count(); i++)
            {
                body[i].Location = new Point(body[i].Location.X, body[i].Location.Y + dx);
                if(body[i].Location.Y > Height)
                {
                    Controls.Remove(body[i]);
                    body.Remove(body[i]);
                }
            }

            
        }

        private void Buttons_click(object sender, EventArgs e)
        {

        }
    }
}
