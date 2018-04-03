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

namespace BitMaps
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        Pen p;
        Bitmap btm;
        Point prev, cur;
        public Form1()
        {
            InitializeComponent();
            p = new Pen(Color.Red, 3);
            path = new GraphicsPath();

            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(p, path);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            path.Reset();
            if (e.Button == MouseButtons.Left)
            {
                cur = e.Location;
                if (prev.X < cur.X && prev.Y < cur.Y)
                {
                    path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    pictureBox1.Refresh();
                }
                if (prev.X > cur.X && prev.Y > cur.Y)
                {
                    path.AddRectangle(new Rectangle(cur.X, cur.Y, prev.X - cur.X, prev.Y - cur.Y));
                    pictureBox1.Refresh();
                }
                if (prev.X < cur.X && prev.Y > cur.Y)
                {
                    path.AddRectangle(new Rectangle(prev.X, cur.Y, cur.X - prev.X, prev.Y - cur.Y));
                    pictureBox1.Refresh();
                }
                if (prev.X > cur.X && prev.Y < cur.Y)
                {
                    path.AddRectangle(new Rectangle(cur.X, prev.Y, prev.X - cur.X, cur.Y - prev.Y));
                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (path != null)
                g.DrawPath(p, path);
        }
    }
}
