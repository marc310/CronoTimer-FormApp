namespace CTimer.forms
{
    partial class frmFatura
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
            this.gridTrabalhos = new System.Windows.Forms.DataGridView();
            this.lblIdTrabalho = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbxOpen = new System.Windows.Forms.CheckBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblPrecoHora = new System.Windows.Forms.Label();
            this.imgQr = new System.Windows.Forms.PictureBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtTotal = new CTimer.Controles.txtID();
            this.txtIDFat = new CTimer.Controles.txtID();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabalhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTrabalhos
            // 
            this.gridTrabalhos.AllowUserToAddRows = false;
            this.gridTrabalhos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTrabalhos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTrabalhos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTrabalhos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridTrabalhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrabalhos.Location = new System.Drawing.Point(12, 139);
            this.gridTrabalhos.MultiSelect = false;
            this.gridTrabalhos.Name = "gridTrabalhos";
            this.gridTrabalhos.RowHeadersVisible = false;
            this.gridTrabalhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTrabalhos.Size = new System.Drawing.Size(776, 288);
            this.gridTrabalhos.TabIndex = 0;
            this.gridTrabalhos.SelectionChanged += new System.EventHandler(this.gridTrabalhos_SelectionChanged);
            this.gridTrabalhos.DoubleClick += new System.EventHandler(this.gridTrabalhos_DoubleClick);
            // 
            // lblIdTrabalho
            // 
            this.lblIdTrabalho.AutoSize = true;
            this.lblIdTrabalho.Location = new System.Drawing.Point(49, 43);
            this.lblIdTrabalho.Name = "lblIdTrabalho";
            this.lblIdTrabalho.Size = new System.Drawing.Size(63, 13);
            this.lblIdTrabalho.TabIndex = 1;
            this.lblIdTrabalho.Text = "ID Trabalho";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(701, 23);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(49, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "Cliente";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(49, 63);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(53, 13);
            this.lblClienteID.TabIndex = 25;
            this.lblClienteID.Text = "Cliente ID";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 427);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 11);
            this.progressBar.TabIndex = 26;
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(253, 36);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(98, 20);
            this.txtDataEmissao.TabIndex = 32;
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVencimento.Location = new System.Drawing.Point(378, 36);
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(98, 20);
            this.txtDataVencimento.TabIndex = 33;
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(253, 18);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(90, 13);
            this.lblDataEmissao.TabIndex = 34;
            this.lblDataEmissao.Text = "Data de Emissão:";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(378, 18);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataVencimento.TabIndex = 35;
            this.lblDataVencimento.Text = "Data de Vencimento:";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(54, 120);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(109, 17);
            this.chkTodos.TabIndex = 38;
            this.chkTodos.Text = "Selecionar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(600, 116);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 13);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total da Fatura:";
            // 
            // cbxOpen
            // 
            this.cbxOpen.AutoSize = true;
            this.cbxOpen.BackColor = System.Drawing.Color.Transparent;
            this.cbxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOpen.ForeColor = System.Drawing.Color.Black;
            this.cbxOpen.Location = new System.Drawing.Point(253, 120);
            this.cbxOpen.Name = "cbxOpen";
            this.cbxOpen.Size = new System.Drawing.Size(106, 17);
            this.cbxOpen.TabIndex = 46;
            this.cbxOpen.Text = "Abrir após Salvar";
            this.cbxOpen.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(253, 81);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 30);
            this.btnExportar.TabIndex = 45;
            this.btnExportar.Text = "Export to Pdf";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblPrecoHora
            // 
            this.lblPrecoHora.AutoSize = true;
            this.lblPrecoHora.Location = new System.Drawing.Point(51, 83);
            this.lblPrecoHora.Name = "lblPrecoHora";
            this.lblPrecoHora.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoHora.TabIndex = 47;
            this.lblPrecoHora.Text = "Preço por Hora";
            // 
            // imgQr
            // 
            this.imgQr.Location = new System.Drawing.Point(491, 12);
            this.imgQr.Name = "imgQr";
            this.imgQr.Size = new System.Drawing.Size(200, 200);
            this.imgQr.TabIndex = 48;
            this.imgQr.TabStop = false;
            this.imgQr.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(376, 81);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(109, 30);
            this.btnQuitar.TabIndex = 49;
            this.btnQuitar.Text = "Quitar Fatura";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(667, 63);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(109, 13);
            this.lblPago.TabIndex = 50;
            this.lblPago.Text = "Status de Pagamento";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(198, 63);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(19, 13);
            this.lblMoeda.TabIndex = 51;
            this.lblMoeda.Text = "$$";
            this.lblMoeda.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.LightGray;
            this.txtTotal.Location = new System.Drawing.Point(688, 88);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.Visible = false;
            // 
            // txtIDFat
            // 
            this.txtIDFat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDFat.BackColor = System.Drawing.Color.LightGray;
            this.txtIDFat.Location = new System.Drawing.Point(646, 26);
            this.txtIDFat.Name = "txtIDFat";
            this.txtIDFat.Size = new System.Drawing.Size(49, 20);
            this.txtIDFat.TabIndex = 43;
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblPrecoHora);
            this.Controls.Add(this.cbxOpen);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIDFat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtDataVencimento);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblIdTrabalho);
            this.Controls.Add(this.gridTrabalhos);
            this.Controls.Add(this.imgQr);
            this.Name = "frmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabalhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTrabalhos;
        private System.Windows.Forms.Label lblIdTrabalho;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.DateTimePicker txtDataVencimento;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblTotal;
        private Controles.txtID txtIDFat;
        private Controles.txtID txtTotal;
        private System.Windows.Forms.CheckBox cbxOpen;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblPrecoHora;
        private System.Windows.Forms.PictureBox imgQr;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblMoeda;
    }
}