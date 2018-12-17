using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeX;

namespace CTimer.forms
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent(); 
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //carregaCli();
            //txtBusca.Text = "Digite aqui o nome que deseja buscar...";
            reloadDadosCli();
            WindowState = FormWindowState.Maximized;
            //carregaDataGrid();
        }

        private void carregaCli()
        {
            var data = from clientes in Clientes.listaClientes()
                      // where projetos.clienteID == c
                       orderby clientes.nome
                       select new
                       {
                           clienteID = clientes.clienteID,
                           nome = clientes.nome,
                           telefone = clientes.telefone,
                           celular=clientes.celular,
                           email=clientes.email,
                           moeda=clientes.Moeda.simbolo,
                           precoHora=clientes.precoHora,
                       };
            dataGridClientes.DataSource = data.ToList();
        }

        /// <summary>
        /// Configura DataGridView
        /// </summary>
        public void carregaDataGrid()
        {
            //dataGridClientes.EnableHeadersVisualStyles = false;
            //dataGridClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewColumn coluna1 = dataGridClientes.Columns[0];
            DataGridViewColumn coluna2 = dataGridClientes.Columns[1];
            DataGridViewColumn coluna3 = dataGridClientes.Columns[2];
            DataGridViewColumn coluna4 = dataGridClientes.Columns[3];
            DataGridViewColumn coluna5 = dataGridClientes.Columns[4];
            DataGridViewColumn coluna6 = dataGridClientes.Columns[5];
            DataGridViewColumn coluna7 = dataGridClientes.Columns[6];
            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //chk.HeaderText = "Ativo";
            //chk.Name = "ativo";
            //dataGridClientes.Columns.Add(chk);

            coluna1.HeaderText = "Cliente ID";
            //coluna1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            coluna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            coluna2.HeaderText = "Nome do Cliente";

            coluna3.HeaderText = "Telefone";
            coluna3.Width = 120;

            coluna4.HeaderText = "Celular";
            coluna4.Width = 120;
            //coluna4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            coluna5.HeaderText = "E-mail";

            coluna6.HeaderText = "Moeda";
            coluna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            coluna7.HeaderText = "Preço Hora";

        }

        //private void Soma()
        //{
        //    decimal total = 0;
        //    foreach(DataGridViewRow row in dataGridClientes.Rows)
        //    {
        //        total += Convert.ToDecimal(row.Cells[5].Value);
        //    }
        //    txtTotal.Text = Convert.ToString(total);
        //}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dataGridClientes.DataSource = Clientes.buscaNomeCli(txtBusca.Text);

            if(txtBusca.Text != "")
            {
                var data = from clientes in Clientes.buscaNomeCli(txtBusca.Text)
                               //where clientes.nome == txtBusca.Text
                           orderby clientes.nome
                           select new
                           {
                               clienteID = clientes.clienteID,
                               nome = clientes.nome,
                               telefone = clientes.telefone,
                               celular = clientes.celular,
                               email = clientes.email,
                               moeda = clientes.Moeda.simbolo,
                               precoHora = clientes.precoHora
                           };
                dataGridClientes.DataSource = data.ToList();
            }

            if(txtBusca.Text == "Digite aqui o nome que deseja buscar...")
            {
                carregaCli();
                //reload
            }
            //
            if (txtBusca.Text == "")
            {
                carregaCli();
                //carrega todos, dando reload
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "Digite aqui o nome que deseja buscar...";
            carregaCli();
            this.txtBusca.Focus();
        }
        //
        //**************************************************************************//
        public void reloadDadosCli()
        {
            carregaCli();
            txtBusca.Text = "Digite aqui o nome que deseja buscar...";
            //WindowState = FormWindowState.Maximized;
            carregaDataGrid();
        }
        //  RASTREIA E PREENCHE OS DADOS NAS LABELS E NOS TXTS
        //
        private void rastDadosCli()
        {
            //pega formato atual de moeda


            //converte string formatada para label
            //var p = Convert.ToDecimal(dataGridClientes.CurrentRow.Cells[5].Value);
            //var preco = string.Format("{0:c}", p);
            //cria instancia de clientes onde pega os valores selecionados
            var c = new Clientes();
            c.clienteID = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);
            c.nome = Convert.ToString(dataGridClientes.CurrentRow.Cells[1].Value);
            c.telefone = Convert.ToString(dataGridClientes.CurrentRow.Cells[2].Value);
            c.celular = Convert.ToString(dataGridClientes.CurrentRow.Cells[3].Value);
            c.email = Convert.ToString(dataGridClientes.CurrentRow.Cells[4].Value);
            c.Moeda.simbolo = Convert.ToString(dataGridClientes.CurrentRow.Cells[5].Value);
            c.precoHora = Convert.ToDecimal(dataGridClientes.CurrentRow.Cells[6].Value);
            //
            //denomina variaveis inteiras
            var id = c.clienteID;
            var nome = c.nome;
            var telefone = c.telefone;
            var celular = c.celular;
            var email = c.email;
            var simb = c.Moeda.simbolo;
            //var moedaID = c.Moeda.idMoeda;
            var precoH = c.precoHora;
            //lblSimbolo.Text = Convert.ToString(moedaID);
            //
            try
            {
                //if(txtID.Visible==true)
                //{
                //    //preenche os text box
                //    //txtID.Text = Convert.ToString(id);
                //    //txtNome.Text = nome;
                //    //txtEmail.Text = email;
                //    //txtTelefone.Text = telefone;
                //    //txtCelular.Text = celular;
                //    //txtPreco.Text = Convert.ToString(moedaID);
                //    //preenche as labels
                //    lblID.Text = "ID do Cliente: ";
                //    //lblNome.Text = "Nome: ";
                //    //lblTelefone.Text = "Telefone: ";
                //    //lblCelular.Text = "Celular: ";
                //    //lblEmail.Text = "E-mail: ";
                //    //lblPreco.Text = "Preço por Hora: ";
                //}
                //else
                //{
                    //preenche as labels
                    lblID.Text = "ID do Cliente: " + id;
                    //lblNome.Text = "Nome: " + nome;
                    //lblTelefone.Text = "Telefone: " + telefone;
                    //lblCelular.Text = "Celular: " + celular;
                    //lblEmail.Text = "E-mail: " + email;
                    //lblPreco.Text = "Preço por Hora: " + simb + precoH;
                //}
            }
            catch 
            {
                MessageBox.Show("alguma coisa aconteceu");
            }

        }
        //
        //************************************************************************************//
        //
        private void dataGridClientes_SelectionChanged(object sender, EventArgs e)
        {
            rastDadosCli();
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            var nomeC = Convert.ToString(dataGridClientes.CurrentRow.Cells[1].Value);
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar o Cliente " + nomeC + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Sua rotina de exclusão
                //Confirmando exclusão para o usuário
                var c = new Clientes();
                c.clienteID = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);
                var id = c.clienteID;
                c.Deleta(id);

                MessageBox.Show("Registro " + id + " Excluído com Sucesso!");

                carregaCli();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAddClientes addClientes = new frmAddClientes();
            addClientes.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //if(txtID.Visible==false)
            //{
            //    exibeTXT();
            //    btnAlterar.Text = "Salvar";
            //    btnDeleta.Text = "Cancelar";
            //}
            //else
            //{
            //    btnAlterar.Text = "Alterar";
            //    btnDeleta.Text = "Excluir";
            //    //
            //    //cria instancia do objeto pra dar o comando salvar
            //    if (txtPreco.Text == "")
            //    {
            //        txtPreco.Text = "0";
            //    }
            //    //trata valor
            //    var p = txtPreco.Text.Replace("R$", "");
            //    var preco = decimal.Parse(p);
            //    //cria instancia de clientes e preenche com os dados do txt box
            //    var c = new Clientes();
            //    c.clienteID = Convert.ToInt32(txtID.Text);
            //    c.nome = txtNome.Text;
            //    c.telefone = txtTelefone.Text;
            //    c.celular = txtCelular.Text;
            //    c.email = txtEmail.Text;
            //    c.moeda = Convert.ToInt32(cboMoeda.SelectedValue);
            //    c.precoHora = preco;
            //    c.Salvar();
            //    MessageBox.Show("" + c.nome + " alterado com Sucesso!");
            //    //
            //    escondeTXT();
            //    frmClientes_Load(sender, e);
            //}
            //rastDadosCli();
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
                txtBusca.Focus();
                txtBusca.SelectAll();
            }
        }

        //private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((Keys)e.KeyChar == Keys.Enter)
        //    {
        //        btnAlterar_Click(sender, e);
        //    }
        //}

        private void dataGridClientes_DoubleClick(object sender, EventArgs e)
        {
            var c = new Clientes();
            c.clienteID = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);
            //
            frmAddClientes AddCli = new frmAddClientes(c.clienteID);
            AddCli.Owner = this;
            AddCli.Show();
        }
    }
}
