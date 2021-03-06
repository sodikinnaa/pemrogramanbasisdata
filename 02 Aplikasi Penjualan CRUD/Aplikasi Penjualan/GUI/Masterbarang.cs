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
            clear();
            aturTobmol(false, false);
        }

        //Input header dari gride barang
        void header()
        {
            Databarang.Columns[1].HeaderText = "Nama Barang";
            Databarang.Columns[1].HeaderText = "Kode Barang";
            Databarang.Columns[2].HeaderText = "Stok Barang";
            Databarang.Columns[3].HeaderText = "harga Barang";
            Databarang.Columns[4].HeaderText = "Jenis Makanan";

        }

        //Menampilkan dara di grid barang
        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT  * FROM tabel_barang";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getCon();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "tabel_barang");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return dts;
        }
        public void loadDaftar()
        {
            DataSet data = getData();
            Databarang.DataSource = data;
            Databarang.DataMember = "tabel_barang";
            header();
        }


        void clear()
        {
            textID.Clear();
            textnama.Clear();
        }

        //Pengatur tombol hide dan tampil
        void aturTobmol(bool param1, bool param2)
        {
            btnew.Enabled = true;
            btsend.Enabled = param1;
            btedit.Enabled = param2;
            btupdate.Enabled = param2;
            btdelt.Enabled = param2;

            textID.Enabled = param1;
            textnama.Enabled = param1;
            txtstok.Enabled = param1;
            textharga.Enabled = param1;
            cbjenis.Enabled = param1;
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            aturTobmol(true, false);

        }

        //Menapilkan data di gride di form atas
        private void Databarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textnama.Text = Databarang.Rows[e.RowIndex].Cells[0].Value.ToString();
                textID.Text = Databarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtstok.Text = Databarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                textharga.Text = Databarang.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbjenis.Text = Databarang.Rows[e.RowIndex].Cells[4].Value.ToString();

                btedit.Enabled = true;
                btdelt.Enabled = true;
            }
            catch
            {
                //LULPA MAU DI ISI APAAN 
            }
            
        }

        //Memasukan barang di table database
        private void btsend_Click(object sender, EventArgs e)
        {
            aturTobmol(false, false);
            try
            {
                string sql = "insert into tabel_barang(id_barang, nama_barang, stok_barang, harga_barang, jenis_barang) values (@kode, @nama, @stok, @harga, @jenis)";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getCon();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@kode", textID.Text);
                command.Parameters.AddWithValue("@nama", textnama.Text);
                command.Parameters.AddWithValue("@stok", txtstok.Text);
                command.Parameters.AddWithValue("@harga", textharga.Text);
                command.Parameters.AddWithValue("@jenis", cbjenis.Text);

                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Dara berhasil disimpan", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDaftar();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan \n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            btupdate.Enabled = true;
            textnama.Enabled = true;
            textharga.Enabled = true;
            txtstok.Enabled = true;
            cbjenis.Enabled = true;
            btdelt.Enabled = false;
            btnew.Enabled = false;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update tabel_barang set nama_barang=@nama, stok_barang=@stok, harga_barang=@harga, jenis_barang=@jenis where id_barang=@kode";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getCon();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@kode", textID.Text);
                command.Parameters.AddWithValue("@nama", textnama.Text);
                command.Parameters.AddWithValue("@stok", txtstok.Text);
                command.Parameters.AddWithValue("@harga", textharga.Text);
                command.Parameters.AddWithValue("@jenis", cbjenis.Text);

                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Data berhsil disimpan", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDaftar();
                clear();
                aturTobmol(false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan \n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btdelt_Click(object sender, EventArgs e)
        {
            DialogResult akes = MessageBox.Show("Apakah anda yakin?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (akes == DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tabel_barang where id_barang=@kode";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getCon();
                    command.Connection.Open();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@kode", textID.Text);

                    command.ExecuteNonQuery();
                    command.Connection.Close();

                    MessageBox.Show("Data berhasil dihapus", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDaftar();
                    clear();
                    aturTobmol(false, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan \n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textpencarian.Text == "")
            {
                loadDaftar();
            }
            else
            {
                try
                {
                    string text = textpencarian.Text;
                    DataSet dts = new DataSet();
                    string sql = "SELECT * FROM tabel_barang WHERE id_barang LIKE '%" + text + "%' OR nama_barang LIKE '%" + text + "%';";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koneksi.getCon();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    MySqlDataAdapter data = new MySqlDataAdapter(command);
                    data.Fill(dts, "tabel_barang");
                    Databarang.DataSource = dts;
                    Databarang.DataMember = "tabel_barang";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("get \n" + ex.ToString());
                }
            }
        }
    }
}
