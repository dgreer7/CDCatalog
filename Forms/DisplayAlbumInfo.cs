namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class DisplayAlbumInfo : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        public AlbumView Album { get; private set; }
        public IList<SongView> SongsInAlbum { get; private set; }

        public DisplayAlbumInfo(int albumId)
        {
            InitializeComponent();
            GetAlbumInformation(albumId);
            UpdateLabelText();
            SongsInAlbum = repository.SearchSongsByAlbumID(albumId);
            UpdateDataGridForShowingSongData();
        }

        private void UpdateDataGridForShowingSongData()
        {
            displayAlbumInfoDataGridView.DataSource = SongsInAlbum;
            var titleHeaderIndex = 0;

            //iterates through data headers
            for (int i = 0; i < displayAlbumInfoDataGridView.Columns.Count; i++)
            {
                //rename header for track length
                if (displayAlbumInfoDataGridView.Columns[i].HeaderText == "Track_Length_Seconds")
                {
                    displayAlbumInfoDataGridView.Columns[i].HeaderText = "Length\n(Sec)";
                }
                //sets the header name to variable
                string columnHeaderName = displayAlbumInfoDataGridView.Columns[i].HeaderText;

                if (columnHeaderName == "SongID" || columnHeaderName == "Artist")
                {
                    //removes column from view and decrements i as the count is adjusted by the removal
                    displayAlbumInfoDataGridView.Columns.RemoveAt(i);
                    i--;
                }

                //marks the title header index
                else if (columnHeaderName == "Title")
                    titleHeaderIndex = i;

                else
                    //size column to fit around data in cells
                    displayAlbumInfoDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            //gives extra space to title column
            displayAlbumInfoDataGridView.Columns[titleHeaderIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateLabelText()
        {
            displayAlbumTitle.Text = string.Format("Album: {0}", Album.Title);
            displayAlbumArtist.Text = string.Format("Artist: {0}", Album.Artist_Name);
            displayAlbumYear.Text = string.Format("Created in: {0}", Album.Year);
            if (Album.Rating == 0)
                displayAlbumRating.Text = "Album not rated";
            else
                displayAlbumRating.Text = "Rated: " + Album.Rating;
        }

        private void GetAlbumInformation(int albumId)
        {

            Album = repository.GetAlbumViewByID(albumId);
        }

        private void DisplayAlbumInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void DisplayAlbumInfo_Resize(object sender, System.EventArgs e)
        {
            //Keeps datagrid buffered inside window
            displayAlbumInfoDataGridView.Width = ClientSize.Width - (displayAlbumInfoDataGridView.Location.X * 2);
            //datagrid height is keep inside window with same buffer as on sides
            displayAlbumInfoDataGridView.Height =
                ClientSize.Height - displayAlbumInfoDataGridView.Location.Y - displayAlbumInfoDataGridView.Location.X;
        }
    }
}
