namespace CDCatalog
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void genreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addGenre = new AddGenre();
            addGenre.Show();
        }
    }
}
