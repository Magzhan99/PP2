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

namespace Shapes
{
    public partial class Form1 : Form
    {
        Pen pen;
        Graphics g;
        Point p, c;
        GraphicsPath path;
        Point[] arr;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Red, 5);
            g.Clear(Color.White);
            path = new GraphicsPath();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g.DrawPath(pen, path);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (path != null)
                g.DrawPath(pen, path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] arr =
            {
                new Point(10, 10),
                new Point(300, 50),
                new Point(150, 200)
                //new Point(30, 200)
            };
            g.DrawPolygon(pen, arr);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            path.Reset();
            if (e.Button == MouseButtons.Left)
            {
                c = e.Location;
                path.AddLine(p.X, p.Y, c.X - p.X, c.Y - p.Y);
                p = c;
            }
            Refresh();
        }
    }
}
