namespace CDCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    class FormHelper
    {
        internal bool NotNull(List<TextBox> nonNullableTextBoxes)
        {
            foreach (TextBox txtBox in nonNullableTextBoxes)
            {
                if (txtBox.Text.Trim().Length == 0 || txtBox == null)
                    return false;
            }
            return true;
        }

        internal int GetIntFromTextBox(TextBox textbox)
        {
            try
            {
                return Int32.Parse(textbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Value provided must be a number.");
                return -1;
            }
            
        }
    }
}
