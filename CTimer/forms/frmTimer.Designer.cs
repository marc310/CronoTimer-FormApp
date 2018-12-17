namespace CTimer.forms
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParcial = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.tbParcial = new System.Windows.Forms.TextBox();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.cboProjetos = new System.Windows.Forms.ComboBox();
            this.cboTarefas = new System.Windows.Forms.ComboBox();
            this.lblProjetos = new System.Windows.Forms.Label();
            this.lblTarefa = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIDTrabalho = new System.Windows.Forms.Label();
            this.lblProjetoID = new System.Windows.Forms.Label();
            this.lblTarefaID = new System.Windows.Forms.Label();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblHorasConvertidas = new System.Windows.Forms.Label();
            this.lblPrecoHora = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHoraFinal = new CTimer.Controles.txtBITelefone();
            this.txthoraInicio = new CTimer.Controles.txtBITelefone();
            this.txtFinal = new CTimer.Controles.txtBITelefone();
            this.txtInicio = new CTimer.Controles.txtBITelefone();
            this.txtNota = new CTimer.Controles.txtBInput();
            this.txtHoras = new CTimer.Controles.txtID();
            this.txtTarefaID = new CTimer.Controles.txtID();
            this.txtProjetoID = new CTimer.Controles.txtID();
            this.txtIDTrabalho = new CTimer.Controles.txtID();
            this.txtCliente = new CTimer.Controles.txtBInput();
            this.txtPrecoH = new CTimer.Controles.txtID();
            this.txtHoraInt = new CTimer.Controles.txtID();
            this.txtRendimento = new CTimer.Controles.txtID();
            this.txtIDFaturaItem = new CTimer.Controles.txtID();
            this.txtItemFaturado = new CTimer.Controles.txtID();
            this.notifyTimer = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblMoeda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(22, 110);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(216, 42);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "00:00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(12, 167);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(242, 58);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParcial
            // 
            this.btnParcial.Enabled = false;
            this.btnParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcial.Location = new System.Drawing.Point(10, 231);
            this.btnParcial.Name = "btnParcial";
            this.btnParcial.Size = new System.Drawing.Size(119, 58);
            this.btnParcial.TabIndex = 2;
            this.btnParcial.Text = "Parcial";
            this.btnParcial.UseVisualStyleBackColor = true;
            this.btnParcial.Click += new System.EventHandler(this.btnParcial_Click);
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(135, 231);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(119, 58);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // tbParcial
            // 
            this.tbParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParcial.Location = new System.Drawing.Point(468, 12);
            this.tbParcial.Multiline = true;
            this.tbParcial.Name = "tbParcial";
            this.tbParcial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParcial.Size = new System.Drawing.Size(226, 277);
            this.tbParcial.TabIndex = 4;
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Enabled = true;
            this.tmrCronometro.Interval = 1;
            this.tmrCronometro.Tick += new System.EventHandler(this.tmrCronometro_Tick);
            // 
            // cboProjetos
            // 
            this.cboProjetos.FormattingEnabled = true;
            this.cboProjetos.Location = new System.Drawing.Point(75, 41);
            this.cboProjetos.Name = "cboProjetos";
            this.cboProjetos.Size = new System.Drawing.Size(163, 21);
            this.cboProjetos.TabIndex = 1;
            this.cboProjetos.Text = "[ Selecione ]";
            this.cboProjetos.SelectedIndexChanged += new System.EventHandler(this.cboProjetos_SelectedIndexChanged);
            // 
            // cboTarefas
            // 
            this.cboTarefas.FormattingEnabled = true;
            this.cboTarefas.Location = new System.Drawing.Point(75, 69);
            this.cboTarefas.Name = "cboTarefas";
            this.cboTarefas.Size = new System.Drawing.Size(163, 21);
            this.cboTarefas.TabIndex = 2;
            this.cboTarefas.Text = "[ Selecione ]";
            this.cboTarefas.SelectedIndexChanged += new System.EventHandler(this.cboTarefas_SelectedIndexChanged);
            // 
            // lblProjetos
            // 
            this.lblProjetos.AutoSize = true;
            this.lblProjetos.Location = new System.Drawing.Point(26, 44);
            this.lblProjetos.Name = "lblProjetos";
            this.lblProjetos.Size = new System.Drawing.Size(43, 13);
            this.lblProjetos.TabIndex = 5;
            this.lblProjetos.Text = "Projeto:";
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Location = new System.Drawing.Point(26, 72);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(41, 13);
            this.lblTarefa.TabIndex = 6;
            this.lblTarefa.Text = "Tarefa:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(26, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblIDTrabalho
            // 
            this.lblIDTrabalho.AutoSize = true;
            this.lblIDTrabalho.Location = new System.Drawing.Point(492, 15);
            this.lblIDTrabalho.Name = "lblIDTrabalho";
            this.lblIDTrabalho.Size = new System.Drawing.Size(78, 13);
            this.lblIDTrabalho.TabIndex = 18;
            this.lblIDTrabalho.Text = "ID do Registro:";
            this.lblIDTrabalho.Visible = false;
            // 
            // lblProjetoID
            // 
            this.lblProjetoID.AutoSize = true;
            this.lblProjetoID.Location = new System.Drawing.Point(492, 44);
            this.lblProjetoID.Name = "lblProjetoID";
            this.lblProjetoID.Size = new System.Drawing.Size(72, 13);
            this.lblProjetoID.TabIndex = 19;
            this.lblProjetoID.Text = "ID do Projeto:";
            this.lblProjetoID.Visible = false;
            // 
            // lblTarefaID
            // 
            this.lblTarefaID.AutoSize = true;
            this.lblTarefaID.Location = new System.Drawing.Point(492, 67);
            this.lblTarefaID.Name = "lblTarefaID";
            this.lblTarefaID.Size = new System.Drawing.Size(70, 13);
            this.lblTarefaID.TabIndex = 20;
            this.lblTarefaID.Text = "ID da Tarefa:";
            this.lblTarefaID.Visible = false;
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Location = new System.Drawing.Point(265, 117);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(116, 13);
            this.lblTotalHoras.TabIndex = 21;
            this.lblTotalHoras.Text = "Contabilizando Horas...";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(266, 205);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(37, 13);
            this.lblInicio.TabIndex = 22;
            this.lblInicio.Text = "Início:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(266, 231);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(32, 13);
            this.lblFinal.TabIndex = 23;
            this.lblFinal.Text = "Final:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(386, 266);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(305, 266);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(22, 110);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(216, 42);
            this.lblHoras.TabIndex = 30;
            this.lblHoras.Text = "00:00:00:00";
            this.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.txtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicio.Location = new System.Drawing.Point(366, 202);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(96, 20);
            this.txtDataInicio.TabIndex = 34;
            this.txtDataInicio.ValueChanged += new System.EventHandler(this.txtDataInicio_ValueChanged);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(366, 228);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(96, 20);
            this.txtDataFinal.TabIndex = 35;
            this.txtDataFinal.ValueChanged += new System.EventHandler(this.txtDataFinal_ValueChanged);
            // 
            // lblHorasConvertidas
            // 
            this.lblHorasConvertidas.AutoSize = true;
            this.lblHorasConvertidas.Location = new System.Drawing.Point(488, 183);
            this.lblHorasConvertidas.Name = "lblHorasConvertidas";
            this.lblHorasConvertidas.Size = new System.Drawing.Size(94, 13);
            this.lblHorasConvertidas.TabIndex = 38;
            this.lblHorasConvertidas.Text = "Tempo Convertido";
            this.lblHorasConvertidas.Visible = false;
            // 
            // lblPrecoHora
            // 
            this.lblPrecoHora.AutoSize = true;
            this.lblPrecoHora.Location = new System.Drawing.Point(265, 92);
            this.lblPrecoHora.Name = "lblPrecoHora";
            this.lblPrecoHora.Size = new System.Drawing.Size(82, 13);
            this.lblPrecoHora.TabIndex = 39;
            this.lblPrecoHora.Text = "Preço por Hora:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(265, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Rendimento:";
            this.lblTotal.Visible = false;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.BackColor = System.Drawing.Color.LightGray;
            this.txtHoraFinal.Location = new System.Drawing.Point(562, 142);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(127, 20);
            this.txtHoraFinal.TabIndex = 37;
            this.txtHoraFinal.Visible = false;
            // 
            // txthoraInicio
            // 
            this.txthoraInicio.BackColor = System.Drawing.Color.LightGray;
            this.txthoraInicio.Location = new System.Drawing.Point(562, 116);
            this.txthoraInicio.Name = "txthoraInicio";
            this.txthoraInicio.Size = new System.Drawing.Size(127, 20);
            this.txthoraInicio.TabIndex = 36;
            this.txthoraInicio.Visible = false;
            // 
            // txtFinal
            // 
            this.txtFinal.BackColor = System.Drawing.Color.LightGray;
            this.txtFinal.Location = new System.Drawing.Point(305, 228);
            this.txtFinal.Mask = "00:00:00";
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(60, 20);
            this.txtFinal.TabIndex = 26;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.ValidatingType = typeof(System.DateTime);
            this.txtFinal.Leave += new System.EventHandler(this.txtFinal_Leave);
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.Color.LightGray;
            this.txtInicio.Location = new System.Drawing.Point(305, 202);
            this.txtInicio.Mask = "00:00:00";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(60, 20);
            this.txtInicio.TabIndex = 25;
            this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicio.Leave += new System.EventHandler(this.txtInicio_Leave);
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.LightGray;
            this.txtNota.Location = new System.Drawing.Point(265, 12);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(197, 72);
            this.txtNota.TabIndex = 14;
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.Color.LightGray;
            this.txtHoras.Location = new System.Drawing.Point(366, 113);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(96, 20);
            this.txtHoras.TabIndex = 13;
            this.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoras.Visible = false;
            // 
            // txtTarefaID
            // 
            this.txtTarefaID.BackColor = System.Drawing.Color.LightGray;
            this.txtTarefaID.Location = new System.Drawing.Point(589, 64);
            this.txtTarefaID.Name = "txtTarefaID";
            this.txtTarefaID.Size = new System.Drawing.Size(100, 20);
            this.txtTarefaID.TabIndex = 12;
            this.txtTarefaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarefaID.Visible = false;
            // 
            // txtProjetoID
            // 
            this.txtProjetoID.BackColor = System.Drawing.Color.LightGray;
            this.txtProjetoID.Location = new System.Drawing.Point(589, 37);
            this.txtProjetoID.Name = "txtProjetoID";
            this.txtProjetoID.Size = new System.Drawing.Size(100, 20);
            this.txtProjetoID.TabIndex = 11;
            this.txtProjetoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProjetoID.Visible = false;
            // 
            // txtIDTrabalho
            // 
            this.txtIDTrabalho.BackColor = System.Drawing.Color.LightGray;
            this.txtIDTrabalho.Location = new System.Drawing.Point(589, 12);
            this.txtIDTrabalho.Name = "txtIDTrabalho";
            this.txtIDTrabalho.Size = new System.Drawing.Size(100, 20);
            this.txtIDTrabalho.TabIndex = 10;
            this.txtIDTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDTrabalho.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.LightGray;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(75, 14);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(163, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // txtPrecoH
            // 
            this.txtPrecoH.BackColor = System.Drawing.Color.LightGray;
            this.txtPrecoH.Location = new System.Drawing.Point(366, 88);
            this.txtPrecoH.Name = "txtPrecoH";
            this.txtPrecoH.Size = new System.Drawing.Size(96, 20);
            this.txtPrecoH.TabIndex = 33;
            this.txtPrecoH.Visible = false;
            // 
            // txtHoraInt
            // 
            this.txtHoraInt.BackColor = System.Drawing.Color.LightGray;
            this.txtHoraInt.Location = new System.Drawing.Point(589, 179);
            this.txtHoraInt.Name = "txtHoraInt";
            this.txtHoraInt.Size = new System.Drawing.Size(96, 20);
            this.txtHoraInt.TabIndex = 31;
            this.txtHoraInt.Visible = false;
            // 
            // txtRendimento
            // 
            this.txtRendimento.BackColor = System.Drawing.Color.LightGray;
            this.txtRendimento.Location = new System.Drawing.Point(366, 165);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(96, 20);
            this.txtRendimento.TabIndex = 32;
            this.txtRendimento.Visible = false;
            // 
            // txtIDFaturaItem
            // 
            this.txtIDFaturaItem.BackColor = System.Drawing.Color.LightGray;
            this.txtIDFaturaItem.Location = new System.Drawing.Point(597, 90);
            this.txtIDFaturaItem.Name = "txtIDFaturaItem";
            this.txtIDFaturaItem.Size = new System.Drawing.Size(37, 20);
            this.txtIDFaturaItem.TabIndex = 41;
            this.txtIDFaturaItem.Visible = false;
            // 
            // txtItemFaturado
            // 
            this.txtItemFaturado.BackColor = System.Drawing.Color.LightGray;
            this.txtItemFaturado.Location = new System.Drawing.Point(652, 90);
            this.txtItemFaturado.Name = "txtItemFaturado";
            this.txtItemFaturado.Size = new System.Drawing.Size(37, 20);
            this.txtItemFaturado.TabIndex = 42;
            this.txtItemFaturado.Visible = false;
            // 
            // notifyTimer
            // 
            this.notifyTimer.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTimer.Icon")));
            this.notifyTimer.Text = "CodeX Timer";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(266, 182);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(80, 13);
            this.lblMoeda.TabIndex = 44;
            this.lblMoeda.Text = "Simbolo Moeda";
            this.lblMoeda.Visible = false;
            // 
            // frmTimer
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 297);
            this.Controls.Add(this.lblHorasConvertidas);
            this.Controls.Add(this.txtHoraInt);
            this.Controls.Add(this.lblPrecoHora);
            this.Controls.Add(this.txtPrecoH);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.txtItemFaturado);
            this.Controls.Add(this.txtIDFaturaItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.txtHoraFinal);
            this.Controls.Add(this.txthoraInicio);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTotalHoras);
            this.Controls.Add(this.lblTarefaID);
            this.Controls.Add(this.lblProjetoID);
            this.Controls.Add(this.lblIDTrabalho);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtTarefaID);
            this.Controls.Add(this.txtProjetoID);
            this.Controls.Add(this.txtIDTrabalho);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTarefa);
            this.Controls.Add(this.lblProjetos);
            this.Controls.Add(this.cboTarefas);
            this.Controls.Add(this.cboProjetos);
            this.Controls.Add(this.tbParcial);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnParcial);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtRendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronômetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimer_FormClosing);
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParcial;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.TextBox tbParcial;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.ComboBox cboProjetos;
        private System.Windows.Forms.ComboBox cboTarefas;
        private System.Windows.Forms.Label lblProjetos;
        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.Label lblCliente;
        private Controles.txtBInput txtCliente;
        private Controles.txtID txtIDTrabalho;
        private Controles.txtID txtProjetoID;
        private Controles.txtID txtTarefaID;
        private Controles.txtID txtHoras;
        private Controles.txtBInput txtNota;
        private System.Windows.Forms.Label lblIDTrabalho;
        private System.Windows.Forms.Label lblProjetoID;
        private System.Windows.Forms.Label lblTarefaID;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private Controles.txtBITelefone txtInicio;
        private Controles.txtBITelefone txtFinal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblHoras;
        private Controles.txtID txtHoraInt;
        private Controles.txtID txtPrecoH;
        private System.Windows.Forms.DateTimePicker txtDataInicio;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private Controles.txtBITelefone txthoraInicio;
        private Controles.txtBITelefone txtHoraFinal;
        private System.Windows.Forms.Label lblHorasConvertidas;
        private System.Windows.Forms.Label lblPrecoHora;
        private System.Windows.Forms.Label lblTotal;
        private Controles.txtID txtRendimento;
        private Controles.txtID txtIDFaturaItem;
        private Controles.txtID txtItemFaturado;
        private System.Windows.Forms.NotifyIcon notifyTimer;
        private System.Windows.Forms.Label lblMoeda;
    }
}

