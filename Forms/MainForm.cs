namespace CDCatalog.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private const string ERRORMESSAGE = "Way to go, you broke it.\n";

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
            mainFormDataGridView.Height = ClientSize.Height - menuStrip1.Height;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                //Upon resizing of form, keep datagrid sized with the window
                KeepDataGridSizedWithWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }

        }

        private void genreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var addGenre = new AddGenre();
                addGenre.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }

        private void albumnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var addAlbum = new AddAlbum();
                addAlbum.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }

        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addArtist = new AddArtist();
                addArtist.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }

        }

        private void songToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var addSong = new AddSong();
                addSong.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }

        }

        private void findGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }

        private void findAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findAlbum = new FindAlbum();
                var dialogResult = findAlbum.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    mainFormDataGridView.DataSource = findAlbum.FoundAlbums;
                    for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                    {
                        string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                        if (columnHeaderName == "Title" || columnHeaderName == "Year" || columnHeaderName == "Rating" || columnHeaderName == "Artist_Name")
                        {
                            if (columnHeaderName == "Artist_Name")
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
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }

        private void findSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findSong = new FindSong();
                var dialogResult = findSong.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    mainFormDataGridView.DataSource = findSong.FoundSongs;
                    var titleHeaderIndex = 0;

                    for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                    {

                        if (mainFormDataGridView.Columns[i].HeaderText == "Track_Length_Seconds")
                        {
                            mainFormDataGridView.Columns[i].HeaderText = "Length (Sec)";
                        }

                        string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;

                        if (columnHeaderName == "SongID")
                        {
                            mainFormDataGridView.Columns.Remove(columnHeaderName);
                            i--;
                        }

                        else if (columnHeaderName == "Title")
                            titleHeaderIndex = i;

                        else
                            mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                        mainFormDataGridView.Columns[titleHeaderIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var createPlaylist = new CreatePlaylist();
                var dialogResult = createPlaylist.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    mainFormDataGridView.DataSource = createPlaylist.Playlist;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }

        private void ratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainFormDataGridView.RowCount == 0)
                {
                    MessageBox.Show("Please find either a song or album to update.");
                }
                else if (mainFormDataGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select the song or album to update.");
                }
                else
                {
                    //will get the type of data stored in the datagridview
                    var selectedValue = mainFormDataGridView.SelectedRows[0].DataBoundItem;
                    if (selectedValue.GetType() == typeof(SongView))
                    {
                        //cast selected line as a SongView
                        var selectedSong = selectedValue as SongView;

                        var updateSong = new UpdateSong(selectedSong.Title, selectedSong.Album);
                        var dialogResult = updateSong.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            //Clear the datagridview
                            mainFormDataGridView.DataSource = null;
                            mainFormDataGridView.Rows.Clear();
                            mainFormDataGridView.Refresh();
                        }
                    }
                    else if (selectedValue.GetType() == typeof(AlbumView))
                    {
                        //cast selected line as a AlbumView
                        var selectedAlbum = selectedValue as AlbumView;

                        var albumView = new UpdateAlbum(selectedAlbum.Title, selectedAlbum.Artist_Name);
                        var dialogResult = albumView.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            //Clear the datagridview
                            mainFormDataGridView.DataSource = null;
                            mainFormDataGridView.Rows.Clear();
                            mainFormDataGridView.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Please find either a song or album to update", "Data validation error"));
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
            }
        }
    }
}
