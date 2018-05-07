using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
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

        Queue<Point> q;
        Color init_Color;
        Color Fill_Color;
        public Form1()
        {
            InitializeComponent();
            p = new Pen(System.Drawing.Color.Black, 1);
            e = new Pen(System.Drawing.Color.White, 5);
            path = new GraphicsPath();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
            q = new Queue<Point>();
            tb2.Text = pictureBox1.Size.Width + "x" + pictureBox1.Size.Height + "пкс";
            Color1.BackColor = Color.Black;
            Color2.BackColor = Color.White;
            panel1.BackColor = Color.Gold;
        }

        public void Check(int px, int py)
        {
            if (px <= 0 || px >= pictureBox1.Width || py <= 0 || py >= pictureBox1.Height)
            {
                return;
            }
            if (btm.GetPixel(px, py) == init_Color)
            {
                btm.SetPixel(px, py, Fill_Color);
                q.Enqueue(new Point(px, py));
            }
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            tool = btn.Name;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(p, path);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;

            if(tool == "Choose")
            {
                p.Color = btm.GetPixel(e.X, e.Y);
                Color1.BackColor = btm.GetPixel(e.X, e.Y);
            }
            if(tool == "Fill")
            {
                q.Enqueue(e.Location);
                init_Color = btm.GetPixel(e.X, e.Y);
                while (q.Count > 0)
                {
                    int xx = q.First().X;
                    int yy = q.First().Y;
                    Check(xx, yy -1);
                    Check(xx, yy + 1);
                    Check(xx + 1, yy);
                    Check(xx - 1, yy);
                    q.Dequeue();
                }
                pictureBox1.Refresh();
            }
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
                        //g.DrawEllipse(p, new Rectangle(cur.X, cur.Y, (int)p.Width/2, (int)p.Width/2));
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
                    case "Cube":
                        path.Reset();
                        if (prev.X < cur.X && prev.Y < cur.Y)
                        {
                            path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                            path.AddRectangle(new Rectangle(prev.X + (cur.X - prev.X) / 2, prev.Y - (cur.Y - prev.Y) / 3, cur.X - prev.X, cur.Y - prev.Y));
                            pictureBox1.Refresh();
                        }
                        if (prev.X > cur.X && prev.Y > cur.Y)
                        {
                            path.AddRectangle(new Rectangle(cur.X, cur.Y, prev.X - cur.X, prev.Y - cur.Y));
                            path.AddRectangle(new Rectangle(cur.X - (prev.X - cur.X) / 2, cur.Y + (prev.Y - cur.Y) / 3, prev.X - cur.X, prev.Y - cur.Y));
                            pictureBox1.Refresh();
                        }
                        if (prev.X < cur.X && prev.Y > cur.Y)
                        {
                            path.AddRectangle(new Rectangle(prev.X, cur.Y, cur.X - prev.X, prev.Y - cur.Y));
                            path.AddRectangle(new Rectangle(prev.X +  (cur.X - prev.X)/2, cur.Y + (prev.Y - cur.Y)/3, cur.X - prev.X, prev.Y - cur.Y));
                            pictureBox1.Refresh();
                        }
                        if (prev.X > cur.X && prev.Y < cur.Y)
                        {
                            path.AddRectangle(new Rectangle(cur.X, prev.Y, prev.X - cur.X, cur.Y - prev.Y));
                            path.AddRectangle(new Rectangle(cur.X - (prev.X - cur.X)/2, prev.Y - (cur.Y - prev.Y) / 3, prev.X - cur.X, cur.Y - prev.Y));
                            pictureBox1.Refresh();
                        }
                        path.AddLine(prev.X, prev.Y, prev.X + (cur.X - prev.X)/2, prev.Y - (cur.Y - prev.Y)/3);
                        path.AddLine(prev.X + (cur.X - prev.X) / 2, cur.Y - (cur.Y - prev.Y) / 3, prev.X, cur.Y);
                        path.AddLine(cur.X, cur.Y, cur.X + (cur.X - prev.X) / 2, cur.Y - (cur.Y - prev.Y) / 3);
                        path.AddLine(cur.X + (cur.X - prev.X) / 2, prev.Y - (cur.Y - prev.Y) / 3, cur.X, prev.Y);
                        pictureBox1.Refresh();
                        break;
                }
            }
            tb1.Text = e.X + ", " + e.Y + "пкс";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                Bitmap bmp = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Title = "Magzhan";
            openFileDialog1.Filter = "PNG (*.png)|*.png*|JPEG (*.jpg;*.jpeg)|*.jpg*|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Colorss_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (panel1.BackColor == Color.Gold)
            {
                p = new Pen(btn.BackColor, (int)numericUpDown1.Value);
                Color1.BackColor = btn.BackColor;
                Fill_Color = btn.BackColor;
            }
            if (panel2.BackColor == Color.Gold)
            {
                this.e.Color = btn.BackColor;
                Color2.BackColor = btn.BackColor;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e) 
        {
            p.Width = (float)numericUpDown1.Value;
            this.e.Width = (float)numericUpDown1.Value;
        }

        private void panels_Click(object sender, EventArgs e)
        {
            Panel pn = sender as Panel;
            if (pn.Name == "panel1")
            {
                panel1.BackColor = Color.Gold;
                panel2.BackColor = Color.White;
            }
            if (pn.Name == "panel2")
            {
                panel2.BackColor = Color.Gold;
                panel1.BackColor = Color.White;
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (panel1.BackColor == Color.Gold)
                {
                    p = new Pen(colorDialog1.Color, (int)numericUpDown1.Value);
                    Color1.BackColor = colorDialog1.Color;
                }
                if (panel2.BackColor == Color.Gold)
                {
                    this.e = new Pen(colorDialog1.Color, (int)numericUpDown1.Value);
                    Color2.BackColor = colorDialog1.Color;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(p, path);
            path.Reset();
        }
    }
}
