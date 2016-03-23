namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class DisplaySongInfo : Form
    {
        public SongView Song { get; private set; }

        public DisplaySongInfo(int songId)
        {
            InitializeComponent();
            GetSongInformation(songId);
            UpdateLabelText();

        }

        private void UpdateLabelText()
        {
            displaySongAlbum.Text = string.Format("Album Title: {0}", Song.Album);
            displaySongArtist.Text = string.Format("Artist : {0}", Song.Artist);
            displaySongLength.Text = string.Format("Song Length: {0} seconds", Song.Track_Length_Seconds);
            displaySongTrackNumber.Text = string.Format("Track number: {0}", Song.Track);
            displaySongTitle.Text = string.Format("Song Title: {0}", Song.Title);
            if (Song.Rating == 0)
                displaySongRating.Text = "Song is unrated";
            else
                displaySongRating.Text = string.Format("Song's rating: {0}", Song.Rating);
        }

        private void GetSongInformation(int songId)
        {
            var repository = new CDCatalogRepository();
            Song = repository.GetSongViewByID(songId);
        }

        private void DisplaySongInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
