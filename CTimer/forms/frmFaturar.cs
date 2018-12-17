using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeX;

namespace CTimer.forms
{
    public partial class frmFaturar : Form
    {
        public frmFaturar()
        {
            InitializeComponent();
            carregaGrid();
        }

        private void frmFaturar_Load(object sender, EventArgs e)
        {
            unCheckRadio();
            desabilitaTotal();
            desabilitaData();
            LoadProgBar();
            //lblClienteID.Visible = false;
            lblTarefa.Visible = false;
            lblProjeto.Visible = false;
            gridTrabalhos.Visible = false;
            btnExcluir.Visible = false;
            btnFaturar.Visible = false;
            this.progressBar.Visible = false;
            carregaCli();
            //carregaGridTrabalhos();
            WindowState = FormWindowState.Maximized;
            cboCliente.Text = "[ Selecione ]";
        }
        //
        //
        //***********************************************************//
        // #
        /// <summary>
        /// Verifica se o Gridview está visivel
        /// </summary>
        private void verificaGridVisivel()
        {
            if (gridTrabalhos.Visible == false)
            {
                gridTrabalhos.Visible = true;
                btnExcluir.Visible = true;
                btnFaturar.Visible = true;
                habilitaTotal();
            }
        }

        /// <summary>
        /// Carrega CBO Clientes
        /// </summary>
        private void carregaCli()
        {
            cboCliente.DataSource = Clientes.carregaClientes();
            cboCliente.ValueMember = "clienteID";
            cboCliente.DisplayMember = "nome";
        }

