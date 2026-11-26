using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KisiselButceIstekIhtiyac.Database
{
    public class DbConnection
    {
        private readonly string connectionString = "Server=localhost;Database=karar_asistani_db;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}