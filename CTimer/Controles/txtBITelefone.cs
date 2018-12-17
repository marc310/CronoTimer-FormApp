using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CTimer.Controles
{
    class txtBITelefone : MaskedTextBox
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.Text != "")
            {
                //this.Text.Replace("R$", "");
                //this.SelectAll();
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.GhostWhite;
            this.SelectAll();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;
                MessageBox.Show("Digite apenas números!");
            }
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.LightGray;

            

            //if (this.Text == "")
            //    return;
            //try
            //{
            //    int valor = Convert.ToInt32(this.Text);
            //    //this.Text = string.Format("{0:(##) ####-####}", valor);
            //}
            //catch
            //{
            //    this.Text = "";
            //    MessageBox.Show("Digite apenas números!");
            //}
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BackColor = Color.LightGray;
            //this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
