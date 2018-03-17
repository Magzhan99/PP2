using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_size_of_Button
{
    
    public partial class Form1 : Form
    {
        int a;
        int b;
        public Form1()
        {
            InitializeComponent();

            btn.Text = "(" + btn.Width + "," + btn.Height + ")" + "";
            a = btn.Width;
            b = btn.Height;
        }
        
        private void Scroll(object sender, EventArgs e)
        {
            btn.Width  = a * tbar.Value;
            btn.Height = b * tbar.Value;
            btn.Text = "(" + btn.Width * tbar.Value + "," + btn.Height * tbar.Value + ")" +"";
        }
    }
}
