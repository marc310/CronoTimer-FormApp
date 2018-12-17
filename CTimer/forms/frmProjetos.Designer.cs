namespace CTimer.forms
{
    partial class frmProjetos
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
            this.grpDadosClientes = new System.Windows.Forms.GroupBox();
            this.txtPrecoProj = new CTimer.txtMoeda();
            this.txtDescricaoProj = new CTimer.Controles.txtBInput();
            this.txtNomeProj = new CTimer.Controles.txtBInput();
            this.txtIDProj = new CTimer.Controles.txtID();
            this.lblPrecoProj = new System.Windows.Forms.Label();
            this.lblDescricaoProj = new System.Windows.Forms.Label();
            this.lblNomeProj = new System.Windows.Forms.Label();
            this.txtIDCli = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dataGridProjetos = new System.Windows.Forms.DataGridView();
            this.grpSelecionarCli = new System.Windows.Forms.GroupBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grpDadosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjetos)).BeginInit();
            this.grpSelecionarCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosClientes
            // 
            this.grpDadosClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosClientes.Controls.Add(this.txtPrecoProj);
            this.grpDadosClientes.Controls.Add(this.txtDescricaoProj);
            this.grpDadosClientes.Controls.Add(this.txtNomeProj);
            this.grpDadosClientes.Controls.Add(this.txtIDProj);
            this.grpDadosClientes.Controls.Add(this.lblPrecoProj);
            this.grpDadosClientes.Controls.Add(this.lblDescricaoProj);
            this.grpDadosClientes.Controls.Add(this.lblNomeProj);
            this.grpDadosClientes.Controls.Add(this.txtIDCli);
            this.grpDadosClientes.Controls.Add(this.lblPreco);
            this.grpDadosClientes.Controls.Add(this.lblEmail);
            this.grpDadosClientes.Controls.Add(this.lblNome);
            this.grpDadosClientes.Location = new System.Drawing.Point(12, 73);
            this.grpDadosClientes.Name = "grpDadosClientes";
            this.grpDadosClientes.Size = new System.Drawing.Size(578, 119);
            this.grpDadosClientes.TabIndex = 9;
            this.grpDadosClientes.TabStop = false;
            this.grpDadosClientes.Text = "Dados do Cliente";
            // 
            // txtPrecoProj
            // 
            this.txtPrecoProj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoProj.BackColor = System.Drawing.Color.LightGray;
            this.txtPrecoProj.Location = new System.Drawing.Point(437, 73);
            this.txtPrecoProj.Name = "txtPrecoProj";
            this.txtPrecoProj.Size = new System.Drawing.Size(135, 20);
            this.txtPrecoProj.TabIndex = 23;
            this.txtPrecoProj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoProj_KeyPress);
            // 
            // txtDescricaoProj
            // 
            this.txtDescricaoProj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoProj.BackColor = System.Drawing.Color.LightGray;
            this.txtDescricaoProj.Location = new System.Drawing.Point(437, 49);
            this.txtDescricaoProj.Name = "txtDescricaoProj";
            this.txtDescricaoProj.Size = new System.Drawing.Size(135, 20);
            this.txtDescricaoProj.TabIndex = 22;
            this.txtDescricaoProj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricaoProj_KeyPress);
            // 
            // txtNomeProj
            // 
            this.txtNomeProj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProj.BackColor = System.Drawing.Color.LightGray;
            this.txtNomeProj.Location = new System.Drawing.Point(437, 25);
            this.txtNomeProj.Name = "txtNomeProj";
            this.txtNomeProj.Size = new System.Drawing.Size(135, 20);
            this.txtNomeProj.TabIndex = 21;
            this.txtNomeProj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProj_KeyPress);
            // 
            // txtIDProj
            // 
            this.txtIDProj.BackColor = System.Drawing.Color.LightGray;
            this.txtIDProj.Location = new System.Drawing.Point(304, 93);
            this.txtIDProj.Name = "txtIDProj";
            this.txtIDProj.Size = new System.Drawing.Size(49, 20);
            this.txtIDProj.TabIndex = 20;
            this.txtIDProj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDProj.Visible = false;
            // 
            // lblPrecoProj
            // 
            this.lblPrecoProj.AutoSize = true;
            this.lblPrecoProj.Location = new System.Drawing.Point(337, 77);
            this.lblPrecoProj.Name = "lblPrecoProj";
            this.lblPrecoProj.Size = new System.Drawing.Size(89, 13);
            this.lblPrecoProj.TabIndex = 19;
            this.lblPrecoProj.Text = "Preço do Projeto:";
            // 
            // lblDescricaoProj
            // 
            this.lblDescricaoProj.AutoSize = true;
            this.lblDescricaoProj.Location = new System.Drawing.Point(337, 53);
            this.lblDescricaoProj.Name = "lblDescricaoProj";
            this.lblDescricaoProj.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoProj.TabIndex = 18;
            this.lblDescricaoProj.Text = "Descrição:";
            // 
            // lblNomeProj
            // 
            this.lblNomeProj.AutoSize = true;
            this.lblNomeProj.Location = new System.Drawing.Point(337, 29);
            this.lblNomeProj.Name = "lblNomeProj";
            this.lblNomeProj.Size = new System.Drawing.Size(89, 13);
            this.lblNomeProj.TabIndex = 17;
            this.lblNomeProj.Text = "Nome do Projeto:";
            // 
            // txtIDCli
            // 
            this.txtIDCli.Location = new System.Drawing.Point(0, 99);
            this.txtIDCli.Name = "txtIDCli";
            this.txtIDCli.Size = new System.Drawing.Size(47, 20);
            this.txtIDCli.TabIndex = 16;
            this.txtIDCli.Visible = false;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(84, 77);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(82, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preco por Hora:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(84, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(88, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome do Cliente:";
            // 
            // dataGridProjetos
            // 
            this.dataGridProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjetos.Location = new System.Drawing.Point(12, 198);
            this.dataGridProjetos.MultiSelect = false;
            this.dataGridProjetos.Name = "dataGridProjetos";
            this.dataGridProjetos.RowHeadersVisible = false;
            this.dataGridProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProjetos.Size = new System.Drawing.Size(680, 231);
            this.dataGridProjetos.TabIndex = 15;
            this.dataGridProjetos.SelectionChanged += new System.EventHandler(this.dataGridProjetos_SelectionChanged);
            // 
            // grpSelecionarCli
            // 
            this.grpSelecionarCli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelecionarCli.Controls.Add(this.btnTodos);
            this.grpSelecionarCli.Controls.Add(this.cboCliente);
            this.grpSelecionarCli.Location = new System.Drawing.Point(12, 14);
            this.grpSelecionarCli.Name = "grpSelecionarCli";
            this.grpSelecionarCli.Size = new System.Drawing.Size(680, 48);
            this.grpSelecionarCli.TabIndex = 11;
            this.grpSelecionarCli.TabStop = false;
            this.grpSelecionarCli.Text = "Selecione o Cliente";
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.Location = new System.Drawing.Point(584, 18);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(87, 19);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(450, 21);
            this.cboCliente.TabIndex = 0;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(596, 120);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleta.Location = new System.Drawing.Point(596, 144);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(75, 23);
            this.btnDeleta.TabIndex = 20;
            this.btnDeleta.Text = "Excluir";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(596, 96);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grpSelecionarCli);
            this.Controls.Add(this.dataGridProjetos);
            this.Controls.Add(this.grpDadosClientes);
            this.Name = "frmProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Projetos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProjetos_Load);
            this.grpDadosClientes.ResumeLayout(false);
            this.grpDadosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjetos)).EndInit();
            this.grpSelecionarCli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosClientes;
        private System.Windows.Forms.DataGridView dataGridProjetos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpSelecionarCli;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtIDCli;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label lblPrecoProj;
        private System.Windows.Forms.Label lblDescricaoProj;
        private System.Windows.Forms.Label lblNomeProj;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnNovo;
        private Controles.txtBInput txtDescricaoProj;
        private Controles.txtBInput txtNomeProj;
        private Controles.txtID txtIDProj;
        private txtMoeda txtPrecoProj;
    }
}

