using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fourth
{
    public partial class Form1 : Form
    {
        List<Rectangle> body;
        Random r;
        Graphics g;
        int h = 0;
        public Form1()
        {
            InitializeComponent();
            body = new List<Rectangle>();
            r = new Random();
            g = CreateGraphics();
            timer1.Start();
        }
        int k = 0; int dx = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            if(k%6 == 0)
            {
                body.Add(new Rectangle(r.Next(0, 590), 0, 30, 30));
            }
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dx += 5;
            for (int i = 0; i < body.Count(); i++)
            {
                g.FillEllipse(new SolidBrush(Color.Blue), body[i].X, body[i].Y + dx, 30, 30);
            }
        }
        Color a, b;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            h++;
            if(h%2 == 1)
            {
                a = ;
            }
            else
            {
                b = ;
                if(a == b)
                {

                }
            }
        }
    }
}
