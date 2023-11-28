using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager_VisPro_Group5
{
    internal class Sql
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat;

        public Tuple<MySqlDataAdapter, int> SqlQuery(string query)
        {
            koneksi.Open();
            perintah = new MySqlCommand(query, koneksi);
            adapter = new MySqlDataAdapter(perintah);
            int res = perintah.ExecuteNonQuery();
            koneksi.Close();

            return Tuple.Create(adapter, res);
        }
        
        public DataSet SqlDatabase(MySqlDataAdapter adapter)
        {
            ds.Clear();
            adapter.Fill(ds);

            return ds;
        }
        public MySqlConnection SqlSetup(string server, string database, string username, string password)
        {
            alamat = string.Format("server={0}; database={1}; username={2}; password={3};", server, database, username, password);
            koneksi = new MySqlConnection(alamat);

            return koneksi;
        }
    }
}
