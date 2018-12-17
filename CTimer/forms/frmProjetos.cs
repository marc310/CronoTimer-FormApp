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
    public partial class frmProjetos : Form
    {
        public frmProjetos()
        {
            InitializeComponent(); 
        }
        
        private void carregaProjetos()
        {
            //dataGridProjetos.DataSource = Projetos.listaProjetos();
            var data = from projetos in Projetos.listaProjetos()
                           //where clientes.nome == txtBusca.Text
                       orderby projetos.nomeProj
                       select new
                       {
                           idProj = projetos.idProj,
                           nomeProj = projetos.nomeProj,
                           descricaoProj = projetos.descricaoProj,
                           precoProj = projetos.precoProj,
                           clienteID = projetos.clienteID
                       };
            dataGridProjetos.DataSource = data.ToList();
            cboCliente.Text = "[ Selecione o Cliente para Filtrar ]";
        }
        private void carregaProj()
        {
            var data = from projetos in Projetos.porClienteID(Convert.ToInt32(txtIDCli.Text))
                           //where clientes.nome == txtBusca.Text
                       orderby projetos.nomeProj
                       select new
                       {
                           idProj = projetos.idProj,
                           nomeProj = projetos.nomeProj,
                           descricaoProj = projetos.descricaoProj,
                           precoProj = projetos.precoProj,
                           clienteID = projetos.clienteID
                       };
            dataGridProjetos.DataSource = data.ToList();

            //dataGridProjetos.DataSource = Projetos.porClienteID(Convert.ToInt32(txtIDCli.Text));
        }

        private void carregaCli()
        {
            cboCliente.DataSource = Clientes.carregaClientes();
            cboCliente.ValueMember = "clienteID";
            cboCliente.DisplayMember = "nome";
        }

        private void carregaGrid()
        {
            try
            {
                DataGridViewColumn coluna1 = dataGridProjetos.Columns[0];
                DataGridViewColumn coluna2 = dataGridProjetos.Columns[1];
                DataGridViewColumn coluna3 = dataGridProjetos.Columns[2];
                DataGridViewColumn coluna4 = dataGridProjetos.Columns[3];
                DataGridViewColumn coluna5 = dataGridProjetos.Columns[4];

                coluna1.HeaderText = "ID do Projeto";
                coluna1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna2.HeaderText = "Nome do Projeto";

                coluna3.HeaderText = "Descrição";

                coluna4.HeaderText = "Preço do Projeto";
                coluna4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna5.HeaderText = "ID do Cliente";
                coluna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                coluna5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //coluna6.HeaderText = "Nome do Cliente";
                //coluna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch
            {  
            }
        }

        //private void SomaCol()
        //{
        //    double valor = 0;
        //    foreach (DataGridViewRow linha in dataGridProjetos.Rows)
        //    {
        //        DataGridViewColumn coluna4 = dataGridProjetos.Columns[3]
        //        valor = valor + linha.Cells[3].Value;
        //    }
        //}

        private void frmProjetos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            escondeTXT();
            carregaCli();
            carregaProjetos();
            carregaGrid();
            //grpDadosClientes.Visible = false;
        }
        private void rastDados()
        {
            var i = (Clientes)cboCliente.SelectedItem;

            txtIDCli.Text = Convert.ToString(i.clienteID); // identificador do form
            var preco = string.Format("{0:c}", i.precoHora); // conversor do preço hora
            
            lblNome.Text = "Nome: " + i.nome;
            lblEmail.Text = "E-mail: " + i.email;
            lblPreco.Text = "Preço por Hora: " + preco;

            carregaProj();
            //grpDadosClientes.Visible = true;
        }
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            rastDados(); 
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            carregaProjetos();
        }

        private void rastDadosProj()
        {
            //*************************************************//
            //CARREGA PROJETOS
            var p = new Projetos();
            p.idProj = Convert.ToInt32(dataGridProjetos.CurrentRow.Cells[0].Value);
            p.nomeProj = Convert.ToString(dataGridProjetos.CurrentRow.Cells[1].Value);
            p.descricaoProj = Convert.ToString(dataGridProjetos.CurrentRow.Cells[2].Value);
            p.precoProj = Convert.ToDecimal(dataGridProjetos.CurrentRow.Cells[3].Value);
            p.clienteID = Convert.ToInt32(dataGridProjetos.CurrentRow.Cells[4].Value);
            //
            var idp = p.idProj;
            var np = p.nomeProj;
            var dp = p.descricaoProj;
            var pp = Convert.ToString(p.precoProj);
            var preco = string.Format("{0:c}", p.precoProj);
            var cp = p.clienteID;
            //
            //*************************************************//
            // INICIA VERIFICAÇÃO PRA PREENCHER OS DADOS
            //
            try
            {
                if(txtNomeProj.Visible==true)
                {
                    txtIDProj.Text = Convert.ToString(idp);
                    txtNomeProj.Text = np;
                    txtDescricaoProj.Text = dp;
                    txtPrecoProj.Text = preco;
                    //
                    //
                    //***************************************************//
                    lblNomeProj.Text = "Projeto: ";
                    lblDescricaoProj.Text = "Descrição: ";
                    lblPrecoProj.Text = "Preço por Projeto: ";
                    //
                    btnAlterar.Text = "Salvar";
                    btnDeleta.Text = "Cancelar";
                }
                else
                {
                    //
                    //***************************************************//
                    lblNomeProj.Text = "Projeto: " + np;
                    lblDescricaoProj.Text = "Descrição: " + dp;
                    lblPrecoProj.Text = "Preço por Projeto: " + preco;
                    //
                    btnAlterar.Text = "Alterar";
                    btnDeleta.Text = "Excluir";
                }
            }
            catch
            {
                MessageBox.Show("Ops..Algo deu errado!");
            }
            //
            //*************************************************//
            // CARREGA DADOS DO CLIENTE
            // lazy load
            var projetos = Projetos.porClienteID(cp);
            //
            var projeto = projetos[0];
            var nomeCliente = projeto.Cliente.nome;
            var emailCliente = projeto.Cliente.email;
            var precoCliente = projeto.Cliente.precoHora;
            //
            lblNome.Text = "Nome do Cliente: " + nomeCliente;
            lblEmail.Text = "E-mail: " + emailCliente;
            lblPreco.Text = "Preço por Hora: " + precoCliente;
            //
        }

        private void dataGridProjetos_SelectionChanged(object sender, EventArgs e)
        {
            rastDadosProj();
            //grpDadosClientes.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAddProjetos addProjetos = new frmAddProjetos();
            addProjetos.Show();
        }
        //
        //***********************************************************//
        // DELETA LINHA SELECIONADA
        private void btnDeleta_Click(object sender, EventArgs e)
        {
            if (txtNomeProj.Visible == false)
            {
                var nomeP = Convert.ToString(dataGridProjetos.CurrentRow.Cells[1].Value);
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja deletar o Projeto " + nomeP + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    var p = new Projetos();
                    p.idProj = Convert.ToInt32(dataGridProjetos.CurrentRow.Cells[0].Value);
                    var id = p.idProj;
                    p.Deleta(id);

                    MessageBox.Show("Registro Excluído com Sucesso!");

                    carregaProj();
                }
            }
            else
            {
                escondeTXT();
                rastDadosProj();
                btnDeleta.Text = "Excluir";
                btnAlterar.Text = "Alterar";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtNomeProj.Visible==false)
            {
                exibeTXT();
                rastDadosProj();
                btnAlterar.Text = "Salvar";
                btnDeleta.Text = "Cancelar";
            }
            else
            {
                escondeTXT();
                rastDadosProj();
                btnAlterar.Text = "Alterar";
                btnDeleta.Text = "Excluir";
                //
                //cria instancia do objeto pra dar o comando salvar
                if (txtPrecoProj.Text == "")
                {
                    txtPrecoProj.Text = "0";
                }
                //trata valor
                var p = txtPrecoProj.Text.Replace("R$", "");
                var preco = decimal.Parse(p);
                //cria instancia de clientes e preenche com os dados do txt box
                var proj = new Projetos();
                proj.idProj = Convert.ToInt32(txtIDProj.Text);
                proj.nomeProj = txtNomeProj.Text;
                proj.descricaoProj = txtDescricaoProj.Text;
                proj.precoProj = preco;

                proj.Salvar();
                MessageBox.Show("" + proj.nomeProj + " alterado com Sucesso!");
                //
                escondeTXT();
                carregaProjetos();
                frmProjetos_Load(sender, e);
            }
            rastDadosProj();
        }
        //
        //**************************************************************//
        //
        private void escondeTXT()
        {
            txtNomeProj.Visible = false;
            txtDescricaoProj.Visible = false;
            txtPrecoProj.Visible = false;
        }
        private void exibeTXT()
        {
            txtNomeProj.Visible = true;
            txtDescricaoProj.Visible = true;
            txtPrecoProj.Visible = true;
        }

        //**************************************************************************//
        // KEY PRESS ENTER PRA SALVAR //
        //
        private void txtPrecoProj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnAlterar_Click(sender, e);
            }
        }

        private void txtDescricaoProj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnAlterar_Click(sender, e);
            }
        }

        private void txtNomeProj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnAlterar_Click(sender, e);
            }
        }
        //**************************************************************************//
        //
    }
}
