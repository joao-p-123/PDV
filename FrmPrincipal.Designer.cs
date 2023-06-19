namespace PDV
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menumovimentaçoes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menurelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menusair = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgBox1 = new System.Windows.Forms.PictureBox();
            this.ImgBox2 = new System.Windows.Forms.PictureBox();
            this.ImgBox3 = new System.Windows.Forms.PictureBox();
            this.ImgBox4 = new System.Windows.Forms.PictureBox();
            this.Menufuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menucliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuusuários = new System.Windows.Forms.ToolStripMenuItem();
            this.Menucargo = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenufluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenulançarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuentradaSaída = new System.Windows.Forms.ToolStripMenuItem();
            this.Menudespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.Menuvendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menumovimrntos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuentradasSaída = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos,
            this.Menumovimentaçoes,
            this.Menurelatórios,
            this.Menusair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menufuncionarios,
            this.Menucliente,
            this.Menuusuários,
            this.Menucargo,
            this.fornecedoresToolStripMenuItem});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(71, 20);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(67, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // Menumovimentaçoes
            // 
            this.Menumovimentaçoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenufluxoCaixa,
            this.MenulançarVenda,
            this.MenuentradaSaída,
            this.Menudespesas});
            this.Menumovimentaçoes.Name = "Menumovimentaçoes";
            this.Menumovimentaçoes.Size = new System.Drawing.Size(104, 20);
            this.Menumovimentaçoes.Text = "Movimentações";
            this.Menumovimentaçoes.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // Menurelatórios
            // 
            this.Menurelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menuproduto,
            this.Menuvendas,
            this.Menumovimrntos,
            this.MenuentradasSaída});
            this.Menurelatórios.Name = "Menurelatórios";
            this.Menurelatórios.Size = new System.Drawing.Size(66, 20);
            this.Menurelatórios.Text = "Relatório";
            // 
            // Menusair
            // 
            this.Menusair.Name = "Menusair";
            this.Menusair.Size = new System.Drawing.Size(38, 20);
            this.Menusair.Text = "Sair";
            this.Menusair.Click += new System.EventHandler(this.Menusair_Click);
            // 
            // ImgBox1
            // 
            this.ImgBox1.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox1.Image")));
            this.ImgBox1.Location = new System.Drawing.Point(416, 38);
            this.ImgBox1.Name = "ImgBox1";
            this.ImgBox1.Size = new System.Drawing.Size(251, 156);
            this.ImgBox1.TabIndex = 1;
            this.ImgBox1.TabStop = false;
            // 
            // ImgBox2
            // 
            this.ImgBox2.Image = global::PDV.Properties.Resources.icons8_shopping_cart_50px;
            this.ImgBox2.Location = new System.Drawing.Point(140, 38);
            this.ImgBox2.Name = "ImgBox2";
            this.ImgBox2.Size = new System.Drawing.Size(212, 156);
            this.ImgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox2.TabIndex = 2;
            this.ImgBox2.TabStop = false;
            this.ImgBox2.Click += new System.EventHandler(this.ImgBox2_Click);
            // 
            // ImgBox3
            // 
            this.ImgBox3.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox3.Image")));
            this.ImgBox3.Location = new System.Drawing.Point(416, 228);
            this.ImgBox3.Name = "ImgBox3";
            this.ImgBox3.Size = new System.Drawing.Size(251, 156);
            this.ImgBox3.TabIndex = 3;
            this.ImgBox3.TabStop = false;
            // 
            // ImgBox4
            // 
            this.ImgBox4.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox4.Image")));
            this.ImgBox4.Location = new System.Drawing.Point(140, 228);
            this.ImgBox4.Name = "ImgBox4";
            this.ImgBox4.Size = new System.Drawing.Size(237, 156);
            this.ImgBox4.TabIndex = 4;
            this.ImgBox4.TabStop = false;
            // 
            // Menufuncionarios
            // 
            this.Menufuncionarios.Name = "Menufuncionarios";
            this.Menufuncionarios.Size = new System.Drawing.Size(180, 22);
            this.Menufuncionarios.Text = "Funcionarios";
            this.Menufuncionarios.Click += new System.EventHandler(this.Menufuncionarios_Click);
            // 
            // Menucliente
            // 
            this.Menucliente.Name = "Menucliente";
            this.Menucliente.Size = new System.Drawing.Size(180, 22);
            this.Menucliente.Text = "Clientes";
            // 
            // Menuusuários
            // 
            this.Menuusuários.Name = "Menuusuários";
            this.Menuusuários.Size = new System.Drawing.Size(180, 22);
            this.Menuusuários.Text = "Usuários";
            // 
            // Menucargo
            // 
            this.Menucargo.Name = "Menucargo";
            this.Menucargo.Size = new System.Drawing.Size(180, 22);
            this.Menucargo.Text = "Cargo";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // MenufluxoCaixa
            // 
            this.MenufluxoCaixa.Name = "MenufluxoCaixa";
            this.MenufluxoCaixa.Size = new System.Drawing.Size(180, 22);
            this.MenufluxoCaixa.Text = "Fluxo caixa";
            // 
            // MenulançarVenda
            // 
            this.MenulançarVenda.Name = "MenulançarVenda";
            this.MenulançarVenda.Size = new System.Drawing.Size(180, 22);
            this.MenulançarVenda.Text = "Lançar Venda";
            // 
            // MenuentradaSaída
            // 
            this.MenuentradaSaída.Name = "MenuentradaSaída";
            this.MenuentradaSaída.Size = new System.Drawing.Size(180, 22);
            this.MenuentradaSaída.Text = "Entrada/Saída";
            // 
            // Menudespesas
            // 
            this.Menudespesas.Name = "Menudespesas";
            this.Menudespesas.Size = new System.Drawing.Size(180, 22);
            this.Menudespesas.Text = "Despesas";
            // 
            // Menuproduto
            // 
            this.Menuproduto.Name = "Menuproduto";
            this.Menuproduto.Size = new System.Drawing.Size(180, 22);
            this.Menuproduto.Text = "Produtos";
            // 
            // Menuvendas
            // 
            this.Menuvendas.Name = "Menuvendas";
            this.Menuvendas.Size = new System.Drawing.Size(180, 22);
            this.Menuvendas.Text = "Vendas";
            // 
            // Menumovimrntos
            // 
            this.Menumovimrntos.Name = "Menumovimrntos";
            this.Menumovimrntos.Size = new System.Drawing.Size(180, 22);
            this.Menumovimrntos.Text = "Movimentos";
            // 
            // MenuentradasSaída
            // 
            this.MenuentradasSaída.Name = "MenuentradasSaída";
            this.MenuentradasSaída.Size = new System.Drawing.Size(180, 22);
            this.MenuentradasSaída.Text = "Entradas/Saída";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImgBox2);
            this.Controls.Add(this.ImgBox4);
            this.Controls.Add(this.ImgBox3);
            this.Controls.Add(this.ImgBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem Menumovimentaçoes;
        private System.Windows.Forms.ToolStripMenuItem Menurelatórios;
        private System.Windows.Forms.ToolStripMenuItem Menusair;
        private System.Windows.Forms.PictureBox ImgBox1;
        private System.Windows.Forms.PictureBox ImgBox2;
        private System.Windows.Forms.PictureBox ImgBox3;
        private System.Windows.Forms.PictureBox ImgBox4;
        private System.Windows.Forms.ToolStripMenuItem Menufuncionarios;
        private System.Windows.Forms.ToolStripMenuItem Menucliente;
        private System.Windows.Forms.ToolStripMenuItem Menuusuários;
        private System.Windows.Forms.ToolStripMenuItem Menucargo;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenufluxoCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenulançarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuentradaSaída;
        private System.Windows.Forms.ToolStripMenuItem Menudespesas;
        private System.Windows.Forms.ToolStripMenuItem Menuproduto;
        private System.Windows.Forms.ToolStripMenuItem Menuvendas;
        private System.Windows.Forms.ToolStripMenuItem Menumovimrntos;
        private System.Windows.Forms.ToolStripMenuItem MenuentradasSaída;
    }
}

