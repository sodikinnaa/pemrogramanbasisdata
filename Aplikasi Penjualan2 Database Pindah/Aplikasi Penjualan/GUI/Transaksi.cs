using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Penjualan.GUI
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
                       
        }
        void header()
        {
            datatransaksi.Columns[0].HeaderText = "Kode Transaksi";
            datatransaksi.Columns[1].HeaderText = "Kode Barang";
            datatransaksi.Columns[2].HeaderText = "Jumlah";
            datatransaksi.Columns[3].HeaderText = "Total Harga";
        }

        private void datatransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }
    }
}
