using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aplikasi_Penjualan.Kelas
{
    class koneksi
    {
        public MySqlConnection getCon()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string database = "pbo";
            string ConnStr ="server="+host+";user="+user+";database="+database+";password="+password+";";
            MySqlConnection conn = new MySqlConnection(ConnStr);
            return conn;
        }
    }
}
