using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace CalculadoraWPF
{
    internal class MyTextBox : TextBox
    {
        protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewGotKeyboardFocus(e);
        }

    }
}
