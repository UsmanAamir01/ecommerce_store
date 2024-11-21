using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            flowLayoutPanel1.Visible = false;
            
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
