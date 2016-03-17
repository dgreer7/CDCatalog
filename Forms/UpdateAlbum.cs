namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;
    public partial class UpdateAlbum : Form
    {
        private string AlbumTitle { get; set; }
        private string AlbumArtist { get; set; }

        public UpdateAlbum(string albumTitle, string albumArtist)
        {
            AlbumTitle = albumTitle;
            AlbumArtist = albumArtist;
            InitializeComponent();
            updateAlbumLabel.Text = string.Format("Update rating of {0} by {1}:", AlbumTitle, AlbumArtist);
        }

        private void updateAlbumButton_Click(object sender, System.EventArgs e)
        {
            var repository = new CDCatalogRepository();
            var formHelper = new FormHelper();

            int albumRating = 0;

            if (int.TryParse(updateAlbumTextBox.Text.Trim(), out albumRating) && albumRating >= 0 && albumRating <= 5)
            {
                repository.UpdateAlbumRating(AlbumTitle, albumRating, AlbumArtist);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a rating can only be between 1 and 5", "Input validation error");
                updateAlbumTextBox.Focus();
                DialogResult = DialogResult.None;
            }
        }
    }
}
