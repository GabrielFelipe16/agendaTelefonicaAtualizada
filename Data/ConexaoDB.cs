using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaSolo.Data
{
    static internal class ConexaoDB
    {
        static public MySqlConnection CriaConexao()
        {
            string strConn = "Server=localhost;Database=dbagenda;User ID=root;password=root;";

            MySqlConnection conn = new MySqlConnection(strConn);

            return conn;
        }
    }
}
