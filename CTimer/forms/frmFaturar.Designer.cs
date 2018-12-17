namespace CTimer.forms
{
    partial class frmFaturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturar));
            this.gridTrabalhos = new System.Windows.Forms.DataGridView();
            this.lblIdTrabalho = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rdExibirTodos = new System.Windows.Forms.RadioButton();
            this.rdFaturados = new System.Windows.Forms.RadioButton();
            this.rdAbertos = new System.Windows.Forms.RadioButton();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.dataInicial = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.chkPorData = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblTotalDe = new System.Windows.Forms.Label();
            this.lblPrecoHora = new System.Windows.Forms.Label();
            this.txtIDFat = new CTimer.Controles.txtID();
            this.txtTotal = new CTimer.txtMoeda();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabalhos)).BeginInit();
            this.grpFiltro.SuspendLayout();
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
            this.gridTrabalhos.Location = new System.Drawing.Point(12, 161);
            this.gridTrabalhos.MultiSelect = false;
            this.gridTrabalhos.Name = "gridTrabalhos";
            this.gridTrabalhos.RowHeadersVisible = false;
            this.gridTrabalhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTrabalhos.Size = new System.Drawing.Size(776, 266);
            this.gridTrabalhos.TabIndex = 0;
            this.gridTrabalhos.SelectionChanged += new System.EventHandler(this.gridTrabalhos_SelectionChanged);
            this.gridTrabalhos.DoubleClick += new System.EventHandler(this.gridTrabalhos_DoubleClick);
            // 
            // lblIdTrabalho
            // 
            this.lblIdTrabalho.AutoSize = true;
            this.lblIdTrabalho.Location = new System.Drawing.Point(49, 53);
            this.lblIdTrabalho.Name = "lblIdTrabalho";
            this.lblIdTrabalho.Size = new System.Drawing.Size(18, 13);
            this.lblIdTrabalho.TabIndex = 1;
            this.lblIdTrabalho.Text = "ID";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(436, 94);
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
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.Location = new System.Drawing.Point(436, 17);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.AllowDrop = true;
            this.cboCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(132, 19);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(298, 21);
            this.cboCliente.TabIndex = 0;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(49, 73);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(16, 13);
            this.lblClienteID.TabIndex = 25;
            this.lblClienteID.Text = "...";
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
            // rdExibirTodos
            // 
            this.rdExibirTodos.AutoSize = true;
            this.rdExibirTodos.Location = new System.Drawing.Point(22, 28);
            this.rdExibirTodos.Name = "rdExibirTodos";
            this.rdExibirTodos.Size = new System.Drawing.Size(83, 17);
            this.rdExibirTodos.TabIndex = 27;
            this.rdExibirTodos.Text = "Exibir Todos";
            this.rdExibirTodos.UseVisualStyleBackColor = true;
            this.rdExibirTodos.Click += new System.EventHandler(this.rdExibirTodos_Click);
            // 
            // rdFaturados
            // 
            this.rdFaturados.AutoSize = true;
            this.rdFaturados.Location = new System.Drawing.Point(22, 50);
            this.rdFaturados.Name = "rdFaturados";
            this.rdFaturados.Size = new System.Drawing.Size(117, 17);
            this.rdFaturados.TabIndex = 28;
            this.rdFaturados.Text = "Somente Faturados";
            this.rdFaturados.UseVisualStyleBackColor = true;
            this.rdFaturados.Click += new System.EventHandler(this.rdFaturados_Click);
            // 
            // rdAbertos
            // 
            this.rdAbertos.AutoSize = true;
            this.rdAbertos.Location = new System.Drawing.Point(22, 72);
            this.rdAbertos.Name = "rdAbertos";
            this.rdAbertos.Size = new System.Drawing.Size(118, 17);
            this.rdAbertos.TabIndex = 30;
            this.rdAbertos.Text = "Somente em Aberto";
            this.rdAbertos.UseVisualStyleBackColor = true;
            this.rdAbertos.Click += new System.EventHandler(this.rdAbertos_Click);
            // 
            // grpFiltro
            // 
            this.grpFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltro.Controls.Add(this.rdFaturados);
            this.grpFiltro.Controls.Add(this.rdAbertos);
            this.grpFiltro.Controls.Add(this.rdExibirTodos);
            this.grpFiltro.Location = new System.Drawing.Point(626, 54);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(162, 101);
            this.grpFiltro.TabIndex = 31;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtrar Registros";
            // 
            // dataInicial
            // 
            this.dataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicial.Location = new System.Drawing.Point(522, 81);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(98, 20);
            this.dataInicial.TabIndex = 32;
            // 
            // dataFinal
            // 
            this.dataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(522, 126);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(98, 20);
            this.dataFinal.TabIndex = 33;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(522, 63);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(60, 13);
            this.lblDataInicial.TabIndex = 34;
            this.lblDataInicial.Text = "Data Inicial";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(522, 108);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lblDataFinal.TabIndex = 35;
            this.lblDataFinal.Text = "Data Final";
            // 
            // chkPorData
            // 
            this.chkPorData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPorData.AutoSize = true;
            this.chkPorData.Location = new System.Drawing.Point(648, 22);
            this.chkPorData.Name = "chkPorData";
            this.chkPorData.Size = new System.Drawing.Size(95, 17);
            this.chkPorData.TabIndex = 36;
            this.chkPorData.Text = "Filtrar por Data";
            this.chkPorData.UseVisualStyleBackColor = true;
            this.chkPorData.CheckStateChanged += new System.EventHandler(this.chkPorData_CheckStateChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(522, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 37;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(17, 127);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(109, 17);
            this.chkTodos.TabIndex = 38;
            this.chkTodos.Text = "Selecionar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnFaturar
            // 
            this.btnFaturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaturar.Location = new System.Drawing.Point(436, 123);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(75, 23);
            this.btnFaturar.TabIndex = 40;
            this.btnFaturar.Text = "Faturar";
            this.btnFaturar.UseVisualStyleBackColor = true;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(285, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 13);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total em Aberto:";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(169, 91);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(38, 13);
            this.lblTarefa.TabIndex = 23;
            this.lblTarefa.Text = "Tarefa";
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(169, 73);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(40, 13);
            this.lblProjeto.TabIndex = 22;
            this.lblProjeto.Text = "Projeto";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(277, 73);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(19, 13);
            this.lblMoeda.TabIndex = 44;
            this.lblMoeda.Text = "$$";
            this.lblMoeda.Visible = false;
            // 
            // lblTotalDe
            // 
            this.lblTotalDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDe.AutoSize = true;
            this.lblTotalDe.Location = new System.Drawing.Point(239, 101);
            this.lblTotalDe.Name = "lblTotalDe";
            this.lblTotalDe.Size = new System.Drawing.Size(42, 13);
            this.lblTotalDe.TabIndex = 45;
            this.lblTotalDe.Text = "total de";
            this.lblTotalDe.Visible = false;
            // 
            // lblPrecoHora
            // 
            this.lblPrecoHora.AutoSize = true;
            this.lblPrecoHora.Location = new System.Drawing.Point(361, 73);
            this.lblPrecoHora.Name = "lblPrecoHora";
            this.lblPrecoHora.Size = new System.Drawing.Size(42, 13);
            this.lblPrecoHora.TabIndex = 46;
            this.lblPrecoHora.Text = "$$Hora";
            this.lblPrecoHora.Visible = false;
            // 
            // txtIDFat
            // 
            this.txtIDFat.BackColor = System.Drawing.Color.LightGray;
            this.txtIDFat.Location = new System.Drawing.Point(52, 94);
            this.txtIDFat.Name = "txtIDFat";
            this.txtIDFat.Size = new System.Drawing.Size(49, 20);
            this.txtIDFat.TabIndex = 43;
            this.txtIDFat.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.LightGray;
            this.txtTotal.Location = new System.Drawing.Point(330, 96);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 41;
            this.txtTotal.Visible = false;
            // 
            // frmFaturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrecoHora);
            this.Controls.Add(this.lblTotalDe);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.txtIDFat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnFaturar);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.chkPorData);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicial);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblProjeto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblIdTrabalho);
            this.Controls.Add(this.gridTrabalhos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFaturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entradas de Trabalho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFaturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabalhos)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTrabalhos;
        private System.Windows.Forms.Label lblIdTrabalho;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton rdExibirTodos;
        private System.Windows.Forms.RadioButton rdFaturados;
        private System.Windows.Forms.RadioButton rdAbertos;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.DateTimePicker dataInicial;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.CheckBox chkPorData;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnFaturar;
        private txtMoeda txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblProjeto;
        private Controles.txtID txtIDFat;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblTotalDe;
        private System.Windows.Forms.Label lblPrecoHora;
    }
}