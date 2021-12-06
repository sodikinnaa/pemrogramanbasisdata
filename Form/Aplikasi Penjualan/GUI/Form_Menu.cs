using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Penjualan
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Masterbarang x = new GUI.Masterbarang();
            x.MdiParent = this;
            x.Show();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Transaksi y = new GUI.Transaksi();
            y.MdiParent = this;
            y.Show();
        }

        private void des1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
