using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace CTimer
{
    public class txtMoeda : TextBox
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.Text!="")
            {
                //this.Text.Replace("R$", "");
                this.SelectAll();
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.GhostWhite;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.LightGray;

            if (this.Text == "")
                return;
            try
            {
                //double valor = Convert.ToDouble(this.Text.Replace("R$", ""));
                //this.Text = string.Format("{0:c}", valor);
                double valor = Convert.ToDouble(this.Text);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor incorreto!");
            }
            
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
