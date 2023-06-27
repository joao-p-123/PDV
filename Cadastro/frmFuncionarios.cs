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

namespace PDV.Cadastro
{
    public partial class frmFuncionarios : Form
    {
        conexao MySqlConnection = new conexao();
        string sql;
      
       MySqlCommand cmd;
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

       
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection.AbrirConexao();

            sql = "INSERT INTO funcionarios(nome, cpf, endereco, telefone, cargo, data, foto) VALUES(@nome, @cpf, @endereco, @telefone, @cargo, curDate(), @foto)";

            cmd = new MySqlCommand(sql, MySqlConnection.MySqlConnection);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", CombCargo.Text);
            cmd.Parameters.AddWithValue("@imagem", img());

            cmd.ExecuteNonQuery();
            MySqlConnection.FecharConexao();

        }

    }
}
