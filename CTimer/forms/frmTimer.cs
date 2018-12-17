using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CodeX;

namespace CTimer.forms
{
	public partial class frmTimer : Form
	{
        public frmTimer()
        {
            InitializeComponent();
            
        }
        //*********************************************************************************************************//
        public frmTimer(int idTrabalho)
        {
            InitializeComponent();
            LoadCleanCBO();
            btnIniciar.Text = "Continuar";
            btnSalvar.Visible = false;
            txtIDTrabalho.Text = Convert.ToString(idTrabalho);
            //
            ReloadDadosTimer();
            atualizaHoraIn();
            atualizaHoraFin();
            somaHoras();
            // verifica se o item pode ser alterado
            if (txtItemFaturado.Text == "True")
            {
                btnEditar.Visible = false;
                btnIniciar.Text = "Item Faturado";
            }
            else if (txtItemFaturado.Text == "False")
            {
                btnEditar.Visible = true;
            }
        }
        //
        //***********************************************************//
        private void frmTimer_Load(object sender, EventArgs e)
        {
            carregaProjetos();
            if (txtIDTrabalho.Text==string.Empty)
            {
                LoadCleanCBO();
                txtCliente.Text = "";
                txtPrecoH.Text = "";
                lblPrecoHora.Text = "Preço por Hora:";
                lblTotalHoras.Text = "Aguardando Início.";
                limpaDados();
                btnSalvar.Visible = false;
                btnEditar.Visible = false;
                desabilitaCampos();
                cboProjetos.Enabled = true;
                lblHoras.Visible = false;
            }
            else
            {
                desabilitaCampos();
                atualizaHorasEnt();
                loadTimer();
            }
            /* Minimizando aplicação na bandeja do windows */
            //this.Visible = true;
            //this.ShowInTaskbar = false;
            ////this.WindowState = FormWindowState.Minimized;
            //notifyTimer.Visible = true;
            ////
            //TimerAberto();
        }
        //*********************************************************************************************************//
        //
        private void loadTimer()
        {
            lblTempo.Visible = false;
            lblHoras.Visible = true;
            //faz a verificação pra encontrar o valor correto
            var tempo = txtHoras.Text;
            //converte valor de hora pra int pra fazer verificação
            var h = tempo.Replace(":", "");
            int hora = Convert.ToInt32(h.Replace(".", ""));
            //MessageBox.Show("o valor de horas é " + hora);
            if (hora<235959)
            {
                //hora menor que 23:59:59 entao adiciona 00:
                var t = Convert.ToString(tempo);
                lblHoras.Text = "00:" + t;
            }
            else
            {
                //o tempo deu mais de 1 dia
                var t = Convert.ToString(tempo);
                lblHoras.Text = t;
            }
        }
        private void LoadCleanCBO()
        {
            carregaTarefas();
            carregaCboProj();
            cboProjetos.Text = "[ Selecione ]";
            cboTarefas.Text = "[ Selecione ]";
        }
        //
        private void limpaDados()
        {
            txtIDTrabalho.Text = "";
            txtProjetoID.Text = "";
            txtTarefaID.Text = "";
            txtInicio.Text = "";
            txtFinal.Text = "";
            txtHoras.Text = "";
            //
        }
        private void desabilitaCampos()
        {
            cboProjetos.Enabled = false;
            cboTarefas.Enabled = false;
            txtNota.Enabled = false;
            txtInicio.Enabled = false;
            txtFinal.Enabled = false;
            txthoraInicio.Enabled = false;
            txtHoraFinal.Enabled = false;
            txtDataInicio.Enabled = false;
            txtDataFinal.Enabled = false;
        }
        private void habilitaCampos()
        {
            cboProjetos.Enabled = true;
            cboTarefas.Enabled = true;
            txtNota.Enabled = true;
            txtInicio.Enabled = true;
            txtFinal.Enabled = true;
            txtDataInicio.Enabled = true;
            txtDataFinal.Enabled = true;
        }
        private void carregaCboProj() // CARREGA COMBOBOX PROJETOS
        {
            cboProjetos.DataSource = Projetos.carregaProjetos();
            cboProjetos.ValueMember = "idProj";
            cboProjetos.DisplayMember = "nomeProj";
        }
        //
        private void carregaProjetos() // CARREGA DETALHES DOS PROJETOS
        {
            var data = from projetos in Projetos.listaProjetos()
                       orderby projetos.nomeProj
                       select new
                       {
                           idProj = projetos.idProj,
                           nomeProj = projetos.nomeProj,
                           descricaoProj = projetos.descricaoProj,
                           precoProj = projetos.precoProj,
                           clienteID = projetos.clienteID
                       };
        }
        //
        private void carregaTarefas() // CARREGA COMBOBOX TAREFAS
        {
            cboTarefas.DataSource = Tarefas.carregaTarefas();
            cboTarefas.ValueMember = "idTar";
            cboTarefas.DisplayMember = "nomeTar";
        }
        //
        //*********************************************************************************************************//
        // LOAD & RELOAD
        // CARREGA DADOS DO TIMER 
        // BUSCA NO BANCO REFERENTE AO ID DO TRABALHO
        private void ReloadDadosTimer()
        {
            // ID TRABALHO ATUAL SELECIONADO
            int idTrampo = Convert.ToInt32(txtIDTrabalho.Text);
            //
            var trampos = iTrabalho.porTrabalhoID(idTrampo);
            var trampo = trampos[0];
            // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
            int idT = trampo.idTrabalho;
            int pID = trampo.projetoID;
            int tID = trampo.tarefas;
            var nt = trampo.nota;
            var dt = trampo.data;
            dt.ToShortTimeString();
            var dtF = trampo.dataF;

            var IDFI = trampo.idFaturaItem;
            var iF = trampo.faturado;
            
            var ini = trampo.inicio;
            var fin = trampo.final;
            //
            txtIDTrabalho.Text = Convert.ToString(idT);
            txtProjetoID.Text = Convert.ToString(pID);
            txtTarefaID.Text = Convert.ToString(tID);
            txtNota.Text = nt;
            txtDataInicio.Text = dt.ToString("dd/MM/yyyy");
            txtDataFinal.Text = dtF.ToString("dd/MM/yyyy");
            txtInicio.Text = ini;
            txtFinal.Text = fin;
            txtIDFaturaItem.Text = Convert.ToString(IDFI);
            txtItemFaturado.Text = Convert.ToString(iF);
            //
            cboProjetos.SelectedValue = pID;
            cboTarefas.SelectedValue = tID;
        }
        //
        //*********************************************************************************************************//
        /// <summary>
        /// atualiza hora de inicio baseado no txtInicio
        /// </summary>
        private void atualizaHoraIn()
        {
            try
            {
                DateTime data = Convert.ToDateTime(txtDataInicio.Text);
                //
                string[] hora = txtInicio.Text.Split(':');
                data = data.AddHours(Convert.ToDouble(hora[0]));
                data = data.AddMinutes(Convert.ToDouble(hora[1]));
                data = data.AddSeconds(Convert.ToDouble(hora[2]));
                data.ToString("yyyy/MM/dd HH:mm:ss");
                var da = Convert.ToDateTime(data);
                // escreve data formatada no campo hora inicio
                txthoraInicio.Text = Convert.ToString(da);
            }
            catch
            {
            }
        }
        //
        /// <summary>
        /// atualiza hora de inicio baseado no txtInicio
        /// </summary>
        private void atualizaHoraFin()
        {
            try
            {
                DateTime data = Convert.ToDateTime(txtDataFinal.Text);
                //
                string[] hora = txtFinal.Text.Split(':');
                data = data.AddHours(Convert.ToDouble(hora[0]));
                data = data.AddMinutes(Convert.ToDouble(hora[1]));
                data = data.AddSeconds(Convert.ToDouble(hora[2]));
                data.ToString("yyyy/MM/dd HH:mm:ss");
                var da = Convert.ToDateTime(data);
                // escreve data formatada no campo hora inicio
                txtHoraFinal.Text = Convert.ToString(da);
            }
            catch
            {
            }
        }
        //*********************************************************************************************************//
        //
        Stopwatch cronometro = new Stopwatch();
        int vezParcial = 0;
        //
        //*********************************************************//
        // INICIAR TRACKING TIME
        //*********************************************************//
        private void btnIniciar_Click(object sender, EventArgs e)
		{
            notifyTimer.Visible = true;
            // verifica se o item pode ser alterado
            if (txtItemFaturado.Text == "True")
            {
               //n faz nada
            }
            else
            {
            lblTotalHoras.Text = "Contabilizando Horas...";
            //procede ação caso o item nao esteja faturado
            //verifica opções e starta o cronometro
            if (btnIniciar.Text=="Continuar")
            {
                lblHoras.Visible = false;
                lblTempo.Visible = true;
                if (btnEditar.Visible == true)
                {
                    btnEditar.Visible = false;
                }
                txtIDTrabalho.Text = "";
                txtNota.Text = "";
                txtInicio.Text = "";
                txtFinal.Text = "";
                txtHoras.Text = "";
                habilitaCampos();
                //zerar o cronometro
                cronometro.Reset();
                //zerar as variaveis
                tbParcial.Text = null;
                vezParcial = 0;
            }
            //***************************//
            // pega HORA ATUAL
            TimeSpan agora = DateTime.Now.TimeOfDay;
            //***************************//
            txtInicio.Text = Convert.ToString(agora);
            //
            DateTime data = DateTime.Today.Date;
            //
            string[] hora = txtInicio.Text.Split(':');
            data = data.AddHours(Convert.ToDouble(hora[0]));
            data = data.AddMinutes(Convert.ToDouble(hora[1]));
            data = data.AddSeconds(Convert.ToDouble(hora[2]));
            data.ToString("yyyy/MM/dd HH:mm:ss");
            var da = Convert.ToDateTime(data);
            //***************************//
            txthoraInicio.Text = Convert.ToString(da);
            //***************************//
            //seta como nulo o item inicial
            txtItemFaturado.Text = "False";
            txtIDFaturaItem.Text = "0";
            //iniciar o cronometro
            cronometro.Start();
			//desativar botão iniciar e ativar os de parada
			btnParcial.Enabled = true;
			btnParar.Enabled = true;
			btnIniciar.Enabled = false;
            }
        }

