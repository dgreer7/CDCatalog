namespace CDCatalog.Forms
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        //Set general error message should exception occur
        private const string ERRORMESSAGE = "Way to go, you broke it.\n";

        public MainForm()
        {
            InitializeComponent();
            KeepDataGridSizedWithWindow();
            //supresses row header on datagrid
            mainFormDataGridView.RowHeadersVisible = false;
#if DEBUG
            Text = (int)(new DateTime(2016, 03, 23) - DateTime.Now).TotalDays + " days left!!";
#endif
        }

        //will keep the datagrid sized with the window
        private void KeepDataGridSizedWithWindow()
        {
            mainFormDataGridView.Width = ClientSize.Width;
            //datagrid height is equal to client height less the menustrip height
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
                DisplayErrorMessageBox(ex);
            }

        }

        private void addGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addGenre = new AddGenre();
                addGenre.Show();
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
            }
        }

        private void addAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addAlbum = new AddAlbum();
                addAlbum.Show();
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
            }

        }

        private void addArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var addArtist = new AddArtist();
                addArtist.Show();
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
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
                DisplayErrorMessageBox(ex);
            }

        }

        private void findGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findGenre = new FindGenre();
                var dialogResult = findGenre.ShowDialog();

                //check to see if user completed the dialog box and therefore FoundGenres should not be null
                if (dialogResult == DialogResult.OK)
                {
                    //Clear datagrid to prevent any collisions
                    ClearDataGrid();
                    //sets datagrid to get information from the results of the findGenre form
                    mainFormDataGridView.DataSource = findGenre.FoundGenres;
                    //iterates through data headers
                    for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                    {
                        string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                        if (columnHeaderName == "GenreName")
                        {
                            //update the name and fill the view with only this column
                            mainFormDataGridView.Columns[i].HeaderText = "Genre Name";
                            mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        else
                        {
                            //remove the column from view
                            mainFormDataGridView.Columns.Remove(columnHeaderName);
                            i--;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
            }
        }

        private void findAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findAlbum = new FindAlbum();
                var dialogResult = findAlbum.ShowDialog();

                //check to see if user completed the dialog box and therefore FoundGenres should not be null
                if (dialogResult == DialogResult.OK)
                {
                    //Clear datagrid to prevent any collisions
                    ClearDataGrid();
                    //sets datagrid to get information from the results of the findAlbum form
                    mainFormDataGridView.DataSource = findAlbum.FoundAlbums;
                    //iterates through data headers
                    for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
                    {
                        string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;
                        if (columnHeaderName == "Title" || columnHeaderName == "Year" || columnHeaderName == "Rating" || columnHeaderName == "Artist_Name")
                        {
                            if (columnHeaderName == "Artist_Name")
                            {
                                mainFormDataGridView.Columns[i].HeaderText = "Artist";
                            }
                            //size column to fit around data in cells
                            mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                        else
                        {
                            //remove the column from view
                            mainFormDataGridView.Columns.Remove(columnHeaderName);
                            i--;
                        }
                        //gives extra space to title column
                        mainFormDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
            }
        }

        private void findSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findSong = new FindSong(false);
                var dialogResult = findSong.ShowDialog();

                //check to see if user completed the dialog box and therefore FoundGenres should not be null
                if (dialogResult == DialogResult.OK)
                {
                    //Clear datagrid to prevent any collisions
                    ClearDataGrid();
                    //sets datagrid to get information from the results of the findSong form
                    mainFormDataGridView.DataSource = findSong.FoundSongs;
                    UpdateDataGridForShowingSongData();
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
            }
        }

        private void findAlbumOrSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var findSong = new FindSong(true);
                var dialogResult = findSong.ShowDialog();

                //check to see if user completed the dialog box and therefore FoundGenres should not be null
                if (dialogResult == DialogResult.OK)
                {
                    //Clear datagrid to prevent any collisions
                    ClearDataGrid();
                    //sets datagrid to get information from the results of the findSong form
                    mainFormDataGridView.DataSource = findSong.FoundAlbumsAndSongs;
                    UpdateDataGridForShowingSongData();
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
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
                    //Clear datagrid to prevent any collisions
                    ClearDataGrid();
                    //sets datagrid to get information from the results of the createPlaylist form
                    mainFormDataGridView.DataSource = createPlaylist.Playlist;
                    UpdateDataGridForShowingSongData();
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessageBox(ex);
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
                            ClearDataGrid();
                        }
                    }
                    else if (selectedValue.GetType() == typeof(AlbumSongResult))
                    {
                        //cast selected line as a AlbumView
                        var selectedAlbumOrSong = selectedValue as AlbumSongResult;
                        //set dialogResult to none
                        var dialogResult = DialogResult.None;

                        if (selectedAlbumOrSong.Type == "Song")
                        {
                            var updateSong = new UpdateSong(selectedAlbumOrSong.Title);
                            dialogResult = updateSong.ShowDialog();
                        }
                        else if (selectedAlbumOrSong.Type == "Album")
                        {
                            var albumView = new UpdateAlbum(selectedAlbumOrSong.Title, selectedAlbumOrSong.ArtistName);
                            dialogResult = albumView.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Please find either a song or album to update.");
                        }

                        if (dialogResult == DialogResult.OK)
                        {
                            //Clear the datagridview
                            ClearDataGrid();
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
                DisplayErrorMessageBox(ex);
            }
        }

        private void DisplayErrorMessageBox(Exception ex)
        {
            MessageBox.Show(ERRORMESSAGE + ex.GetBaseException().Message, "Nice job!");
        }

        private void ClearDataGrid()
        {
            //Sets datasource to null
            mainFormDataGridView.DataSource = null;
            //removes all rows
            mainFormDataGridView.Rows.Clear();
            //refreashes to ready for new data
            mainFormDataGridView.Refresh();
        }

        private void UpdateDataGridForShowingSongData()
        {
            var titleHeaderIndex = 0;

            //iterates through data headers
            for (int i = 0; i < mainFormDataGridView.Columns.Count; i++)
            {
                //rename header for track length
                if (mainFormDataGridView.Columns[i].HeaderText == "Track_Length_Seconds")
                {
                    mainFormDataGridView.Columns[i].HeaderText = "Length\n(Sec)";
                }
                //sets the header name to variable
                string columnHeaderName = mainFormDataGridView.Columns[i].HeaderText;

                if (columnHeaderName == "SongID")
                {
                    //removes column from view and decrements i as the count is adjusted by the removal
                    mainFormDataGridView.Columns.Remove(columnHeaderName);
                    i--;
                }

                //marks the title header index
                else if (columnHeaderName == "Title")
                    titleHeaderIndex = i;

                else
                    //size column to fit around data in cells
                    mainFormDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                //gives extra space to title column
                mainFormDataGridView.Columns[titleHeaderIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
