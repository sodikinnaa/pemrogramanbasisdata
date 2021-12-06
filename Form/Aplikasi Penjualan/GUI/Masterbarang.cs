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
    public partial class Masterbarang : Form
    {
        Kelas.koneksi koneksi = new Kelas.koneksi();
        
        public Masterbarang()
        {
            InitializeComponent();
            loadDaftar();
        }

        void header()
        {
            Databarang.Columns[0].Visible = false;
            Databarang.Columns[1].HeaderText = "Nama Barang";
            Databarang.Columns[2].HeaderText = "Jenis Barang";
            Databarang.Columns[3].HeaderText = "Satuan Barang";
            Databarang.Columns[4].HeaderText = "Harga Beli";
            Databarang.Columns[5].HeaderText = "Harga Jual";
            Databarang.Columns[6].HeaderText = "stok";

        }

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT  * FROM tbl_barang";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getCon();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "tbl_barang");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return dts;
        }
        public void loadDaftar()
        {
            DataSet data = getData();
            Databarang.DataSource = data;
            Databarang.DataMember = "tbl_barang";
            header();
        }
    }
}