		private void btnParar_Click(object sender, EventArgs e)
		{
            if (txtProjetoID.Text == "")
            {
                MessageBox.Show("Você precisa selecionar o Projeto.");
            }
            else if (txtTarefaID.Text == "")
            {
                MessageBox.Show("Você precisa selecionar a Tarefa.");
            }
            else
            {
                //***************************//
                // pega HORA ATUAL pra escrever o final
                TimeSpan agora = DateTime.Now.TimeOfDay;
                //***************************//
                txtFinal.Text = Convert.ToString(agora);
                //
                DateTime data = DateTime.Today.Date;
                //
                string[] hora = txtFinal.Text.Split(':');
                data = data.AddHours(Convert.ToDouble(hora[0]));
                data = data.AddMinutes(Convert.ToDouble(hora[1]));
                data = data.AddSeconds(Convert.ToDouble(hora[2]));
                data.ToString("yyyy/MM/dd HH:mm:ss");
                var da = Convert.ToDateTime(data);
                //***************************//
                txtHoraFinal.Text = Convert.ToString(da);
                // hora certa
                //TimeSpan agora = DateTime.Now.TimeOfDay;
                txtFinal.Text = Convert.ToString(agora);
                //***************************//
                somaHoras();
                //para o cronômetro
                cronometro.Stop();

                //desativar botões de paradas e ativar o de início
                desabilitaCampos();
                btnParcial.Enabled = false;
                btnParar.Enabled = false;
                btnIniciar.Enabled = true;
                // # Inicia verificação para Salvar
                if(txtIDTrabalho.Text=="")
                {
                    Salvar();
                    // RETORNA ID SALVO
                    var idRetorno = iTrabalho.retornaID();
                    var trampo = idRetorno[0];
                    var idRetornado = trampo.idTrabalho;
                    txtIDTrabalho.Text = Convert.ToString(idRetornado);
                }
                else
                {
                Salvar();
                }
                btnIniciar.Text = "Continuar";
                btnEditar.Visible = true;
                // apos salvar vamos verificar se é um novo registro
            }
            loadTimer();
            notifyTimer.Visible = false;
		}

