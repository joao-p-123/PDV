using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PDV
{
     class conexao
    {

        public string conect = "SERVER = 127.0.0.1:3307 DATABASE=PDV; UID=root PORT=;";

        public MySqlConnection MySqlConnection = null;

        public void AbrirConexao()
        {
            MySqlConnection = new MySqlConnection(conect);
            MySqlConnection.Open();
        }
        public void FecharConexao()
        {
            MySqlConnection = new MySqlConnection(conect);
            MySqlConnection.Close();
            MySqlConnection.Dispose(); //derruba algumas conexoes abertas
            MySqlConnection.ClearAllPoolsAsync(); //metodo de limpeza
        }
    }
}
