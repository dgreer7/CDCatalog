namespace CDCatalog.Forms
{
    using CDCatalog;
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

        private void albumnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addAlbum = new AddAlbum();
            addAlbum.Show();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addArtist = new AddArtist();
            addArtist.Show();
        }
    }
}
