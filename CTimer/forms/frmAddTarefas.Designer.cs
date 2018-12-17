namespace CTimer.forms
{
    partial class frmAddTarefas
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpTarefas = new System.Windows.Forms.GroupBox();
            this.txtDescricaoT = new System.Windows.Forms.TextBox();
            this.txtNomeT = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpTarefas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(249, 174);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpTarefas
            // 
            this.grpTarefas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTarefas.Controls.Add(this.txtDescricaoT);
            this.grpTarefas.Controls.Add(this.txtNomeT);
            this.grpTarefas.Controls.Add(this.lblDescricao);
            this.grpTarefas.Controls.Add(this.lblNome);
            this.grpTarefas.Location = new System.Drawing.Point(12, 29);
            this.grpTarefas.Name = "grpTarefas";
            this.grpTarefas.Size = new System.Drawing.Size(332, 132);
            this.grpTarefas.TabIndex = 15;
            this.grpTarefas.TabStop = false;
            this.grpTarefas.Text = "Dados da Tarefa";
            // 
            // txtDescricaoT
            // 
            this.txtDescricaoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoT.Location = new System.Drawing.Point(126, 70);
            this.txtDescricaoT.Name = "txtDescricaoT";
            this.txtDescricaoT.Size = new System.Drawing.Size(186, 20);
            this.txtDescricaoT.TabIndex = 8;
            // 
            // txtNomeT
            // 
            this.txtNomeT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeT.Location = new System.Drawing.Point(126, 44);
            this.txtNomeT.Name = "txtNomeT";
            this.txtNomeT.Size = new System.Drawing.Size(186, 20);
            this.txtNomeT.TabIndex = 7;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(19, 73);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome da Tarefa";
            // 
            // frmAddTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 209);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpTarefas);
            this.MinimumSize = new System.Drawing.Size(370, 240);
            this.Name = "frmAddTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Tarefas";
            this.grpTarefas.ResumeLayout(false);
            this.grpTarefas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpTarefas;
        private System.Windows.Forms.TextBox txtDescricaoT;
        private System.Windows.Forms.TextBox txtNomeT;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
    }
}