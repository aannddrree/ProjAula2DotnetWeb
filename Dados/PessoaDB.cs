using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PessoaDB
    {
        //Testar
        private static List<Pessoa> lstPessoa = new List<Pessoa>();
        
        public PessoaDB()
        {
            //Implementar
        }

        public bool Salvar(Pessoa pessoa)
        {
            try
            {
                lstPessoa.Add(pessoa);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Pessoa> ConsultarTudo()
        {
            return lstPessoa;
        }
    }
}
