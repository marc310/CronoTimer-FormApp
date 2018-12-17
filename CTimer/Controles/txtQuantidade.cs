using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace CTimer.Controles
{
    class txtQuantidade : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.Gray;
            this.SelectAll();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.GhostWhite;

            if (this.Text=="")
                return;
            try
            {
                Convert.ToInt32(this.Text);
            }
            catch 
            {
                this.Text = "";
                MessageBox.Show("Valor incorreto, utilize apenas números inteiros!");
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyCode==Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
