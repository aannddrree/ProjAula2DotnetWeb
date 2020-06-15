using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable Consultar()
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

        public List<Cidade> ConsultarList()
        {
            SQLiteDataReader dr;
            List<Cidade> cidades = new List<Cidade>();

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT id,        ");
            sb.Append("        nome      ");
            sb.Append("  FROM  tb_cidade ");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                dr = cmd.ExecuteReader();
            }

            while (dr.Read())
            {
                string id = dr.GetString(1).ToString();
                string nome = dr.GetString(2).ToString();
                cidades.Add(new Cidade());
            }
            return cidades;
        }

    }
}
