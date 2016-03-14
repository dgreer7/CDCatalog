namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CreatePlaylist : Form
    {
        public IList<Song> Playlist { get; private set; }

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

            if (formHelper.TextBoxNotNull(new List<TextBox>() { createPlaylistTextBox }))
            {
                var songLengthMinutes = formHelper.GetIntFromTextBox(createPlaylistTextBox);

                Playlist = repository.GeneratePlaylist(songLengthMinutes);
                Close();
            }
        }
    }
}
