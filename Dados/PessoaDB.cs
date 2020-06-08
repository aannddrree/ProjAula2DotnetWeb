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
    public class PessoaDB
    {   
        //Conexao: 
        private static SQLiteConnection sqliteConnection; 

        public PessoaDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Pessoa pessoa)
        {
            try
            {
                string sql = "INSERT INTO tb_pessoa (codigo, nome, telefone, endereco, cidade) values (@Codigo, @Nome, @Telefone, @Endereco, @Cidade)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                    cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade.Id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException)
            {
                throw;
            }      
        }

        public DataTable ConsultarTudo()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT p.codigo Codigo,      ");
            sb.Append("       p.nome Nome,         ");
            sb.Append("       p.endereco Endereco,     ");
            sb.Append("       p.telefone Telefone,     ");
            sb.Append("       c.nome Cidade   ");
            sb.Append("  FROM tb_pessoa p,    ");
            sb.Append("       tb_cidade c     ");
            sb.Append(" where p.cidade = c.id ");

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
