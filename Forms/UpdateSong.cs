namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class UpdateSong : Form
    {
        private string SongTitleToUpdate { get; set; }
        private string AlbumTitleOfSong { get; set; }


        public UpdateSong(string songTitle, string albumName = null)
        {
            SongTitleToUpdate = songTitle;
            AlbumTitleOfSong = albumName;
            InitializeComponent();
            updateSongLabel.Text = string.Format("Update rating of {0} by {1}:", SongTitleToUpdate, AlbumTitleOfSong);
        }

        private void updateSongButton_Click(object sender, System.EventArgs e)
        {
            var repository = new CDCatalogRepository();
            var formHelper = new FormHelper();

            int songRating = 0;

            if (int.TryParse(updateSongTextBox.Text.Trim(), out songRating) && songRating >= 0 && songRating <= 5)
            {
                var album = repository.SearchAlbumsByAlbumTitleExclusive(AlbumTitleOfSong);
                repository.UpdateSongRating(SongTitleToUpdate, songRating, album[0]);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a rating can only be between 1 and 5", "Input validation error");
                updateSongTextBox.Focus();
            }
        }
    }
}
