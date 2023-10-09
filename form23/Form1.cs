using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbRenk1.Checked)
            {
                this.BackColor = Color.Black;
            }
            else if (rbRenk2.Checked)
            {
                this.BackColor = Color.DarkBlue;
            }
            else if (rbRenk3.Checked)
            {
                this.BackColor = Color.DarkOrange;
            }
            else if (rbRenk4.Checked)
            {
                this.BackColor = Color.DarkGray;
            }
        }
    }
}
