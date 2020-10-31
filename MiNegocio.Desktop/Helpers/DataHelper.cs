using System;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Helpers
{
    internal static class DataHelper
    {
        internal static void Textbox_KeyPress(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }
    }
}
