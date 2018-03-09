using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            a = a % 3;
            if (a == 0)
                button1.BackColor = Color.Blue;
            if (a == 1)
                button1.BackColor = Color.Red;
            if (a == 2)
                button1.BackColor = Color.Yellow;
            
        }
    }
}
 