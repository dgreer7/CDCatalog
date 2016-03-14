namespace CDCatalog.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            KeepDataGridSizedWithWindow();
            mainFormDataGridView.RowHeadersVisible = false;
#if DEBUG
            Text = (int)(new DateTime(2016, 03, 23) - DateTime.Now).TotalDays + " days left!!";
#endif
        }

        private void KeepDataGridSizedWithWindow()
        {
            mainFormDataGridView.Width = ClientSize.Width;
            mainFormDataGridView.Height = ClientSize.Height;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //Upon resizing of form, keep datagrid sized with the window
            KeepDataGridSizedWithWindow();
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

        private void findGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findGenre = new FindGenre();
            var dialogResult = findGenre.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mainFormDataGridView.DataSource = findGenre.FoundGenres;
                for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                {
                    string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                    if (columnHeaderName == "GenreName")
                    {
                        mainFormDataGridView.Columns[i].HeaderText = "Genre Name";
                        mainFormDataGridView.Columns[i].Width = mainFormDataGridView.Width;
                    }
                    else
                    {
                        mainFormDataGridView.Columns.Remove(columnHeaderName);
                        i--;
                    }
                }
            }
        }

        private void findAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findAlbum = new FindAlbum();
            var dialogResult = findAlbum.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mainFormDataGridView.DataSource = findAlbum.FoundAlbums;
                for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                {
                    string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                    if (columnHeaderName == "Title" || columnHeaderName == "Year" || columnHeaderName == "Rating" || columnHeaderName == "ArtistName")
                    {
                        if (columnHeaderName == "ArtistName")
                        {
                            mainFormDataGridView.Columns[i].HeaderText = "Artist";
                        }
                            mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                    else
                    {
                        mainFormDataGridView.Columns.Remove(columnHeaderName);
                        i--;
                    }
                    mainFormDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void findSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findSong = new FindSong();
            var dialogResult = findSong.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mainFormDataGridView.DataSource = findSong.FoundSongs;
                for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                {
                    //string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                    //if (columnHeaderName == "Title" || columnHeaderName == "Year" || columnHeaderName == "Rating" || columnHeaderName == "ArtistName")
                    //{
                    //    if (columnHeaderName == "ArtistName")
                    //    {
                    //        mainFormDataGridView.Columns[i].HeaderText = "Artist";
                    //    }
                    //    mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    //}
                    //else
                    //{
                    //    mainFormDataGridView.Columns.Remove(columnHeaderName);
                    //    i--;
                    //}
                    //mainFormDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createPlaylist = new CreatePlaylist();
            var dialogResult = createPlaylist.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mainFormDataGridView.DataSource = createPlaylist.Playlist;
            }
        }
    }
}
