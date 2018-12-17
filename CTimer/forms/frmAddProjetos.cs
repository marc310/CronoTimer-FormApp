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
    public partial class frmAddProjetos : Form
    {
        private void carregaCbo()
        {
            cboClienteP.DataSource = Clientes.carregaClientes();
            cboClienteP.ValueMember = "clienteID";
            cboClienteP.DisplayMember = "nome";
        }

        public frmAddProjetos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtPrecoP.Text=="")
            {
                txtPrecoP.Text = "0";
            }

            var prP = txtPrecoP.Text.Replace("R$", "");
            decimal preco = decimal.Parse(prP, NumberStyles.Currency);

            var cli = cboClienteP.SelectedValue;
            var cliente = Convert.ToInt32(cli);

            var p = new Projetos();
            p.nomeProj = txtNomeP.Text;
            p.descricaoProj = txtDescricaoP.Text;
            p.precoProj = preco;
            p.clienteID = cliente;
            //p.nomeCliente = txtNome.Text;

            p.Salvar();
            MessageBox.Show("Salvo com Sucesso!");
            this.Hide();
        }

        private void frmAddProjetos_Load(object sender, EventArgs e)
        {
            carregaCbo();
            cboClienteP.Text = "[ Selecione ]";
        }

        private void grpProjetos_Enter(object sender, EventArgs e)
        {

        }

        private void cboClienteP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = (Clientes)cboClienteP.SelectedItem;

            try
            {

                txtID.Text = Convert.ToString(c.clienteID);
                //txtNome.Text = c.nome;
            }
            catch 
            {
            }
        }
    }
}
