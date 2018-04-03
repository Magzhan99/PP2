using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            g = CreateGraphics();
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawLine(Pens.Red, 200, 10, 200, 200);
            Point p1 = new Point(10, 10);
            Point p2 = new Point(100, 100);

            g.DrawLine(Pens.Blue, p1, p2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            Font f = new Font(FontFamily.GenericSerif, 8);
            g.DrawString("MAGZHAN KADYLBEKOV",f, b, 65, 115);
        }
    }
}
