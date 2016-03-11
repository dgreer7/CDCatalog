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

        private void songToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addSong = new AddSong();
            addSong.Show();
        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //Upon resizing of form, keep datagrid sized with the window
            KeepDataGridSizedWithWindow();
        }

        private void KeepDataGridSizedWithWindow()
        {
            mainFormDataGridView.Width = ClientSize.Width;
            mainFormDataGridView.Height = ClientSize.Height;
        }
    }
}
