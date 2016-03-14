namespace CDCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    class FormHelper
    {
        /// <summary>
        /// Will take a list of TextBox and determine if all TextBoxes have contents.
        /// </summary>
        /// <param name="listOfTextBox"></param>
        /// <returns>Boolean</returns>
        internal bool TextBoxHasContents(IList<TextBox> listOfTextBox)
        {
            foreach (TextBox textBox in listOfTextBox)
            {
                if (!TextBoxHasContents(textBox))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Will take a TextBox and determine if it has contents.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>Boolean</returns>
        internal bool TextBoxHasContents(TextBox textBox)
        {
            if (textBox.Text.Trim().Length == 0 || textBox == null)
                return false;
            else
                return true;
        }


        internal int GetIntFromTextBox(TextBox textBox)
        {
            try
            {
                return Int32.Parse(textBox.Text);
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
    }
}
