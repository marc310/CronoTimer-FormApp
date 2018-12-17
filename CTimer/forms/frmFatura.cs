using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CodeX;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Zen.Barcode;

namespace CTimer.forms
{
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
            carregaGrid();
            lblTotal.Text = "Total da Fatura: ";
        }
        //
        /// <summary>
        /// GERAR QR CODE
        /// </summary>
        private void geraQrCode()
        {
            //PEGA INFORMAÇÕES 
            var clienteF = lblCliente.Text;
            //var fP = "Faturado para: " + clienteF;
            //var infoFat = "\nID da Fatura: " + txtIDFat.Text + "\nTotal: " + txtTotal.Text;
            //var infoQr = infoFat + "\n\nObrigado!";
            //var site = "\nwww.marcelomotta.com";
            //var desc = fP + infoQr + site;
            var texto = "Faturado para: "
                    + clienteF + "\nID da Fatura: "
                    + txtIDFat.Text + "\nTotal: "
                    + txtTotal.Text + "\n\nObrigado!"
                    + "\nwww.marcelomotta.com";
            Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgQr.Image = qr.Draw(texto, 50);
            //imgQr.Image qr.Draw(texto.Text, 50);
        }
        //***********************************************************//
        // #

        public frmFatura(int idRetornado)
        {
            InitializeComponent();
            carregaGrid();
            geraQrCode();
            //
            txtIDFat.Text = Convert.ToString(idRetornado);
            //
            carregaEntradasFat();
            ReloadDadosFat();
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            LoadProgBar();
            txtDataEmissao.Enabled = false;
            this.progressBar.Visible = false;
            //WindowState = FormWindowState.Maximized;
            cbxOpen.Checked = true;
            geraQrCode();
        }
        private void verificaGridVisivel()
        {
            if (gridTrabalhos.Visible == false)
            {
                gridTrabalhos.Visible = true;
                btnExcluir.Visible = true;
            }
        }
        
        //
        //*******************************************************************************************************//
        // GRIDS DE CARREGAMENTO
        //*******************************************************************************************************//
        // CARREGA DADOS DAS ENTRADAS DE TRABALHO NO GERAL
        //
        /// <summary>
        /// Carrega itens de trabalho faturados
        /// </summary>
        private void carregaEntradasFat()
        {
            int idF = Convert.ToInt32(txtIDFat.Text);
            //
            var data = from itenstrabalho in iTrabalho.listaTrabalhos()
                       where itenstrabalho.idFaturaItem == idF
                       orderby itenstrabalho.data
                       select new
                       {
                           idTrabalho = itenstrabalho.idTrabalho,
                           //projetoID = itenstrabalho.projetoID,
                           //nomeCliente = itenstrabalho.Projetos.Cliente.nome,
                           Data = itenstrabalho.data.ToShortDateString(),
                           //Projeto = itenstrabalho.Projetos.nomeProj + ": " + itenstrabalho.Tarefas.nomeTar,
                           Desc = itenstrabalho.Projetos.nomeProj + ": " + itenstrabalho.Tarefas.nomeTar + " [ " + itenstrabalho.inicio + " - " + itenstrabalho.final + " ] " + itenstrabalho.nota,
                           //Nota = itenstrabalho.nota,
                           //tarefas = itenstrabalho.tarefas,
                           //nomeTar = itenstrabalho.Tarefas.nomeTar,
                           //inicio = itenstrabalho.inicio,
                           //final = itenstrabalho.final,
                           //horas = itenstrabalho.horas,
                           Horas = itenstrabalho.horaInt,
                           Rendimento = itenstrabalho.moeda + " " + itenstrabalho.rendimento,
                           //faturado = itenstrabalho.faturado,
                           //idFaturaItem = itenstrabalho.idFaturaItem,
                       };
            gridTrabalhos.DataSource = data.ToList();
            LoadProgBar();
            //Soma();
            carregaGrid();
            //
            //foreach (DataGridViewRow row in gridTrabalhos.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (cell.ColumnIndex == gridTrabalhos.Columns["Rendimento"].Index)
            //        {
            //            cell.Style.Format = "c";
            //        }
            //    }
            //}
        }
        //
        //*******************************************************************************************************//
        //*******************************************************************************************************//
        /// <summary>
        /// CARREGA CONFIGURAÇÕES DO DATAGRID VIEW
        /// </summary>
        private void carregaGrid()
        {
            try
            {
                DataGridViewColumn coluna1 = gridTrabalhos.Columns[0];
                DataGridViewColumn coluna2 = gridTrabalhos.Columns[1];
                DataGridViewColumn coluna3 = gridTrabalhos.Columns[2];
                DataGridViewColumn coluna4 = gridTrabalhos.Columns[3];
                DataGridViewColumn coluna5 = gridTrabalhos.Columns[4];
                //DataGridViewColumn coluna6 = gridTrabalhos.Columns[5];
                //DataGridViewColumn coluna7 = gridTrabalhos.Columns[6];
                //DataGridViewColumn coluna8 = gridTrabalhos.Columns[7];
                // DataGridViewColumn coluna9 = gridTrabalhos.Columns[8];
                //***********************************************************//
                coluna1.HeaderText = "ID.";
                coluna1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna2.HeaderText = "Data";
                coluna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                coluna2.DefaultCellStyle.Format = "MM/dd/yyyy";
                coluna2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                coluna3.HeaderText = "Descrição";
                //coluna3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna4.HeaderText = "Horas";
                coluna4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                coluna5.HeaderText = "Rendimento";
                coluna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                coluna5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //coluna6.HeaderText = "Horas";
                //coluna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //coluna7.HeaderText = "Rendimento";
                //coluna7.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //coluna8.HeaderText = "Rendimento";
                //coluna8.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //coluna9.HeaderText = "Faturado";
                //coluna9.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch
            {
            }
        }
        //
        //
        // **            **             **
        //*******************************************************************************************************//
        /// <summary>
        /// Barra de progresso
        /// </summary>
        private void LoadProgBar()
        {
            var gridTotalR = gridTrabalhos.Rows.Count;
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
        //*******************************************************************************************************//
        // FUNÇÃO DOUBLE CLICK DO GRID VIEW
        //*******************************************************************************************************//
        /// <summary>
        /// Função abrir fatura ao clicar 2 vzs no item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTrabalhos_DoubleClick(object sender, EventArgs e)
        {
            int idT = Convert.ToInt32(lblIdTrabalho.Text);
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
            t.idTrabalho = Convert.ToInt32(gridTrabalhos.CurrentRow.Cells[0].Value);
            //
            var idT = t.idTrabalho;
            var pID = t.projetoID;
            var tID = t.tarefas;
            var nTar = t.Tarefas.nomeTar;
            var nProj = t.Projetos.nomeProj;
            lblIdTrabalho.Text = Convert.ToString(idT);
            //
        }
        //
        //***********************************************************//
        //                   FUNÇÃO EXCLUIR                          //
        //***********************************************************//
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var idFat = txtIDFat.Text;
            if (MessageBox.Show(string.Format("Tem Certeza que Deseja Deletar a Fatura" + idFat + " ?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //cria looping onde pega cada item do gridview
                foreach (DataGridViewRow linha in gridTrabalhos.Rows)
                {
                    //primeiro seta todos os itens como nao faturados e idfaturaitem como 0
                    //seta idRetornado como 0;
                    var idItem = Convert.ToString(linha.Cells[0].Value);
                    var idRetornado = 0;
                    var id = Convert.ToInt32(idItem);
                    var nao = 0;
                    var t = new iTrabalho();
                    t.Fatura(id, nao, idRetornado);
                    //MessageBox.Show("id:" + idItem + "alterado");
                }
                //deleta fatura pelo id
                var f = new Faturas();
                f.Deleta(Convert.ToInt32(idFat));
            }
            try
            {
                ((frmFaturas)this.Owner).reloadFaturas();
            }
            catch
            {
            }
            Close();
            //
        }
        //
        //
        //***********************************************************//
        //
        //
        /// <summary>
        /// Soma Total
        /// </summary>
        //private void Soma()
        //{
        //    decimal total = 0;
        //    foreach (DataGridViewRow row in gridTrabalhos.Rows)
        //    {
        //        total += Convert.ToDecimal(row.Cells[8].Value);
        //    }
        //    txtTotal.Text = Convert.ToString(total);
        //}
        //
        //
        /// <summary>
        /// Carrega Dados da Fatura pelo ID na textBox
        /// </summary>
        private void ReloadDadosFat()
        {
            // ID FATURA ATUAL SELECIONADO
            int idFatura = Convert.ToInt32(txtIDFat.Text);
            //
            var faturas = Faturas.porFaturaID(idFatura);
            var fatura = faturas[0];
            // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
            int idF = fatura.IDFat;
            int cF = fatura.clienteFatura;
            var nomeCliente = fatura.Cliente.nome;
            var precoHora = fatura.valorHora;
            DateTime dE = fatura.dataEmissao;
            DateTime dV = fatura.dataVencimento;
            var mF = fatura.moeda; // moeda
            var tF = fatura.totalFatura; // total fatura
            bool pg = fatura.pago;
            //
            dE.ToShortTimeString();
            dV.ToShortTimeString();
            var total = Convert.ToString(tF);
            //
            // CARREGA VARIAVEIS COM LISTA DE DADOS RETORNADOS
            lblMoeda.Text = mF;
            lblPrecoHora.Text = "Preço por Hora: " + mF + precoHora;
            //
            //
            txtIDFat.Text = Convert.ToString(idF);
            lblClienteID.Text = Convert.ToString(cF);
            lblCliente.Text = Convert.ToString(nomeCliente);
            //lblPrecoHora.Text = Convert.ToString(precoHora);
            txtDataEmissao.Text = dE.ToString("dd/MM/yyyy");
            txtDataVencimento.Text = dV.ToString("dd/MM/yyyy");
            txtTotal.Text = mF + " " + total;
            lblTotal.Text = "Valor Total da Fatura: " + mF + " " + total;
            //verifica o status da fatura e exibe como texto
            if (pg==true)
            {
                lblPago.Text = "Fatura Paga";
                btnQuitar.Text = "Cancelar Pagamento";
                btnQuitar.BackColor = System.Drawing.Color.FromArgb(100, 250, 0, 100);
            }
            else if(pg==false)
            {
                lblPago.Text = "Fatura em Aberto";
                btnQuitar.Text = "Quitar Fatura";
                btnQuitar.BackColor = System.Drawing.Color.FromArgb(41, 241, 195);
            }
            //
        }
        //
        //********************************************************************************************//
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var f = new Faturas();
            var Fatura = Convert.ToInt32(txtIDFat.Text);
            //verifica status atual e define ação do botao
            if(lblPago.Text=="Fatura em Aberto")
            {
                //entao quita a fatura
                var status = Convert.ToInt32("1");
                f.Quitar(Fatura, status);
                MessageBox.Show("Fatura Quitada com Sucesso!");
            }
            //
            if (lblPago.Text == "Fatura Paga")
            {
                //fatura ja esta paga, entao pede confirmação pra cancelar o pagamento
                if (MessageBox.Show(string.Format("Tem Certeza que Deseja Cancelar o Pagamento da Fatura " + txtIDFat.Text + " ?"), "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var status = Convert.ToInt32("0");
                    f.Quitar(Fatura, status);
                    MessageBox.Show("Confirmação de pagamento da Fatura cancelada com sucesso!", "Confirmação");
                }
            }
            ReloadDadosFat();
            ((frmFaturas)this.Owner).reloadFaturas();
        }
        //********************************************************************************************//
        /// <summary>
        /// Botão de ação de Faturamento, chama função pra criar o Documento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            var idFatura = txtIDFat.Text;
            try
            {
                DataTable dtbl = new DataTable();
                ExportaPDF(dtbl, "Fatura Detalhada #" + idFatura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        //
        /// <summary>
        /// Cria Documento de Fatura para Exportar PDF
        /// </summary>
        /// <param name="dtTable"></param>
        /// <param name="strHeader"></param>
        void ExportaPDF(DataTable dtTable, string strHeader)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 0;

            string fileName = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                Document document = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None));

                //MessageBox.Show("arquivo salvo em " + fileName);
                //System.IO.FileStream fs = new FileStream(myDocument, new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                //Document document = new Document();
                //document.SetPageSize(iTextSharp.text.PageSize.A4);
                //PdfWriter writer = PdfWriter.GetInstance(document, fs);
                //
                document.Open();
                //
                //documento aberto para escrita
                //
                //BaseFont helvTable = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                //Font fontTable = new Font(helvTable, 7, 1);
                //
                //Report Header
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntHead = new Font(bfntHead, 16, 1);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_RIGHT;
                prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
                prgHeading.IndentationRight = 40;
                prgHeading.PaddingTop = 80;
                //prgHeading.IndentationLeft = 250;
                prgHeading.SpacingAfter = 20;
                document.Add(prgHeading);
                //
                //IMAGEM DA LOGO
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("logo.jpg");
                img.SetAbsolutePosition(document.PageSize.Width - 50f - 495f , document.PageSize.Height - 50f - 100f);
                img.ScalePercent(22f);
                document.Add(img);
                //
                //
                //PEGA IMAGEM DO QR CODE GERADA AO ABRIR
                MemoryStream ms = new MemoryStream();
                imgQr.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] buff = ms.GetBuffer();
                iTextSharp.text.Image qrCode = iTextSharp.text.Image.GetInstance(buff);
                qrCode.SetAbsolutePosition(document.PageSize.Width - 65f - 48f, document.PageSize.Height - 65f - 148f);
                qrCode.ScalePercent(33f);
                document.Add(qrCode);
                //
                //Author
                Paragraph prgAuthor = new Paragraph();
                BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntAuthor = new Font(btnAuthor, 8, 2);
                prgAuthor.Alignment = Element.ALIGN_RIGHT;
                prgAuthor.IndentationRight = 35;
                prgAuthor.SpacingAfter = 20;
                prgAuthor.Add(new Chunk("Designer Responsável : Marcelo Motta", fntAuthor));
                prgAuthor.Add(new Chunk("\nTelefone/WhatsApp : (22) 9 8818-9303", fntAuthor));
                prgAuthor.Add(new Chunk("\nWebsite : www.marcelomotta.com", fntAuthor));
                document.Add(prgAuthor);
                //
                //Cliente info
                Paragraph prgCliente = new Paragraph();
                BaseFont btnCliente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntCliente = new Font(btnCliente, 8, 2);
                prgCliente.Alignment = Element.ALIGN_LEFT;
                prgCliente.IndentationLeft = 35;
                //prgCliente.SpacingAfter = 20;
                prgCliente.Add(new Chunk("Faturado para : " + lblCliente.Text, fntCliente));
                prgCliente.Add(new Chunk("\n" + lblPrecoHora.Text, fntCliente));
                prgCliente.Add(new Chunk("\nData de Emissão : " + txtDataEmissao.Text, fntCliente));
                prgCliente.Add(new Chunk("\nData de Vencimento : " + txtDataVencimento.Text, fntCliente));
                
                //
                document.Add(prgCliente);
                //
                //Add line break
                document.Add(new Chunk("\n", fntHead));
                //
                // cria tabela
                // Write the table
                //
                //BaseFont btnTable = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                //Font fntTable = new Font(btnTable, 9, 1);
                //
                iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fontHeaderTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //
                PdfPTable table = new PdfPTable(5);
                    //set overall width
                    table.WidthPercentage = 90f;
                    //table.DefaultCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                    //table.DefaultCell.BorderColor = new BaseColor(171, 183, 183);
                //set column widths
                int[] firstTablecellwidth = { 5,10,70,10,10 };
                    //table.DefaultCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                    //table.DefaultCell.Border =Rectangle.NO_BORDER;
                    table.SetWidths(firstTablecellwidth);
                //Criar colunas
                PdfPCell pi = new PdfPCell(new Phrase("ID", fontHeaderTable));
                pi.Border = Rectangle.NO_BORDER;
                pi.BackgroundColor = new BaseColor(171, 183, 183);
                pi.Padding = 5f;
                table.AddCell(pi);
                //Date
                PdfPCell date = new PdfPCell(new Phrase("Data", fontHeaderTable));
                date.Border = Rectangle.NO_BORDER;
                date.BackgroundColor = new BaseColor(171, 183, 183);
                date.Padding = 5f;
                table.AddCell(date);

                PdfPCell desc = new PdfPCell(new Phrase("Descrição", fontHeaderTable));
                desc.Border = Rectangle.NO_BORDER;
                desc.BackgroundColor = new BaseColor(171, 183, 183);
                desc.Padding = 5f;
                table.AddCell(desc);

                PdfPCell rendimento = new PdfPCell(new Phrase("Horas", fontHeaderTable));
                rendimento.Border = Rectangle.NO_BORDER;
                rendimento.BackgroundColor = new BaseColor(171, 183, 183);
                rendimento.Padding = 5f;
                table.AddCell(rendimento);

                PdfPCell def = new PdfPCell(new Phrase("Preço", fontHeaderTable));
                def.Border = Rectangle.NO_BORDER;
                def.BackgroundColor = new BaseColor(171, 183, 183);
                def.Padding = 5f;
                table.AddCell(def);
                    table.HeaderRows = 1;
                //table.DefaultCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                // add header from dgv
                //for (int j = 0; j < gridTrabalhos.Columns.Count; j++)
                //{
                //    table.AddCell(new Phrase(gridTrabalhos.Columns[j].HeaderText, fontTable));
                //}
                //flag first row as header
                //table.HeaderRows = 1;
                // add atual rows from dgv to table

                for (int i = 0; i < gridTrabalhos.Rows.Count; i++)
                {
                    for (int k = 0; k < gridTrabalhos.Columns.Count; k++)
                    {
                        if (gridTrabalhos[k, i].Value != null)
                        {
                            PdfPCell item = new PdfPCell(new Phrase(gridTrabalhos[k, i].Value.ToString(), fontTable));
                            //item.Border = Rectangle.NO_BORDER;
                            item.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                            item.BorderColor = new BaseColor(171, 183, 183);
                            item.BackgroundColor = new BaseColor(238,238,238);
                            item.Padding = 5f;
                            table.AddCell(item);
                            //table.AddCell(new Phrase(gridTrabalhos[k, i].Value.ToString(), fontTable));
                        }
                    }
                }
                //
                table.SpacingAfter = 10;
                document.Add(table);
                //
                //
                //Footer > detalhes totalizadores
                Paragraph prgTotalDet = new Paragraph();
                BaseFont btnTotalDet = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntTotalDet = new Font(btnTotalDet, 8, 2);
                prgTotalDet.Alignment = Element.ALIGN_RIGHT;
                prgTotalDet.IndentationRight = 35;
                //prgTotalDet.SpacingAfter = 20;
                //
                //Conta linhas do gridview pra exibir a contagem de entradas
                int linhas = gridTrabalhos.Rows.Count;
                //soma horas pra exibir a contagem
                decimal totalH = 0;
                foreach (DataGridViewRow row in gridTrabalhos.Rows)
                {
                    totalH += Convert.ToDecimal(row.Cells[3].Value);
                }
                var totalHoras = Convert.ToString(totalH);
                //
                prgTotalDet.Add(new Chunk("\nContagem Final de " + Convert.ToString(linhas) + " Entradas de Trabalho, com um total de " + totalHoras + " Horas Trabalhadas.", fntTotalDet));
                document.Add(prgTotalDet);
                //
                //Add a line seperation
                Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 90.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)));
                //p.SpacingAfter = 20;
                document.Add(p);
                //
                //Footer > TOTAL FATURA
                Paragraph prgTotal = new Paragraph();
                BaseFont btnTotal = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntTotal = new Font(btnTotal, 12, 2);
                prgTotal.Alignment = Element.ALIGN_RIGHT;
                prgTotal.IndentationRight = 35;
                //prgTotal.SpacingAfter = 10;
                prgTotal.Add(new Chunk("Valor devido : " + txtTotal.Text, fntTotal));
                document.Add(prgTotal);
                document.Close();
                writer.Close();
                //
                //verifica opção abrir apos salvar
                if (cbxOpen.Checked)
                {
                    System.Diagnostics.Process.Start(fileName);
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                }
                else
                {
                    MessageBox.Show("Arquivo Salvo com Sucesso!\nDiretório: " + fileName);
                }
            }
        }
        //********************************************************************************************//
        //********************************************************************************************//
        //********************************************************************************************//
        //********************************************************************************************//
        //
        //
    }
}
//********************************************************************************************//
//********************************************************************************************//
//************************************** F I M ***********************************************//
//********************************************************************************************//
//********************************************************************************************//
//
//********************************************************************************************//
//
//********************************************************************************************//
//********************************************************************************************//

