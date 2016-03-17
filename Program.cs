namespace CDCatalog
{
    using CDCatalog.Forms;
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Holy cow, I can't believe you managed to screw this up so bad.\n" + ex.GetBaseException().Message, "Thanks a lot!");
            }
        }
    }
}
