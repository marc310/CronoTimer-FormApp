using CTimer.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTimer
{
    public partial class Dashboard : Form
    {
        private int childFormNumber = 0;

        public Dashboard()
        {
            InitializeComponent();
        }
        //
        private void Dashboard_Load(object sender, EventArgs e)
        {
            /* Minimizando aplicação na bandeja do windows */
            this.Visible = true;
            //this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            notDashboard.Visible = true;
            // cria menu contexto no icone de notificação
            var contMenu = new ContextMenu();
            contMenu.MenuItems.Add(new MenuItem("Sair do Programa", ExitToolsStripMenuItem_Click));
            contMenu.MenuItems.Add(new MenuItem("Clientes", gerClientesMenu_Click));
            contMenu.MenuItems.Add(new MenuItem("Novo Cliente", btnATimer_Click));
            contMenu.MenuItems.Add(new MenuItem("Projetos", gerenciarProjetosToolStripMenuItem_Click));
            contMenu.MenuItems.Add(new MenuItem("Novo Projeto", btnATimer_Click));
            contMenu.MenuItems.Add(new MenuItem("Registros do Timer", novaFaturaToolStripMenuItem_Click));
            contMenu.MenuItems.Add(new MenuItem("Iniciar Timer", btnATimer_Click));
            notDashboard.ContextMenu = contMenu;
            //
            frmFaturar fat = new frmFaturar();
            fat.MdiParent = this;
            fat.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTimer timer = new frmTimer();
            //timer.MdiParent = this;
            //timer.Show();
            frmTimer CTimer = new frmTimer();
            if (Application.OpenForms.OfType<frmTimer>().Count() > 0)
            {
                Application.OpenForms["frmTimer"].BringToFront();

                //MessageBox.Show("O Timer já está aberto!");
            }
            else
            {
                CTimer.Show();
            }
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddClientes Addclientes = new frmAddClientes();
            //Addclientes.MdiParent = this;
            Addclientes.Show();
        }

        private void btnATimer_Click(object sender, EventArgs e)
        {
                frmTimer CTimer = new frmTimer();
            if (Application.OpenForms.OfType<frmTimer>().Count() > 0)
            {
                Application.OpenForms["frmTimer"].BringToFront();

                //MessageBox.Show("O Timer já está aberto!");
            }
            else
            {
                CTimer.Show();
                notDashboard.ShowBalloonTip(10, "Codex Timer", "Seu Contador de Tempo está em execução,\nSeja Bem Vindo e Bom Trabalho.", ToolTipIcon.None);

            }
            this.WindowState = FormWindowState.Minimized;
        }



        private void novoProjetomenu_Click(object sender, EventArgs e)
        {
            frmAddProjetos AddProjetos = new frmAddProjetos();
            //AddProjetos.MdiParent = this;
            AddProjetos.Show();
        }

        private void novaTarefamenu_Click(object sender, EventArgs e)
        {
            frmAddTarefas addTarefas = new frmAddTarefas();
            //addTarefas.MdiParent = this;
            addTarefas.Show();
        }

        private void gerClientesMenu_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes();
            cli.MdiParent = this;
            cli.Show();
        }

        private void gerenciarProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjetos projetos = new frmProjetos();
            projetos.MdiParent = this;
            projetos.Show();
        }

        
        //
        private void novaFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaturar fat = new frmFaturar();
            fat.MdiParent = this;
            if (Application.OpenForms.OfType<frmFaturar>().Count() > 0)
            {
                Application.OpenForms["frmFaturar"].BringToFront();
            }
            else
            {
                fat.Show();
            }
        }
        //
        //
        //*********************************************************************************************************//
        //


        private void Dashboard_Resize(object sender, EventArgs e)
        {
            //traz de volta o dashboard se estiver minimizado
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Minimized;
                notDashboard.Visible = true;
                notDashboard.ShowBalloonTip(10, "Codex Dashboard", "Dashboard minimizado na barra de notificações, clique no ícone para abrir", ToolTipIcon.None);
            }
        }

        private void notDashboard_DoubleClick(object sender, EventArgs e)
        {
            /* Exibindo novamente o programa */
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notDashboard.Visible = true;
            notDashboard.Text = "Sistema de Gerenciamento de Tempo";
            notDashboard.BalloonTipTitle = this.Text;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                // confirma saida
                e.Cancel = true;
            };
        }
        //
        //
        //*********************************************************************************************************//
        //
        public static bool CloseCancel()
        {
            const string message = "Você tem certeza que deseja Deixar o Programa?";
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

        private void faturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFaturas fat = new frmFaturas();
            fat.MdiParent = this;
            if (Application.OpenForms.OfType<frmFaturas>().Count() > 0)
            {
                Application.OpenForms["frmFaturas"].BringToFront();
            }
            else
            {
                fat.Show();
            }
        }
        //
        //
        //*********************************************************************************************************//
        //

    }
}
