using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiral
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0, d = 10, f = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tr.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            tr.Interval = 100;
            MessageBox.Show(btn.Location + "");
        }

        int ok = 0;
        
        private void tr_Tick(object sender, EventArgs e)
        {
            x = btn.Location.X;
            y = btn.Location.Y;
            for( int i = 0; i < 181; i += 30)
            {
                if(x == i && y == i)
                {
                    x = i + 30;
                    y = i + 30;
                    f += 30;
                    break;
                }
            }

            if (y == 1 && x == 0)
            {
                y = 0;
                ok = 1;
            }



            if (ok == 1)
            {
                if (x == f && y < 440 - f)
                {
                    y += d;
                    ok = 1;
                }

                if (y == 440 - f && x < 620 - f)
                {
                    x += d;
                    ok = 2;
                }
                if (x == 620 - f && y > f)
                {
                    y -= d;
                    ok = 3;
                }
                if (y == f && x > f)
                {
                    x -= d;
                    ok = 4;
                }
            }
            else
            {
                if (x == f && y < 440 - f)
                {
                    y += d;
                    ok = 1;
                }

                if (y == 440 - f && x < 620 - f)
                {
                    x += d;
                    ok = 2;
                }
                if (x == 620 - f && y > f)
                {
                    y -= d;
                    ok = 3;
                }
                if (y == f && x > f)
                {
                    x -= d;
                    ok = 4;
                }
            }

            Button b = new Button();
            b.BackColor = Color.Red;
            b.Location = new Point(x, y);
            b.Size = new Size(30, 30);
            b.FlatStyle = FlatStyle.Popup;
            Controls.Add(b);
            btn.Location = new Point(x, y);
        }
    }
}
