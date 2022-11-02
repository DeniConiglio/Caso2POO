using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moviendo Caballo...");
        }

        private void btnMoverPeon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moviendo Peon...");
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moviendo Torre...");
        }
    }
}
