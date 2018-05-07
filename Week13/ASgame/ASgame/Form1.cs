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

namespace ASgame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        static int x = 200, y = 200, xb, yb;
        SolidBrush s;
        GraphicsPath path;
        bool ok;
        Point[] points, ast1, ast2;
        List<Point> aster;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Red, 3);
            s = new SolidBrush(Color.Red);
            path = new GraphicsPath();
            ok = true;
            aster = new List<Point>();
            timer2.Start();
        }

        int nth = 0;
        Random R = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(nth % 30 == 0)
            {
                aster.Add(new Point(R.Next(0, Width - 40), 0));
            }
            for (int i = 0; i < aster.Count; i++)
            {
                int y = aster[i].Y;
                y+=5;
                ast2 = new Point[]
                {
                    new Point(aster[i].X, y + 15),
                    new Point(aster[i].X + 45, y + 15),
                    new Point(aster[i].X + 23, y + 45)
                };
                ast1 = new Point[]
                {
                    new Point(aster[i].X + 23, y),
                    new Point(aster[i].X , y +30),
                    new Point(aster[i].X + 45, y +30)
                };
                aster[i] = new Point(aster[i].X, y);
                g.FillPolygon(new SolidBrush(Color.Gold), ast1);
                g.FillPolygon(new SolidBrush(Color.Gold), ast2);
            }
            nth++;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            points = new Point[] {
            new Point(x + 50, y),
            new Point(x + 100, y + 25),
            new Point(x + 100, y + 75),
            new Point(x + 50, y + 100),
            new Point(x , y + 75),
            new Point(x, y + 25)
            };

            e.Graphics.FillPolygon(s, points);

            if (yb + 25 > 0)
            {
                g.Clear(Color.DarkViolet);
                g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(xb + 40, yb -= 2, 20, 20));
                g.FillPolygon(s, points);
            }
            else
            {
                ok = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    x -= 10;
                    break;
                case Keys.D:
                    x += 10;
                    break;
                case Keys.W:
                    y -= 10; ;
                    break;
                case Keys.S:
                    y += 10;
                    break;
                case Keys.Space:
                    if (ok)
                    {
                        xb = x;
                        yb = y;
                        g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(xb + 40, yb, 20, 20));
                        timer1.Start();
                        ok = false;
                    }
                    break;
            }
        }
    }
}
