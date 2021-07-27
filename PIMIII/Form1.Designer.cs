
namespace PIMIII
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cpf_gerenteLabel;
            System.Windows.Forms.Label hotel_bairroLabel;
            System.Windows.Forms.Label hotel_cidadeLabel;
            System.Windows.Forms.Label hotel_numerpoLabel;
            System.Windows.Forms.Label hotel_ruaLabel;
            System.Windows.Forms.Label hotel_telefoneLabel;
            System.Windows.Forms.Label hotel_ufLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.painelTela = new System.Windows.Forms.Panel();
            this.mtxtUf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRua = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCidade = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBairro = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.bntEnviar = new System.Windows.Forms.Button();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cpf_gerenteLabel = new System.Windows.Forms.Label();
            hotel_bairroLabel = new System.Windows.Forms.Label();
            hotel_cidadeLabel = new System.Windows.Forms.Label();
            hotel_numerpoLabel = new System.Windows.Forms.Label();
            hotel_ruaLabel = new System.Windows.Forms.Label();
            hotel_telefoneLabel = new System.Windows.Forms.Label();
            hotel_ufLabel = new System.Windows.Forms.Label();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.painelTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cpf_gerenteLabel
            // 
            cpf_gerenteLabel.AutoSize = true;
            cpf_gerenteLabel.Location = new System.Drawing.Point(18, 42);
            cpf_gerenteLabel.Name = "cpf_gerenteLabel";
            cpf_gerenteLabel.Size = new System.Drawing.Size(64, 13);
            cpf_gerenteLabel.TabIndex = 16;
            cpf_gerenteLabel.Text = "cpf gerente:";
            // 
            // hotel_bairroLabel
            // 
            hotel_bairroLabel.AutoSize = true;
            hotel_bairroLabel.Location = new System.Drawing.Point(18, 68);
            hotel_bairroLabel.Name = "hotel_bairroLabel";
            hotel_bairroLabel.Size = new System.Drawing.Size(62, 13);
            hotel_bairroLabel.TabIndex = 18;
            hotel_bairroLabel.Text = "hotel bairro:";
            // 
            // hotel_cidadeLabel
            // 
            hotel_cidadeLabel.AutoSize = true;
            hotel_cidadeLabel.Location = new System.Drawing.Point(18, 94);
            hotel_cidadeLabel.Name = "hotel_cidadeLabel";
            hotel_cidadeLabel.Size = new System.Drawing.Size(68, 13);
            hotel_cidadeLabel.TabIndex = 20;
            hotel_cidadeLabel.Text = "hotel cidade:";
            // 
            // hotel_numerpoLabel
            // 
            hotel_numerpoLabel.AutoSize = true;
            hotel_numerpoLabel.Location = new System.Drawing.Point(18, 125);
            hotel_numerpoLabel.Name = "hotel_numerpoLabel";
            hotel_numerpoLabel.Size = new System.Drawing.Size(71, 13);
            hotel_numerpoLabel.TabIndex = 24;
            hotel_numerpoLabel.Text = "hotel numero:";
            // 
            // hotel_ruaLabel
            // 
            hotel_ruaLabel.AutoSize = true;
            hotel_ruaLabel.Location = new System.Drawing.Point(18, 151);
            hotel_ruaLabel.Name = "hotel_ruaLabel";
            hotel_ruaLabel.Size = new System.Drawing.Size(51, 13);
            hotel_ruaLabel.TabIndex = 26;
            hotel_ruaLabel.Text = "hotel rua:";
            // 
            // hotel_telefoneLabel
            // 
            hotel_telefoneLabel.AutoSize = true;
            hotel_telefoneLabel.Location = new System.Drawing.Point(18, 177);
            hotel_telefoneLabel.Name = "hotel_telefoneLabel";
            hotel_telefoneLabel.Size = new System.Drawing.Size(74, 13);
            hotel_telefoneLabel.TabIndex = 28;
            hotel_telefoneLabel.Text = "hotel telefone:";
            // 
            // hotel_ufLabel
            // 
            hotel_ufLabel.AutoSize = true;
            hotel_ufLabel.Location = new System.Drawing.Point(18, 203);
            hotel_ufLabel.Name = "hotel_ufLabel";
            hotel_ufLabel.Size = new System.Drawing.Size(45, 13);
            hotel_ufLabel.TabIndex = 30;
            hotel_ufLabel.Text = "hotel uf:";
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.label2);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnSair);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.barraTitulo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(709, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastro de Hotel";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1241, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 24);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1210, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1241, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1272, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 24);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.btnMenu);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 35);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 615);
            this.menuVertical.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(3, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(214, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // painelTela
            // 
            this.painelTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.painelTela.Controls.Add(this.mtxtUf);
            this.painelTela.Controls.Add(this.mtxtTelefone);
            this.painelTela.Controls.Add(this.mtxtRua);
            this.painelTela.Controls.Add(this.mtxtNumero);
            this.painelTela.Controls.Add(this.mtxtCidade);
            this.painelTela.Controls.Add(this.mtxtBairro);
            this.painelTela.Controls.Add(this.mtxtCpf);
            this.painelTela.Controls.Add(cpf_gerenteLabel);
            this.painelTela.Controls.Add(hotel_bairroLabel);
            this.painelTela.Controls.Add(hotel_cidadeLabel);
            this.painelTela.Controls.Add(hotel_numerpoLabel);
            this.painelTela.Controls.Add(hotel_ruaLabel);
            this.painelTela.Controls.Add(hotel_telefoneLabel);
            this.painelTela.Controls.Add(hotel_ufLabel);
            this.painelTela.Controls.Add(this.bntEnviar);
            this.painelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelTela.Location = new System.Drawing.Point(220, 35);
            this.painelTela.Name = "painelTela";
            this.painelTela.Size = new System.Drawing.Size(1080, 615);
            this.painelTela.TabIndex = 2;
            // 
            // mtxtUf
            // 
            this.mtxtUf.Location = new System.Drawing.Point(101, 196);
            this.mtxtUf.Mask = "LL";
            this.mtxtUf.Name = "mtxtUf";
            this.mtxtUf.Size = new System.Drawing.Size(19, 20);
            this.mtxtUf.TabIndex = 37;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(101, 170);
            this.mtxtTelefone.Mask = "(00) 00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(88, 20);
            this.mtxtTelefone.TabIndex = 36;
            // 
            // mtxtRua
            // 
            this.mtxtRua.Location = new System.Drawing.Point(101, 144);
            this.mtxtRua.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtRua.Name = "mtxtRua";
            this.mtxtRua.Size = new System.Drawing.Size(249, 20);
            this.mtxtRua.TabIndex = 35;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(101, 118);
            this.mtxtNumero.Mask = "CCCC";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(32, 20);
            this.mtxtNumero.TabIndex = 34;
            // 
            // mtxtCidade
            // 
            this.mtxtCidade.Location = new System.Drawing.Point(101, 87);
            this.mtxtCidade.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtCidade.Name = "mtxtCidade";
            this.mtxtCidade.Size = new System.Drawing.Size(249, 20);
            this.mtxtCidade.TabIndex = 33;
            // 
            // mtxtBairro
            // 
            this.mtxtBairro.Location = new System.Drawing.Point(101, 61);
            this.mtxtBairro.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtBairro.Name = "mtxtBairro";
            this.mtxtBairro.Size = new System.Drawing.Size(249, 20);
            this.mtxtBairro.TabIndex = 32;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCpf.Location = new System.Drawing.Point(101, 35);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(88, 20);
            this.mtxtCpf.TabIndex = 31;
            this.mtxtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bntEnviar
            // 
            this.bntEnviar.Location = new System.Drawing.Point(299, 265);
            this.bntEnviar.Name = "bntEnviar";
            this.bntEnviar.Size = new System.Drawing.Size(82, 55);
            this.bntEnviar.TabIndex = 11;
            this.bntEnviar.Text = "Enviar";
            this.bntEnviar.UseVisualStyleBackColor = true;
            this.bntEnviar.Click += new System.EventHandler(this.bntEnviar_Click);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(PIMIII.Hotel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.painelTela);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.painelTela.ResumeLayout(false);
            this.painelTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel painelTela;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntEnviar;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.MaskedTextBox mtxtUf;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtRua;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.MaskedTextBox mtxtCidade;
        private System.Windows.Forms.MaskedTextBox mtxtBairro;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
    }
}

