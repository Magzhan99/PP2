using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_start
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        Pen p, e;
        Bitmap btm;
        Point prev, cur;
        string tool;
        public Form1()
        {
            InitializeComponent();
            p = new Pen(System.Drawing.Color.Red, 2);
            e = new Pen(System.Drawing.Color.White, 5);
            path = new GraphicsPath();

            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(System.Drawing.Color.White);
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            tool = btn.Text;
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
            if (e.Button == MouseButtons.Left)
            {
                cur = e.Location;
                switch (tool)
                {
                    case "Rectangle":
                        path.Reset();
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
                        break;
                    case "Line":
                        path.Reset();
                        path.AddLine(prev, cur);
                        pictureBox1.Refresh();
                        break;
                    case "Pencil":
                        g.DrawLine(p, prev ,cur);
                        prev = cur;
                        pictureBox1.Refresh();
                        break;
                    case "Eraser":
                        g.DrawLine(this.e, prev, cur);
                        prev = cur;
                        pictureBox1.Refresh();
                        break;
                    case "Triangle":
                        Point[] tr = 
                        {
                            new Point((prev.X + e.Location.X)/2, prev.Y),
                            new Point(e.Location.X, e.Location.Y),
                            new Point(prev.X, e.Location.Y)
                        };
                        path.Reset();
                        path.AddPolygon(tr);
                        pictureBox1.Refresh();
                        break;
                    case "Circle":
                        path.Reset();
                        path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                        pictureBox1.Refresh();
                        break;
                    case "Romb":
                        Point[] r =
                        {
                            new Point((prev.X + cur.X)/2, prev.Y),
                            new Point(cur.X, (cur.Y + prev.Y)/2),
                            new Point((prev.X + cur.X)/2, cur.Y),
                            new Point(prev.X, (cur.Y + prev.Y)/2)
                        };
                        path.Reset();
                        path.AddPolygon(r);
                        pictureBox1.Refresh();
                        break;
                    case "BesBurysh":
                        Point[] b =
                        {
                            new Point((prev.X + cur.X)/2, prev.Y),
                            new Point(cur.X, (cur.Y + prev.Y)/2),
                            new Point(cur.X - (cur.X - prev.X) / 4, cur.Y),  
                            new Point(prev.X + (cur.X - prev.X) / 4, cur.Y),
                            new Point(prev.X, (cur.Y + prev.Y)/2)
                        };
                        path.Reset();
                        path.AddPolygon(b);
                        pictureBox1.Refresh();
                        break;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Magzhan";
            saveFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg*)|*.jpg*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                btm.Save(saveFileDialog1.FileName);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Magzhan";
            openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg*)|*.jpg*";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }   
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p = new Pen(colorDialog1.Color, 3);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (path != null)
                g.DrawPath(p, path);
        }
    }
}
