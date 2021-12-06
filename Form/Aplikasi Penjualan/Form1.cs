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
    public partial class Form1 : Form
    {
        public pindah kesono = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pindah x = new pindah();
            kesono.textBox2.Text = textBox1.Text;
            x.Show();
        }
    }
}
