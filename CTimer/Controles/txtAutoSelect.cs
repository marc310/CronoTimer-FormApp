using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CTimer.Controles
{
    class txtAutoSelect : TextBox
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.Text != "")
            {
                this.BackColor = Color.Gray;
                this.SelectAll();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.GhostWhite;

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.LightGray;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.LightGray;
        }
    }
}
