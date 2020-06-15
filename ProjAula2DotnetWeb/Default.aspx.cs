using Dados;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula2DotnetWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarCidades();
            }
            CarregarTabela();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                Codigo = int.Parse(TxtCodigo.Text),
                Nome = TxtNome.Text,
                Telefone = TxtTelefone.Text,
                Endereco = TxtEndereco.Text,
                Cidade = new Cidade() { Id = int.Parse(DDLCidades.SelectedItem.Value.ToString()) }
            };

            PessoaDB pessoaDB = new PessoaDB();
            bool status = pessoaDB.Salvar(pessoa);

            if (status)
            {
                lblMSG.Text = "Registro Inserido!";
                LimparComponentes();
                CarregarTabela();
            }
            else
            {
                lblMSG.Text = "Erro ao inserir registro";
                lblMSG.ForeColor = Color.Red;
            }

        }

        private void LimparComponentes()
        {
            TxtCodigo.Text = String.Empty;
            TxtEndereco.Text = String.Empty;
            TxtNome.Text = String.Empty;
            TxtTelefone.Text = String.Empty;
            TxtCodigo.Focus();
        }

        private void CarregarTabela()
        {
            PessoaDB pessoaDB = new PessoaDB();
            GVPessoa.DataSource = pessoaDB.ConsultarTudo();
            GVPessoa.DataBind();
        }

        private void CarregarCidades()
        {
            CidadeDB cidadeDB = new CidadeDB();
            DDLCidades.DataSource = cidadeDB.ConsultarList();
            DDLCidades.DataValueField = "Id";
            DDLCidades.DataTextField = "Nome";
            DDLCidades.DataBind();
        }
    }     
            
}