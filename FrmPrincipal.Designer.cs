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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgBox1 = new System.Windows.Forms.PictureBox();
            this.ImgBox2 = new System.Windows.Forms.PictureBox();
            this.ImgBox3 = new System.Windows.Forms.PictureBox();
            this.ImgBox4 = new System.Windows.Forms.PictureBox();
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
            this.movimentaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
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
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatório";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // ImgBox1
            // 
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
            this.ImgBox3.Location = new System.Drawing.Point(416, 228);
            this.ImgBox3.Name = "ImgBox3";
            this.ImgBox3.Size = new System.Drawing.Size(251, 156);
            this.ImgBox3.TabIndex = 3;
            this.ImgBox3.TabStop = false;
            // 
            // ImgBox4
            // 
            this.ImgBox4.Location = new System.Drawing.Point(140, 228);
            this.ImgBox4.Name = "ImgBox4";
            this.ImgBox4.Size = new System.Drawing.Size(237, 156);
            this.ImgBox4.TabIndex = 4;
            this.ImgBox4.TabStop = false;
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
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImgBox1;
        private System.Windows.Forms.PictureBox ImgBox2;
        private System.Windows.Forms.PictureBox ImgBox3;
        private System.Windows.Forms.PictureBox ImgBox4;
    }
}

