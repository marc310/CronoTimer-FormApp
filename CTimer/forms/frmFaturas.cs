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
    public partial class frmFaturas : Form
    {
        public frmFaturas()
        {
            InitializeComponent();
            carregaGrid();
        }

        private void frmFaturas_Load(object sender, EventArgs e)
        {
            carregaFat();
            this.progressBar.Visible = false;
            WindowState = FormWindowState.Maximized;
        }
        //
        //
        //***********************************************************//
        // #
        private void verificaGridVisivel()
        {
            if (gridFaturas.Visible == false)
            {
                gridFaturas.Visible = true;
            }
        }
        //*******************************************************************************************************//
        /// <summary>
        /// Carrega Configurações do GridView
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
                gridFaturas.Columns.Insert(0, checkBoxColumn);

                DataGridViewColumn coluna1 = gridFaturas.Columns[1];
                DataGridViewColumn coluna2 = gridFaturas.Columns[2];
                DataGridViewColumn coluna3 = gridFaturas.Columns[3];
                DataGridViewColumn coluna4 = gridFaturas.Columns[4];
                DataGridViewColumn coluna5 = gridFaturas.Columns[5];
                DataGridViewColumn coluna6 = gridFaturas.Columns[6];
                DataGridViewColumn coluna7 = gridFaturas.Columns[7];
                //DataGridViewColumn coluna8 = gridFaturas.Columns[8];
                //DataGridViewColumn coluna9 = gridFaturas.Columns[9];
                //DataGridViewColumn coluna10 = gridTrabalhos.Columns[9];
                //***********************************************************//
                coluna1.HeaderText = "ID Fat";
                coluna1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna2.HeaderText = "Cliente";
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

                //coluna8.HeaderText = "Horas";
                //coluna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //coluna9.HeaderText = "Faturado";
                //coluna9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch
            {
            }
        }
        //
        //
        //*******************************************************************************************************//
        // GRIDS DE CARREGAMENTO
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS DE TRABALHO NO GERAL
        //
        /// <summary>
        /// Carrega itens de trabalho faturados
        /// </summary>
        private void carregaFat()
        {
            //
            var data = from fatura in Faturas.listaFaturas()
                       orderby fatura.dataEmissao
                       select new
                       {
                           idFat = fatura.IDFat,
                           //clienteFatura = fatura.clienteFatura,
                           nomeCliente = fatura.Cliente.nome,
                           dataEmissao = fatura.dataEmissao,
                           dataVencimento = fatura.dataVencimento,
                           totalFatura = fatura.moeda + " " + fatura.totalFatura,
                           pago = fatura.pago
                       };
            gridFaturas.DataSource = data.ToList();
            //carregaGrid();
            LoadProgBar();
        }
        //
        // **            **             **
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
            var gridTotalR = gridFaturas.Rows.Count;
            progressBar.Maximum = gridTotalR;
            progressBar.Minimum = 1;
            //
            this.progressBar.Visible = true;
            for (int i = 0; i < gridTotalR; i++)
            {
                System.Threading.Thread.Sleep(100);
                progressBar.PerformStep();
            }
        }
        //
        public void reloadFaturas()
        {
            carregaFat();
        }
        //*******************************************************************************************************//
        // FUNÇÃO DOUBLE CLICK DO GRID VIEW
        //*******************************************************************************************************//
        //private void gridTrabalhos_DoubleClick(object sender, EventArgs e)
        //{
        //    int idF = Convert.ToInt32(lblIDFatura.Text);
        //    frmFatura Fatura = new frmFatura(idF);
        //    Fatura.Owner = this;
        //    Fatura.Show();
        //}
        //*******************************************************************************************************//
        // RASTREIA DADOS SELECIONADOS NO GRIDVIEW
        public void rastDadosFatura()
        {
            //CARREGA PROJETOS
            var f = new Faturas();
            f.IDFat = Convert.ToInt32(gridFaturas.CurrentRow.Cells[1].Value);
            //
            var idF = f.IDFat;
            //
            //*************************************************//
            // INICIA VERIFICAÇÃO PRA PREENCHER OS DADOS
            //
            lblIDFatura.Text = "ID da Fatura: " + idF;
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
            //List<DataGridViewRow> Selecionados = (from row in gridTrabalhos.Rows.Cast<DataGridViewRow>()
            //                                      where Convert.ToBoolean(row.Cells[0].Value) == true
            //                                      select row).ToList();
            ////
            //if (Selecionados.Count > 0)
            //{
            //    if (MessageBox.Show(string.Format("Tem Certeza que Deseja Deletar {0} Registro(s)?", Selecionados.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        foreach (DataGridViewRow row in Selecionados)
            //        {
            //            var id = row.Cells[1].Value;
            //            var t = new iTrabalho();
            //            t.Deleta(Convert.ToInt32(id));
            //            //TESTE DE FUNCIONAMENTO
            //            //MessageBox.Show(id + "Selecionado"); 
            //        }
            //        rastDados();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selecione os Registros que deseja Excluir.");
            //}
            //    //var idTr = Convert.ToString(gridTrabalhos.CurrentRow.Cells[0].Value);
            //    //if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar a entrada " + idTr + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            //    //{
            //    //    var i = new iTrabalho();
            //    //    i.idTrabalho = Convert.ToInt32(gridTrabalhos.CurrentRow.Cells[0].Value);
            //    //    var id = i.idTrabalho;
            //    //    i.Deleta(id);
            //    //    MessageBox.Show("Registro Excluído com Sucesso!");
            //    //    carregaGridTrabalhos();
            //    //}
        }
        //
        //
        //***********************************************************//
        // RASTREA DADOS PELA SELEÇÃO E DIRECIONA PRA FUNÇÃO CORRETA //
        //***********************************************************//
        //private void rastDados()
        //{
        //    var i = (Clientes)cboCliente.SelectedItem;

        //    lblClienteID.Text = Convert.ToString(i.clienteID);
        //    //lblEmail.Text = "E-mail: " + i.email;
        //    //lblPreco.Text = "Preço por Hora: " + preco;
        //    //carregaProj();
        //    //grpDadosClientes.Visible = true;
        //    if(rdFaturados.Checked==true)
        //    {
        //        if(chkPorData.Checked==true)
        //        {
        //            // consulta entre datas
        //            rastEntradasFaturadoPorClienteEntD();
        //        }
        //        else if (chkPorData.Checked == false)
        //        {
        //        // consulta normal
        //        rastEntradasFaturadoPorCliente();
        //        }
        //    }
        //    else if(rdAbertos.Checked==true)
        //    {
        //        // consulta com status de abertos
        //        if(chkPorData.Checked==true)
        //        {
        //            rastEntradasAbertosPorClienteEntD(); // por data
        //        }
        //        else if (chkPorData.Checked == false)
        //        {
        //        rastEntradasAbertosPorCliente(); // consulta normal
        //        }
        //    }
        //    else
        //    {
        //        if(chkPorData.Checked==true)
        //        {
        //            // consulta entre datas somente pelo cliente
        //            rastEntradasPorClienteEntD();
        //        }
        //        else if (chkPorData.Checked == false)
        //        {
        //        // consulta normal
        //        rastEntradasPorCliente();
        //        }
        //        rdExibirTodos.Checked = true;
        //    }
        //    chkTodos.Checked = false;
        //    this.progressBar.Visible = false;
        //}
        //***********************************************************//
        //***********************************************************//
        //
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            selecionaTodos();
        }
        //***********************************************************//
        //***********************************************************//
        /// <summary>
        /// Seleciona todos checkbox do grid
        /// </summary>
        private void selecionaTodos()
        {
            foreach (DataGridViewRow linha in gridFaturas.Rows)
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
        //
        /// <summary>
        /// Soma Total
        /// </summary>
        private void Soma()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in gridFaturas.Rows)
            {
                total += Convert.ToDecimal(row.Cells[8].Value);
            }
            txtTotal.Text = Convert.ToString(total);
        }
        //
        //
        /// <summary>
        /// Carrega Dados da Fatura pelo ID na textBox
        /// </summary>
        //private void ReloadDadosFat()
        //{
        //    // ID FATURA ATUAL SELECIONADO
        //    int idFatura = Convert.ToInt32(txtIDFat.Text);
        //    //
        //    var faturas = Faturas.porFaturaID(idFatura);
        //    var fatura = faturas[0];
        //    // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
        //    int idF = fatura.IDFat;
        //    int cF = fatura.clienteFatura;
        //    var nomeCliente = fatura.Cliente.nome;
        //    DateTime dE = fatura.dataEmissao;
        //    DateTime dV = fatura.dataVencimento;
        //    var tF = fatura.totalFatura;
        //    //bool pg = fatura.pago;
        //    //
        //    dE.ToShortTimeString();
        //    dV.ToShortTimeString();
        //    var total = Convert.ToString(tF);
        //    //
        //    txtIDFat.Text = Convert.ToString(idF);
        //    lblClienteID.Text = Convert.ToString(cF);
        //    lblCliente.Text = Convert.ToString(nomeCliente);
        //    txtDataEmissao.Text = dE.ToString("dd/MM/yyyy");
        //    txtDataVencimento.Text = dV.ToString("dd/MM/yyyy");
        //    txtTotal.Text = "R$ " + total;
        //    //
        //}

        private void gridFaturas_DoubleClick(object sender, EventArgs e)
        {
            var fatura = lblIDFatura.Text.Replace("ID da Fatura: ", "");
            int idF = Convert.ToInt32(fatura);
            frmFatura Fatura = new frmFatura(idF);
            Fatura.Owner = this;
            Fatura.Show();
        }

        private void gridFaturas_SelectionChanged(object sender, EventArgs e)
        {
            rastDadosFatura();
        }
        //
    }
}
