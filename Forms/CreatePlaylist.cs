namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CreatePlaylist : Form
    {
        //Property which will contain the playlist
        public IList<SongView> Playlist { get; private set; }

        CDCatalogRepository repository = new CDCatalogRepository();

        public CreatePlaylist()
        {
            InitializeComponent();

#if DEBUG
            createPlaylistTextBox.Text = "30";
#endif
        }

        private void createPlaylistButton_Click(object sender, System.EventArgs e)
        {
            var formHelper = new FormHelper();
            int playlistLengthInMinutes;

            //Check that a number was entered into the textbox
            if (int.TryParse(createPlaylistTextBox.Text.Trim(), out playlistLengthInMinutes))
            {
                Playlist = repository.GeneratePlaylist(playlistLengthInMinutes);
                Close();
            }
            else
            {
                //if no number entered, display error message and prevent form from closing.
                MessageBox.Show("Please enter the number of minutes you'd like the playlist to be in length.", "Input validation error");
                DialogResult = DialogResult.None;
            }
        }
    }
}