		private void btnParcial_Click(object sender, EventArgs e)
		{
			vezParcial++;
			//jogar parcial no textbox e pular uma linha
			tbParcial.Text += vezParcial + "- " + lblTempo.Text + Environment.NewLine;
			//ir para a última linha do textbox
			tbParcial.SelectionStart = tbParcial.TextLength;
			tbParcial.ScrollToCaret();
		}

		private void tmrCronometro_Tick(object sender, EventArgs e)
		{			
			lblTempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", cronometro.Elapsed.Hours, cronometro.Elapsed.Minutes, cronometro.Elapsed.Seconds, cronometro.Elapsed.Milliseconds/10);
		}

        private void cboProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            rastDadosProj();
            if(txtNota.Enabled==false)
            {
                habilitaCampos();
            }
        }
        //
        //*********************************************************************************************************//
        // CARREGA RASTREAMENTO DE DADOS DO PROJETOS
        // carrega dados da tabela projetos pro cbo
        // dados referentes ao id do item selecionado do cbo
        /// <summary>
        /// Carrega Projetos e rastreia Cliente pelo Projeto
        /// </summary>
        private void rastDadosProj()
        {
            try
            {
                //*************************************************//
                //CARREGA PROJETOS
                var i = (Projetos)cboProjetos.SelectedItem;

                var p = new Projetos();
                p.idProj = i.idProj;
                p.clienteID = i.clienteID;
                //
                var idp = p.idProj;
                var cp = p.clienteID;
                //
                //*************************************************//
                // CARREGA DADOS DO CLIENTE
                // lazy load
                // dados referente ao projeto selecionado
                var projetos = Projetos.porClienteID(cp);
                //
                var projeto = projetos[0];
                var nomeCliente = projeto.Cliente.nome;
                var clientePreco = projeto.Cliente.precoHora;
                //
                txtCliente.Text = nomeCliente;
                txtPrecoH.Text = Convert.ToString(clientePreco);
                //
                //
                // CARREGA MOEDA PELO CLIENTE SELECIONADO
                int idCli = Convert.ToInt32(cp);
                //
                var cli = Clientes.porClienteID(idCli);
                var c = cli[0];
                // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
                var mCl = c.Moeda.simbolo;
                lblMoeda.Text = mCl;
                lblPrecoHora.Text = "Preço por Hora: " + mCl + txtPrecoH.Text;
                //
                txtProjetoID.Text = Convert.ToString(idp);
                // END
            }
            catch
            {
                
            }
        }

