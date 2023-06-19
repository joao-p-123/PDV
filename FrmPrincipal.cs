using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ImgBox2_Click(object sender, EventArgs e)
        {

        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menusair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menufuncionarios_Click(object sender, EventArgs e)
        {
            Cadastro.frmFuncionarios frm = new Cadastro.frmFuncionarios();
            frm.ShowDialog();
        }
    }
}
