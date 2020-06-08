using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CidadeDB
    {
        //Conexao: 
        private static SQLiteConnection sqliteConnection;
        public CidadeDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public DataTable consultar()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT id,       ");
            sb.Append("        nome      ");
            sb.Append("  FROM  tb_cidade ");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
