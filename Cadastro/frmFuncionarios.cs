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
using System.IO;

namespace PDV.Cadastro
{
    public partial class frmFuncionarios : Form
    {
        conexao MySqlConnection = new conexao();
        string sql;
        string foto;
      
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
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;

            }
            if (txtCpf.Text == "  _  _  _" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return ;

            }
            MySqlConnection.AbrirConexao();

            sql = "INSERT INTO funcionarios(nome, cpf, endereco, telefone, cargo, data, foto) VALUES(@nome, @cpf, @endereco, @telefone, @cargo, curDate(), @foto)";

            cmd = new MySqlCommand(sql, MySqlConnection.MySqlConnection);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereço.Text);
            cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            cmd.Parameters.AddWithValue("@cargo", CombCargo.Text);
          //  cmd.Parameters.AddWithValue("@imagem", img());

            cmd.ExecuteNonQuery();
            MySqlConnection.FecharConexao();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Arquivos(*.jpg)|*.jpg | Arquivos(*.PNG)| *.png;
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";//mostra jpg e png

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();//pegando o caminho da imagem que selecionei e dei ok
                image.ImageLocation = foto; //jogando caminho da imagem p/ componente img p/ exibir no form
              //  alterouimagem = "sim"; // p/ uso editar alterando a imagem

            }

        }

        private byte[] img()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs); //serve para trabalhar com o filestream

            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }
        private void limparfoto()
        {
            image.Image = Properties.Resources.cliente_tel;
            foto = "img/cliente_tel.png";
        }
    }
}