        //
        //*************************************************//
        // CARREGA E SELECIONA TAREFAS
        /// <summary>
        /// Carrega Tarefas na combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var st = (Tarefas)cboTarefas.SelectedItem;
            //
            var t = new Tarefas();
            var idT = st.idTar;
            var nT = st.nomeTar;
            //
            txtTarefaID.Text = Convert.ToString(idT);
            //
        }

        //
        //********************************************************//
        //INSTANCIA NOVA ENTRADA PRA FUNÇÃO SALVAR
        //string data = String.Format("{0:yyyy/MM/dd}", DataSaida); //Parametro que converte 
        /// <summary>
        /// Comando Salvar
        /// </summary>
        private void Salvar()
        {
            somaHoras();
            var trampo = new iTrabalho();
            if (txtIDTrabalho.Text == "")
            {
                txtIDTrabalho.Text = "0";
            }
            //trata valor rendimento pra ser inserido inteiro
            //var rendimento = txtRendimento.Text.Replace("R$ ", "");
            var rendimento = txtRendimento.Text;
            //
            trampo.idTrabalho = Convert.ToInt32(txtIDTrabalho.Text);
            trampo.projetoID = Convert.ToInt32(txtProjetoID.Text);
            trampo.tarefas = Convert.ToInt32(txtTarefaID.Text);
            trampo.nota = txtNota.Text;
            trampo.data = Convert.ToDateTime(txthoraInicio.Text);
            trampo.dataF = Convert.ToDateTime(txtHoraFinal.Text);
            trampo.inicio = txtInicio.Text;
            trampo.final = txtFinal.Text;
            trampo.horas = txtHoras.Text;
            trampo.horaInt = txtHoraInt.Text;
            trampo.moeda = lblMoeda.Text;
            trampo.rendimento = rendimento;
            trampo.idFaturaItem = Convert.ToInt32(txtIDFaturaItem.Text);
            trampo.faturado = Convert.ToBoolean(txtItemFaturado.Text);
            //
            trampo.Salvar();
            try
            {
                // ajustar este try, MOTIVO: SOMENTE 1 ATUALIZA, QUE É O PRIMEIRO ITEM...
                ((frmFaturar)this.Owner).Pesquisar();
            }
            catch 
            {
                // SE ESTE ITEM FICA AQUI, ELE GERA UM ERRO NO TIMER SEM O FORM FATURAR ABERTO.
                // PQ TENTA EM CIMA E TENTA AQUI
            }
            notifyTimer.ShowBalloonTip(10, "CodeX Timer","Seu contador salvou uma nova entrada com sucesso.", ToolTipIcon.None);
            //MessageBox.Show("Salvo com Sucesso!");
            //this.Hide();
        }

        /// <summary>
        /// Cálculo de horas baseada nas entradas do usuário
        /// </summary>
        private void somaHoras()
        {
            try
            {
                //calcula dados de entrada preenchidos pelo usuario
                TimeSpan tempo = Convert.ToDateTime(txtHoraFinal.Text) - Convert.ToDateTime(txthoraInicio.Text);
                txtHoras.Text = Convert.ToString(tempo);
                //converte dados
                var hI = Convert.ToString(tempo);
                double horas = TimeSpan.Parse(hI).TotalHours;
                decimal h = Convert.ToDecimal(horas);
                decimal pH = Convert.ToDecimal(txtPrecoH.Text);
                //preenche os dados convertidos pra calcular
                decimal horaInt = decimal.Round(h, 2);
                txtHoraInt.Text = horaInt.ToString();
                //calcula dados convertidos
                decimal rendimento = decimal.Round(h * pH, 2);
                txtRendimento.Text = rendimento.ToString();
                // PASSA VALORES PARA AS LABELS
                // SOMENTE EXIBE
                lblPrecoHora.Text = "Preço por Hora: " + lblMoeda.Text + " " + txtPrecoH.Text;
                //lblTotal.Text = "Rendimento Total: " + lblMoeda.Text + " " + txtRendimento.Text;
                lblTotalHoras.Text = "Horas Trabalhadas: " 
                    + txtHoras.Text + "\nConversão para Inteiro: [ " + txtHoraInt.Text + " Horas ]"
                    + "\n\nRendimento Total: " 
                    + lblMoeda.Text + " " + txtRendimento.Text;
            }
            catch
            {
            }
        }

        private void frmTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            string projetoID = txtProjetoID.Text;
            string tarefaID = txtTarefaID.Text;
            if(btnIniciar.Enabled==true)
            {
                // faz nada, só fecha..
            }
            else
            {
            if (CloseCancel() == false)
                {
                // confirma saida
                e.Cancel = true;
                };
            }

            if (Application.OpenForms.OfType<Dashboard>().Count() > 0)
            {
                Application.OpenForms["Dashboard"].BringToFront();
                Application.OpenForms["Dashboard"].Visible = true;
                Application.OpenForms["Dashboard"].WindowState = FormWindowState.Maximized;
                //MessageBox.Show("O Timer já está aberto!");
            }


        }

        public static bool CloseCancel()
        {
            const string message = "Você tem certeza que deseja Sair? Isso ira Cancelar o Registro!";
            const string caption = "Cancelar Registro de Trabalho";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            atualizaHoraFin();
            atualizaHoraIn();
            somaHoras();
            Salvar();
            loadTimer();
            desabilitaCampos();
            btnSalvar.Visible = false;
            btnIniciar.Enabled = true;
            btnEditar.Text = "Editar";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(btnSalvar.Visible==false)
            {
                habilitaCampos();
                btnSalvar.Visible = true;
                btnIniciar.Enabled = false;
                btnEditar.Text = "Cancelar";
            }
            else
            {
                ReloadDadosTimer();
                desabilitaCampos();
                btnSalvar.Visible = false;
                btnIniciar.Enabled = true;
                btnEditar.Text = "Editar";
            }
        }

        //private void notifyTimer_Click(object sender, EventArgs e)
        //{
        //    /* Exibindo novamente o programa */
        //    this.Visible = true;
        //    this.WindowState = FormWindowState.Normal;
        //    this.ShowInTaskbar = false;
        //    notifyTimer.Visible = false;
        //    notifyTimer.Text = "CodeX Timer";
        //    notifyTimer.BalloonTipTitle = this.Text;
        //}

        //private void frmTimer_Resize(object sender, EventArgs e)
        //{
        //    //if (this.WindowState == FormWindowState.Minimized)
        //    //{
        //    //    this.Visible = true;
        //    //    this.ShowInTaskbar = false;
        //    //    this.WindowState = FormWindowState.Minimized;
        //    //    notifyTimer.Visible = false;
        //    //    //notifyTimer.ShowBalloonTip(10, "CodeX Timer", "Seu Contador de tempo está em execução.", ToolTipIcon.None);
        //    //}
        //}

        /// <summary>
        /// Exibe Mensagem de Sistema dizendo q está aberto.
        /// </summary>
        public void TimerAberto()
        {
            //verifica se o item é novo e exibe a mensagem (se o item for = "")
            if(txtIDTrabalho.Text=="")
            {
                notifyTimer.ShowBalloonTip(10, "Codex Timer", "Seu Contador de Tempo está em execução,\nSeja Bem Vindo e Bom Trabalho.", ToolTipIcon.None);
            }
        }

        /// <summary>
        /// Atualiza Calculo de Horas baseadas nas entradas selecionadas
        /// </summary>
        public void atualizaHorasEnt()
        {
            atualizaHoraIn();
            atualizaHoraFin();
            somaHoras();
        }

        private void txtInicio_Leave(object sender, EventArgs e)
        {
            atualizaHoraIn();
            somaHoras();
        }
        
        private void txtFinal_Leave(object sender, EventArgs e)
        {
            atualizaHoraFin();
            somaHoras();
        }

        private void txtDataInicio_ValueChanged(object sender, EventArgs e)
        {
            atualizaHoraIn();
            somaHoras();
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            atualizaHoraFin();
            somaHoras();
        }
    }
}