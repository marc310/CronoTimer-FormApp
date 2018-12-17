namespace CTimer.forms
{
    partial class frmAddProjetos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpProjetos = new System.Windows.Forms.GroupBox();
            this.cboClienteP = new System.Windows.Forms.ComboBox();
            this.txtDescricaoP = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.txtPrecoP = new CTimer.txtMoeda();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtID = new CTimer.Controles.txtID();
            this.txtNome = new CTimer.Controles.txtID();
            this.grpProjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProjetos
            // 
            this.grpProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProjetos.Controls.Add(this.cboClienteP);
            this.grpProjetos.Controls.Add(this.txtDescricaoP);
            this.grpProjetos.Controls.Add(this.txtNomeP);
            this.grpProjetos.Controls.Add(this.txtPrecoP);
            this.grpProjetos.Controls.Add(this.lblCliente);
            this.grpProjetos.Controls.Add(this.lblPreco);
            this.grpProjetos.Controls.Add(this.lblDescricao);
            this.grpProjetos.Controls.Add(this.lblNome);
            this.grpProjetos.Location = new System.Drawing.Point(12, 33);
            this.grpProjetos.Name = "grpProjetos";
            this.grpProjetos.Size = new System.Drawing.Size(332, 175);
            this.grpProjetos.TabIndex = 0;
            this.grpProjetos.TabStop = false;
            this.grpProjetos.Text = "Dados do Projeto";
            // 
            // cboClienteP
            // 
            this.cboClienteP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboClienteP.FormattingEnabled = true;
            this.cboClienteP.Location = new System.Drawing.Point(126, 122);
            this.cboClienteP.Name = "cboClienteP";
            this.cboClienteP.Size = new System.Drawing.Size(186, 21);
            this.cboClienteP.TabIndex = 9;
            this.cboClienteP.SelectedIndexChanged += new System.EventHandler(this.cboClienteP_SelectedIndexChanged);
            // 
            // txtDescricaoP
            // 
            this.txtDescricaoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoP.Location = new System.Drawing.Point(126, 70);
            this.txtDescricaoP.Name = "txtDescricaoP";
            this.txtDescricaoP.Size = new System.Drawing.Size(186, 20);
            this.txtDescricaoP.TabIndex = 8;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeP.Location = new System.Drawing.Point(126, 44);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(186, 20);
            this.txtNomeP.TabIndex = 7;
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoP.BackColor = System.Drawing.Color.LightGray;
            this.txtPrecoP.Location = new System.Drawing.Point(126, 96);
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.Size = new System.Drawing.Size(186, 20);
            this.txtPrecoP.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 125);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(19, 99);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(89, 13);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço por Projeto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(19, 73);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Projeto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(249, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.Location = new System.Drawing.Point(34, 215);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(117, 20);
            this.txtID.TabIndex = 15;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightGray;
            this.txtNome.Location = new System.Drawing.Point(34, 242);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.Visible = false;
            // 
            // frmAddProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 274);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpProjetos);
            this.MinimumSize = new System.Drawing.Size(370, 300);
            this.Name = "frmAddProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Novos Projetos";
            this.Load += new System.EventHandler(this.frmAddProjetos_Load);
            this.grpProjetos.ResumeLayout(false);
            this.grpProjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProjetos;
        private System.Windows.Forms.TextBox txtDescricaoP;
        private System.Windows.Forms.TextBox txtNomeP;
        private txtMoeda txtPrecoP;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboClienteP;
        private System.Windows.Forms.Button btnSalvar;
        private Controles.txtID txtID;
        private Controles.txtID txtNome;
    }
}