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

namespace Game
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        static int x = 200, y = 200;
        SolidBrush s;
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Red, 3);
            s = new SolidBrush(Color.Red);
            path = new GraphicsPath();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = {
            new Point(x + 50, y),
            new Point(x + 100, y + 25),
            new Point(x + 100, y + 75),
            new Point(x + 50, y + 100),
            new Point(x , y + 75),
            new Point(x, y + 25)
            };

            e.Graphics.FillPolygon(s, points);
            g.DrawPath(p, path);

            Random r = new Random();
            path.AddEllipse(new Rectangle(r.Next(0, 970), r.Next(0, 570), 20, 20));
            path.AddEllipse(new Rectangle(r.Next(0, 970), r.Next(0, 570), 20, 20));
            path.AddEllipse(new Rectangle(r.Next(0, 970), r.Next(0, 570), 20, 20));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    x-=10;
                    Refresh();
                    break;
                case Keys.D:
                    x+=10;
                    Refresh();
                    break;
                case Keys.W:
                    y-=10; ;
                    Refresh();
                    break;
                case Keys.S:
                    y+=10;
                    Refresh();
                    break;
            }
        }
    }
}
