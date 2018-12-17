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
    public partial class frmAddClientes : Form
    {
        public frmAddClientes()
        {
            InitializeComponent();
        }

        private void frmAddClientes_Load(object sender, EventArgs e)
        {
            if (txtIDC.Text == "")
            {
                carregaMoeda();
                cboMoeda.Text = "[ Selecione ]";
            }
        }

        public frmAddClientes(int idC)
        {
            InitializeComponent();
            carregaMoeda();
            txtIDC.Text = Convert.ToString(idC);
            ReloadDados();
        }

        /// <summary>
        /// Carrega Combo de Moedas
        /// </summary>
        private void carregaMoeda()
        {
            cboMoeda.DataSource = Moedas.carregaMoedas();
            cboMoeda.ValueMember = "idMoeda";
            cboMoeda.DisplayMember = "codigo";
        }
        //
        // BUSCA NO BANCO REFERENTE AO ID DO TRABALHO
        private void ReloadDados()
        {
            // ID TRABALHO ATUAL SELECIONADO
            int idCli = Convert.ToInt32(txtIDC.Text);
            //
            var cli = Clientes.porClienteID(idCli);
            var c = cli[0];
            // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
            int idCl = c.clienteID;
            var nCl = c.nome;
            var tCl = c.telefone;
            var cCl = c.celular;
            var eCl = c.email;
            int mCl = c.moeda;
            decimal pCl = c.precoHora;
            //
            //MessageBox.Show("id da moeda " + mCl);
            txtIDC.Text = idCl.ToString();
            txtNome.Text = nCl;
            txtTelefone.Text = tCl;
            txtCelular.Text = cCl;
            txtEmail.Text = eCl;
            txtPreco.Text = Convert.ToString(pCl);
            cboMoeda.SelectedValue = Convert.ToInt32(mCl);
        }
        //
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //var preco = Convert.ToDouble(txtPreco.Text.Replace("R$ ", ""));
            //var p = txtPreco.Text.Replace("R$", "");
            var p = txtPreco.Text;
            var preco = decimal.Parse(p, NumberStyles.Currency);
            //
            var m = cboMoeda.SelectedValue;
            int moeda = Convert.ToInt32(m);
            //
            if (txtIDC.Text == "")
            {
                txtIDC.Text = "0";
            }
            //
            var c = new Clientes();
            c.clienteID = Convert.ToInt32(txtIDC.Text);
            c.nome = txtNome.Text;
            c.telefone = txtTelefone.Text;
            c.celular = txtCelular.Text;
            c.email = txtEmail.Text;
            c.moeda = moeda;
            c.precoHora = preco;
            //(double.Parse("123,4").ToString("0.00"))
            c.Salvar();
            ((frmClientes)this.Owner).reloadDadosCli();
            MessageBox.Show("Cliente " + c.nome + " Salvo com Sucesso!");
            this.Hide();
        }

    }
}
