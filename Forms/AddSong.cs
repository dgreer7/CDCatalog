namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class AddSong : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();

        public AddSong()
        {
            InitializeComponent();
            InitializeGenreComboBox();
            InitializeAlbumComboBox();
            InitializeArtistComboBox();
            addSongComboBoxArtist.Visible = false;
            addSongLabelSongArtist.Visible = false;
            addSongButtonAddArtist.Visible = false;

#if DEBUG
            addSongTextBoxSongTitle.Text = "Awesome Song";
            addSongTextBoxSongTrackNumber.Text = "1";
            addSongTextBoxSongLength.Text = "120";
#endif
        }

        private void InitializeArtistComboBox()
        {
            addSongComboBoxArtist.DataSource = repository.GetAllArtists();
            addSongComboBoxArtist.DisplayMember = "ArtistName";
            addSongComboBoxArtist.ValueMember = "ArtistId";
        }

        private void InitializeGenreComboBox()
        {
            addSongComboBoxGenre.DataSource = repository.GetAllGenres();
            addSongComboBoxGenre.DisplayMember = "GenreName";
            addSongComboBoxGenre.ValueMember = "GenreId";
        }

        private void InitializeAlbumComboBox()
        {
            addSongComboBoxAlbum.DataSource = repository.GetAllAlbums();
            addSongComboBoxAlbum.DisplayMember = "Title";
            addSongComboBoxAlbum.ValueMember = "AlbumId";
        }

        private void addSongButton_Click(object sender, System.EventArgs e)
        {
            //using FormHelper, validate that required fileds are filled with data
            var formHelper = new FormHelper();
            var requiredFields = new List<TextBox> { addSongTextBoxSongTitle, addSongTextBoxSongLength };

            if (addSongTextBoxSongTrackNumber.Visible)
                requiredFields.Add(addSongTextBoxSongTrackNumber);

            if (formHelper.NotNull(requiredFields))
            {
                Artist artist;
                Album album;
                var genre = (Genre)addSongComboBoxGenre.SelectedItem;

                
                GetArtistAndAlbum(out artist, out album);

                //use helper to album rating, defaults to 0 if not filled.
                var rating = formHelper.GetIntFromTextBox(addSongTextBoxRating) != -1 ? formHelper.GetIntFromTextBox(addSongTextBoxRating) : 0;

                repository.CreateSong(addSongTextBoxSongTitle.Text, artist, genre, 120, 0, album, 0);
                Close();
            }
            else
            {
                addSongLabelSongTitle.ForeColor = System.Drawing.Color.Red;
                addSongLabelSongLength.ForeColor = System.Drawing.Color.Red;
                if (addSongTextBoxSongTrackNumber.Visible)
                    addSongLabelSongTrackNumber.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Required field missing.");
            }
        }

        private void GetArtistAndAlbum(out Artist artist, out Album album)
        {
            //determine if populating album if so, pull artist from there
            if (addSongCheckBoxSongToAlbum.Checked)
            {
                //pulls the selected album from the dropdown list
                album = (Album)addSongComboBoxAlbum.SelectedItem;
                artist = repository.GetArtistByID(album.ArtistId);
            }
            else
            {
                //pulls the selected artist from the dropdown list
                artist = (Artist)addSongComboBoxArtist.SelectedItem;
                album = null;
            }
        }

        private void addSongCheckBoxSong_CheckedChanged(object sender, System.EventArgs e)
        {
            addSongComboBoxArtist.Visible = !addSongComboBoxArtist.Visible;
            addSongLabelSongArtist.Visible = !addSongLabelSongArtist.Visible;
            addSongComboBoxAlbum.Visible = !addSongComboBoxAlbum.Visible;
            addSongLabelSongAlbum.Visible = !addSongLabelSongAlbum.Visible;
            addSongTextBoxSongTrackNumber.Visible = !addSongTextBoxSongTrackNumber.Visible;
            addSongLabelSongTrackNumber.Visible = !addSongLabelSongTrackNumber.Visible;
            addSongButtonAddArtist.Visible = !addSongButtonAddArtist.Visible;
        }
    }
}