        //*******************************************************************************************************//
        // CARREGA CONFIGURAÇÕES DO GRID
        /// <summary>
        /// Configura GridView
        /// </summary>
        private void carregaGrid()
        {
            try
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 25;
                checkBoxColumn.Name = "checkBoxColumn";
                gridTrabalhos.Columns.Insert(0, checkBoxColumn);

                DataGridViewColumn coluna1 = gridTrabalhos.Columns[1];
                DataGridViewColumn coluna2 = gridTrabalhos.Columns[2];
                DataGridViewColumn coluna3 = gridTrabalhos.Columns[3];
                DataGridViewColumn coluna4 = gridTrabalhos.Columns[4];
                DataGridViewColumn coluna5 = gridTrabalhos.Columns[5];
                DataGridViewColumn coluna6 = gridTrabalhos.Columns[6];
                DataGridViewColumn coluna7 = gridTrabalhos.Columns[7];
                DataGridViewColumn coluna8 = gridTrabalhos.Columns[8];
                DataGridViewColumn coluna9 = gridTrabalhos.Columns[9];
                //***********************************************************//
                coluna1.HeaderText = "ID";
                coluna1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna2.HeaderText = "Projeto";
                coluna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna3.HeaderText = "Tarefa";
                coluna3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna4.HeaderText = "Nota";

                coluna5.HeaderText = "Data";
                coluna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                coluna5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                coluna6.HeaderText = "Início";
                coluna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna7.HeaderText = "Final";
                coluna7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna8.HeaderText = "Moeda";
                coluna8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna9.HeaderText = "Faturado";
                coluna9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch
            {
            }
        }
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DO GRID
        public void carregaGridTrabalhos()
        {
            //carregaGrid();
            rastDados();
        }
        //
        //*******************************************************************************************************//
        // GRIDS DE CARREGAMENTO
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS DE TRABALHO NO GERAL
        private void carregaEntradas()
        {
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.listaTrabalhos()
                           //where clientes.nome == txtBusca.Text
                           //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //nomeCliente = itenstrabalho.Projetos.Cliente.nome,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        // **            **             **
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE E ABERTOS
        private void rastEntradasAbertosPorCliente()
        {
            LoadProgBar();
            var cliID = Convert.ToInt32(lblClienteID.Text);
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.listaTrabalhos()
                           where itenstrabalho.Projetos.clienteID == cliID
                           where itenstrabalho.faturado==false
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE E FATURADOS
        private void rastEntradasFaturadoPorCliente()
        {
            LoadProgBar();
            var cliID = Convert.ToInt32(lblClienteID.Text);
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.listaTrabalhos()
                       where itenstrabalho.Projetos.clienteID == cliID
                       where itenstrabalho.faturado == true
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE
        private void rastEntradasPorCliente()
        {
            var cliID = Convert.ToInt32(lblClienteID.Text);
            var data = from itenstrabalho in iTrabalho.listaTrabalhos()
                       where itenstrabalho.Projetos.clienteID == cliID
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // **            **             **
        //
        // CONSULTAS ENTRE DATAS COMEÇA AQUI
        //
        // **            **             **
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE E ABERTOS ENTRE DATAS
        private void rastEntradasAbertosPorClienteEntD()
        {
            LoadProgBar();
            // salva e converte valor da data na variavel
            DateTime dataInicio = Convert.ToDateTime(dataInicial.Text);
            DateTime dataFim = Convert.ToDateTime(dataFinal.Text);
            //
            var cliID = Convert.ToInt32(lblClienteID.Text);
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.consTrabalhosEntreDatas(dataInicio,dataFim)
                       where itenstrabalho.Projetos.clienteID == cliID && itenstrabalho.faturado == false
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE E FATURADOS ENTRE DATAS
        private void rastEntradasFaturadoPorClienteEntD()
        {
            LoadProgBar();
            // salva e converte valor da data na variavel
            DateTime dataInicio = Convert.ToDateTime(dataInicial.Text);
            DateTime dataFim = Convert.ToDateTime(dataFinal.Text);
            //
            var cliID = Convert.ToInt32(lblClienteID.Text);
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.consTrabalhosEntreDatas(dataInicio, dataFim)
                       where itenstrabalho.Projetos.clienteID == cliID && itenstrabalho.faturado == true
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS PELO ID DO CLIENTE ENTRE DATAS
        private void rastEntradasPorClienteEntD()
        {
            LoadProgBar();
            // salva e converte valor da data na variavel
            DateTime dataInicio = Convert.ToDateTime(dataInicial.Text);
            DateTime dataFim = Convert.ToDateTime(dataFinal.Text);
            //
            var cliID = Convert.ToInt32(lblClienteID.Text);
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from itenstrabalho in iTrabalho.consTrabalhosEntreDatas(dataInicio,dataFim)
                       where itenstrabalho.Projetos.clienteID == cliID
                       //join projetos in iTrabalho.listaTrabalhos on itenstrabalho.projetoID equals projetos.idProj
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //idCliente = itenstrabalho.Projetos.clienteID,
                           nomeProj = itenstrabalho.Projetos.nomeProj,
                           //tarefas = itenstrabalho.tarefas,
                           nomeTar = itenstrabalho.Tarefas.nomeTar,
                           nota = itenstrabalho.nota,
                           Data = itenstrabalho.data,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           horasInt = itenstrabalho.horaInt,
                           moeda = itenstrabalho.moeda,
                           rendimento = itenstrabalho.rendimento,
                           faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,

                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            Soma();
        }
        //
        //*******************************************************************************************************//
        // **            **             **
        //
        //  FIM DAS CONSULTAS
        //
        // **            **             **
        //*******************************************************************************************************//
        //
        private void LoadProgBar()
        {
            var gridTotalR = gridTrabalhos.Rows.Count;
            progressBar.Maximum = gridTotalR;
            //progressBar.Step = 1;
            progressBar.Minimum = 1;
            //
            this.progressBar.Visible = true;
            for (int i = 0; i < gridTotalR; i++)
            {
                System.Threading.Thread.Sleep(100);
                progressBar.PerformStep();
            }
            chkTodos.Checked = false;
            
            //
            //for (var r = 1; r <= gridTotalR-1; r++)
            //{
            //    //progressBar.Value = r + 1;
            //    //progressBar.PerformStep();
            //    //var linha = gridTotalR[r];
            //    progressBar.Value = (r + 1);
            //    progressBar.Update();
            //}
        }
        //
        //*******************************************************************************************************//
        // FUNÇÃO DOUBLE CLICK DO GRID VIEW
        //*******************************************************************************************************//
        private void gridTrabalhos_DoubleClick(object sender, EventArgs e)
        {
            int idT = Convert.ToInt32(lblIdTrabalho.Text);
            //int pID = Convert.ToInt32(lblIDProjeto.Text);
            //int tID = Convert.ToInt32(lblTarefa.Text);
            //var nt = lblNota.Text;
            //var dt = lblData.Text;
            //var ini = lblInicio.Text;
            //var fin = lblFinal.Text;
            frmTimer Timer = new frmTimer(idT);
            Timer.Owner = this;
            Timer.Show();
        }
        //
        //*********************************************************//
        // LOAD DADOS AO SELECIONAR UM REGISTRO NO GRID
        private void gridTrabalhos_SelectionChanged(object sender, EventArgs e)
        {
            rastDadosTrabalho();
            //
            
        }
        //*******************************************************************************************************//
        // RASTREIA DADOS SELECIONADOS NO GRIDVIEW
        public void rastDadosTrabalho()
        {
            //CARREGA PROJETOS
            var t = new iTrabalho();
            t.idTrabalho = Convert.ToInt32(gridTrabalhos.CurrentRow.Cells[1].Value);
            //
            var idT = t.idTrabalho;
            var pID = t.projetoID;
            var tID = t.tarefas;
            var nTar = t.Tarefas.nomeTar;
            var nProj = t.Projetos.nomeProj;
            //
            //*************************************************//
            // INICIA VERIFICAÇÃO PRA PREENCHER OS DADOS
            //
            lblIdTrabalho.Text = Convert.ToString(idT);
            lblProjeto.Text = Convert.ToString(nProj);
            lblTarefa.Text = Convert.ToString(nTar);
            //lblInicio.Text = Convert.ToString(ini);
            //lblFinal.Text = Convert.ToString(fin);
            //lblNota.Text = Convert.ToString(nt);
            //
            //
        }
        //
        //***********************************************************//
        //                   FUNÇÃO EXCLUIR                          //
        //***********************************************************//
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //
            List<DataGridViewRow> Selecionados = (from row in gridTrabalhos.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells[0].Value) == true
                                                  select row).ToList();
            //
            if (Selecionados.Count > 0)
            {
                if (MessageBox.Show(string.Format("Tem Certeza que Deseja Deletar {0} Registro(s)?", Selecionados.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in Selecionados)
                    {
                        var id = row.Cells[1].Value;
                        var t = new iTrabalho();
                        t.Deleta(Convert.ToInt32(id));
                        //TESTE DE FUNCIONAMENTO
                        //MessageBox.Show(id + "Selecionado"); 
                    }
                    rastDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione os Registros que deseja Excluir.");
            }
                //var idTr = Convert.ToString(gridTrabalhos.CurrentRow.Cells[0].Value);
                //if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar a entrada " + idTr + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                //{
                //    var i = new iTrabalho();
                //    i.idTrabalho = Convert.ToInt32(gridTrabalhos.CurrentRow.Cells[0].Value);
                //    var id = i.idTrabalho;
                //    i.Deleta(id);
                //    MessageBox.Show("Registro Excluído com Sucesso!");
                //    carregaGridTrabalhos();
                //}
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //rastDados();
            //verificaGridVisivel();
        }
        //
        //
        //***********************************************************//
        // RASTREA DADOS PELA SELEÇÃO E DIRECIONA PRA FUNÇÃO CORRETA //
        //***********************************************************//
        private void rastDados()
        {
            var i = (Clientes)cboCliente.SelectedItem;

            //
            // CARREGA MOEDA PELO CLIENTE SELECIONADO
            int idCli = Convert.ToInt32(i.clienteID);
            lblClienteID.Text = Convert.ToString(idCli);
            // cria instancia e carrega a moeda do cliente
            var cli = Clientes.porClienteID(idCli);
            var c = cli[0];
            // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
            var mCl = c.Moeda.simbolo;
            var pHora = c.precoHora;
            lblPrecoHora.Text = Convert.ToString(pHora);
            lblMoeda.Text = mCl;
            //lblPrecoHora.Text = "Preço por Hora: " + mCl;
            //lblEmail.Text = "E-mail: " + i.email;
            //lblPreco.Text = "Preço por Hora: " + preco;
            //carregaProj();
            //grpDadosClientes.Visible = true;
            if(cboCliente.Text=="[ Selecione ]")
            {
                lblClienteID.Text = "Nenhum Cliente Selecionado.";
                rdExibirTodos.Checked = true;
                //listaTodos();
            }
            if (rdFaturados.Checked==true)
            {
                if(chkPorData.Checked==true)
                {
                    // consulta entre datas
                    rastEntradasFaturadoPorClienteEntD();
                }
                else if (chkPorData.Checked == false)
                {
                // consulta normal
                rastEntradasFaturadoPorCliente();
                }
            }
            else if(rdAbertos.Checked==true)
            {
                // consulta com status de abertos
                if(chkPorData.Checked==true)
                {
                    rastEntradasAbertosPorClienteEntD(); // por data
                }
                else if (chkPorData.Checked == false)
                {
                rastEntradasAbertosPorCliente(); // consulta normal
                }
            }
            else
            {
                if(chkPorData.Checked==true)
                {
                    // consulta entre datas somente pelo cliente
                    rastEntradasPorClienteEntD();
                }
                else if (chkPorData.Checked == false)
                {
                    if (cboCliente.Text == "[ Selecione ]")
                    {
                        listaTodos();
                    }
                    else
                    {
                    // consulta normal
                    rastEntradasPorCliente();
                    }
                }
                rdExibirTodos.Checked = true;
            }
            chkTodos.Checked = false;
            this.progressBar.Visible = false;
        }
        //
        //
        //***********************************************************//
        // #
        private void unCheckRadio()
        {
            rdExibirTodos.Checked = false;
            rdFaturados.Checked = false;
            rdAbertos.Checked = true;
        }
        //
        private void alertaClienteSelecione()
        {
            if (cboCliente.Text == "[ Selecione ]")
            {
                MessageBox.Show("Selecione o Cliente para Filtrar");
                unCheckRadio();
            }
            else
            {
                rastDados();
            }
        }
        //
        //***********************************************************//
        // #
        private void btnTodos_Click(object sender, EventArgs e)
        {
            listaTodos();
        }
        //
        public void listaTodos()
        {
            verificaGridVisivel();
            carregaEntradas();
            cboCliente.Text = "[ Selecione ]";
            unCheckRadio();
            rdExibirTodos.Checked = true;
            btnFaturar.Enabled = false;
        }
        //
        private void rdExibirTodos_Click(object sender, EventArgs e)
        {
            //btnFaturar.Text = "Faturar";
            //btnFaturar.Enabled = false;
            //alertaClienteSelecione();
        }

        private void rdFaturados_Click(object sender, EventArgs e)
        {
            //btnFaturar.Text = "Cancelar Fatura";
            //btnFaturar.Enabled = true;
            //alertaClienteSelecione();
        }

        private void rdAbertos_Click(object sender, EventArgs e)
        {
            //btnFaturar.Text = "Faturar";
            //btnFaturar.Enabled = true;
            //alertaClienteSelecione();
        }
        //
        //***********************************************************//
        // #
        private void chkPorData_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPorData.Checked == true)
            {
                habilitaData();
            }
            else if (chkPorData.Checked == false)
            {
                desabilitaData();
            }
        }
        //
        //***********************************************************//
        // #
        private void habilitaData()
        {
            lblDataInicial.Enabled = true;
            lblDataFinal.Enabled = true;
            lblDataInicial.Visible = true;
            lblDataFinal.Visible = true;
            dataInicial.Enabled = true;
            dataFinal.Enabled = true;
            dataInicial.Visible = true;
            dataFinal.Visible = true;
        }
        //
        private void desabilitaData()
        {
            lblDataInicial.Enabled = false;
            lblDataFinal.Enabled = false;
            lblDataInicial.Visible = false;
            lblDataFinal.Visible = false;
            dataInicial.Enabled = false;
            dataFinal.Enabled = false;
            dataInicial.Visible = false;
            dataFinal.Visible = false;
        }
        //
        private void habilitaTotal()
        {
            //txtTotal.Visible = true;
            //txtTotal.Enabled = false;
            lblTotal.Visible = true;
        }
        //
        private void desabilitaTotal()
        {
            //txtTotal.Visible = false;
            //txtTotal.Enabled = false;
            lblTotal.Visible = false;
        }
        //
        //***********************************************************//
        // #  BOTÃO DE PESQUISA  #
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        //
        //***********************************************************//
        // #
        public void Pesquisar()
        {
            verificaGridVisivel();
            rastDados();
            //chkTodos.Checked = false;
            // CONDIÇÃO PARA RENOMEAR BOTOES
            if (rdExibirTodos.Checked == true)
            {
                btnFaturar.Text = "Faturar";
                btnFaturar.Enabled = false;
            }
            else if (rdFaturados.Checked == true)
            {
                btnFaturar.Text = "Cancelar Fatura";
                btnFaturar.Enabled = true;
            }
            else if (rdAbertos.Checked == true)
            {
                btnFaturar.Text = "Faturar";
                btnFaturar.Enabled = true;
            }
        }
        //
        //
        //
        //***********************************************************//
        // # cria lista de linhas selecionadas
        // # verifica se tem linhas selecionadas
        // # e toma decisao sobre ativar ou desativar botoes
        public void listaSelecionados()
        {
            List<DataGridViewRow> Selecionados = (from row in gridTrabalhos.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells[0].Value) == true
                                                  select row).ToList();
            if (Selecionados.Count > 0)
            {
                
            }
            else
            {
                
            }
        }
        //***********************************************************//
        //***********************************************************//
        private void selecionaTodos()
        {
            foreach (DataGridViewRow linha in gridTrabalhos.Rows)
            {
                if (chkTodos.Checked)
                {
                    linha.Cells[0].Value = true;
                }
                else
                {
                    linha.Cells[0].Value = false;
                }
            }
        }
        //***********************************************************//
        //***********************************************************//
        //
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            selecionaTodos();
        }
        //***********************************************************//
        //*****************      FATURAR     ************************//
        //***********************************************************//
        private void btnFaturar_Click(object sender, EventArgs e)
        {
            //
            // ALGORITIMO DE FATURAMENTO
            //  ao clicar em faturar
            //  lista dados selecionados a faturar

            //    se > caso nao tenha nenhuma linha selecionada
            //         emite aviso(voce deve selecionar os itens para faturar)

            //    se nao >
            //        soma total pelas linhas selecionadas
            //        salva novo registro na fatura e retorna o id
            //  **
            //        pega o id do cliente selecionado

            //  salva nos registros selecionados
            //    o valor 1 em faturado e o id da fatura

            //  apos o evento recupera os dados da fatura
            //    e preenche os dados nas variaveis pra passar por parametro.

            //    entao abre novo formulario com a fatura selecionada
            //
            List<DataGridViewRow> Selecionados = (from row in gridTrabalhos.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells[0].Value) == true
                                                  select row).ToList();
            //
            if (Selecionados.Count > 0)
            {
                var msg = "";
                if(rdAbertos.Checked ==true)
                {
                    msg = "Faturar";
                }
                else if(rdFaturados.Checked==true)
                {
                    msg = "Cancelar Faturamento de";
                }

                if (MessageBox.Show(string.Format("Tem Certeza que Deseja "+ msg +" {0} Registro(s)?", Selecionados.Count), "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    decimal total = 0;
                    DateTime hoje = DateTime.Today.Date;
                    int IDCliente = Convert.ToInt32(lblClienteID.Text);
                    hoje.ToShortDateString();
                    var dia = hoje.ToString("yyyy/MM/dd");
                    //
                    //salva fatura e retorna id
                    var fatura = new Faturas();
                    fatura.clienteFatura = IDCliente;
                    fatura.dataEmissao = hoje;
                    fatura.dataVencimento = hoje.AddDays(5);
                    fatura.moeda = lblMoeda.Text;
                    fatura.valorHora = lblPrecoHora.Text;
                    fatura.totalFatura = txtTotal.Text;
                    fatura.Salvar();
                    //
                    foreach (DataGridViewRow row in Selecionados)
                    {
                        var i = row.Cells[1].Value;
                        // # checa se estiver aberto, entao fatura
                        if(rdAbertos.Checked==true)
                        {
                            //retorna o id e escreve no textbox
                            var idRetorno = Faturas.retornaID();
                            var fat = idRetorno[0];
                            var idRetornado = fat.IDFat;
                            txtIDFat.Text = Convert.ToString(idRetornado);
                            //
                            //soma e escreve valores selecionados
                            //pra somar precisa converter, pois a entrada vem com a string R$
                            //pega o valor correspondente a linha.celula
                            var valor = row.Cells[8].Value.ToString();
                            decimal valorC = Convert.ToDecimal(valor);
                            total += valorC;
                            //txtTotal.Text = Convert.ToString(total);
                            //atualiza fatura com os dados retornados e calculados
                            var upFatura = new Faturas();
                            fatura.IDFat = idRetornado;
                            fatura.totalFatura = Convert.ToString(total);
                            fatura.Salvar();
                            //salva os dados nos itens 
                            //salva id da fatura e marca como faturado
                            var id = Convert.ToInt32(i);
                            var sim = 1;
                            var t = new iTrabalho();
                            t.Fatura(id,sim,idRetornado);
                            //TODO..
                            //
                        }
                        // # se estiver fechado, cancela fatura
                        else if(rdFaturados.Checked==true)
                        {
                            //seta idRetornado como 0;
                            var idRetornado = 0;
                            var id = Convert.ToInt32(i);
                            var nao = 0;
                            var t = new iTrabalho();
                            t.Fatura(id, nao, idRetornado);
                        }
                        //
                        //TESTE DE FUNCIONAMENTO
                        //MessageBox.Show(id + "Selecionado"); 
                    }
                    try
                    {
                        //abre formulario com itens da fatura
                        int idFatura = Convert.ToInt32(txtIDFat.Text);
                        //processo concluido agora abre o formulario com a fatura criada
                        frmFatura NovaFatura = new frmFatura(idFatura);
                        NovaFatura.Owner = this;
                        NovaFatura.Show();
                    }
                    catch
                    {
                    }
                    rastDados();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione pelo menos um item da lista.");
            }
        }
        //
        //***********************************************************//
        // #
        //
        /// <summary>
        /// Soma Total
        /// </summary>
        private void Soma()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in gridTrabalhos.Rows)
            {
                var valor = row.Cells[8].Value.ToString();
                try
                {
                    decimal valorC = Convert.ToDecimal(valor);
                    total += valorC;
                }
                catch
                {
                }
            }
            // SETA VARIAVEL COM NOME DA LABEL
            if (rdExibirTodos.Checked == true)
            {
                lblTotalDe.Text = "Total Geral: ";
            }
            else if (rdFaturados.Checked == true)
            {
                lblTotalDe.Text = "Total Faturados: ";
            }
            else if (rdAbertos.Checked == true)
            {
                lblTotalDe.Text = "Total em Aberto: ";
            }
            //
            //var totalFatura = string.Format("{0:c}", total);
            txtTotal.Text = total.ToString();
            lblTotal.Text = lblTotalDe.Text + lblMoeda.Text + " " + txtTotal.Text;
        }

        /// <summary>
        /// Soma valores selecionados pela CheckBox
        /// </summary>
        private void somaSelecionados()
        {
            List<DataGridViewRow> Selecionados = (from row in gridTrabalhos.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells[0].Value) == true
                                                  select row).ToList();
            //
            decimal total = 0;
            //
            //if (MessageBox.Show(string.Format("Tem Certeza que Deseja Deletar {0} Registro(s)?", Selecionados.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in Selecionados)
                {
                    var id = row.Cells[1].Value;
                    var t = new iTrabalho();
                    //t.Deleta(Convert.ToInt32(id));
                    //TESTE DE FUNCIONAMENTO
                    //MessageBox.Show(id + "Selecionado");
                    total += Convert.ToDecimal(row.Cells[8].Value);
                }
                txtTotal.Text = Convert.ToString(total);
                //rastDados();
            }
        }
    }
}
