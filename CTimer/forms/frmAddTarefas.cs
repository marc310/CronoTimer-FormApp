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
    public partial class frmAddTarefas : Form
    {
        public frmAddTarefas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var t = new Tarefas();
            t.nomeTar = txtNomeT.Text;
            t.descricaoTar = txtDescricaoT.Text;

            t.Salvar();
            MessageBox.Show("Salvo com Sucesso!");
            this.Hide();
        }
    }
}
