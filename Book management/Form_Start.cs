using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_management
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            timer1.Enabled = false;
            
        }
    }
}
