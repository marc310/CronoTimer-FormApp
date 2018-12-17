namespace CTimer.forms
{
    partial class frmFaturas
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
            this.gridFaturas = new System.Windows.Forms.DataGridView();
            this.lblIDFatura = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new CTimer.Controles.txtID();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFaturas
            // 
            this.gridFaturas.AllowUserToAddRows = false;
            this.gridFaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFaturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFaturas.Location = new System.Drawing.Point(12, 78);
            this.gridFaturas.MultiSelect = false;
            this.gridFaturas.Name = "gridFaturas";
            this.gridFaturas.RowHeadersVisible = false;
            this.gridFaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFaturas.Size = new System.Drawing.Size(776, 349);
            this.gridFaturas.TabIndex = 0;
            this.gridFaturas.SelectionChanged += new System.EventHandler(this.gridFaturas_SelectionChanged);
            this.gridFaturas.DoubleClick += new System.EventHandler(this.gridFaturas_DoubleClick);
            // 
            // lblIDFatura
            // 
            this.lblIDFatura.AutoSize = true;
            this.lblIDFatura.Location = new System.Drawing.Point(15, 35);
            this.lblIDFatura.Name = "lblIDFatura";
            this.lblIDFatura.Size = new System.Drawing.Size(51, 13);
            this.lblIDFatura.TabIndex = 1;
            this.lblIDFatura.Text = "ID Fatura";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 15);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 24;
            this.lblCliente.Text = "Cliente";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 427);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 11);
            this.progressBar.TabIndex = 26;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(18, 55);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(109, 17);
            this.chkTodos.TabIndex = 38;
            this.chkTodos.Text = "Selecionar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(600, 51);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 13);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total da Fatura:";
            this.lblTotal.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.LightGray;
            this.txtTotal.Location = new System.Drawing.Point(688, 48);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 44;
            this.txtTotal.Visible = false;
            // 
            // frmFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblIDFatura);
            this.Controls.Add(this.gridFaturas);
            this.Name = "frmFaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFaturas;
        private System.Windows.Forms.Label lblIDFatura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label lblTotal;
        private Controles.txtID txtTotal;
    }
}