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
            var rand = new System.Random();
            rand.Next(18);
            addSongTextBoxSongTitle.Text = "Awesome Song";
            addSongTextBoxSongTrackNumber.Text = rand.Next(18).ToString();
            addSongTextBoxSongLength.Text = rand.Next(105, 1000).ToString();
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

            if (formHelper.TextBoxHasContents(requiredFields))
            {
                Artist artist;
                Album album;
                var genre = (Genre)addSongComboBoxGenre.SelectedItem;

                
                GetArtistAndAlbum(out artist, out album);

                //use helper to album rating, defaults to 0 if not filled.
                var rating = formHelper.GetIntFromTextBox(addSongTextBoxRating) != -1 ? formHelper.GetIntFromTextBox(addSongTextBoxRating) : 0;
                var trackLength = formHelper.GetIntFromTextBox(addSongTextBoxSongLength);
                var trackNumber = formHelper.GetIntFromTextBox(addSongTextBoxSongTrackNumber);

                repository.CreateSong(addSongTextBoxSongTitle.Text, artist, genre, trackLength, rating, album, trackNumber);
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

        private void addSongButtonAddGenre_Click(object sender, System.EventArgs e)
        {
            var addGenre = new AddGenre();
            addGenre.ShowDialog();

            if (addGenre.CreatedGenre != null)
            {
                InitializeGenreComboBox();
                addSongComboBoxGenre.SelectedValue = addGenre.CreatedGenre.GenreId;
            }
        }

        private void addSongButtonAddAlbum_Click(object sender, System.EventArgs e)
        {
            var addAlbum = new AddAlbum();
            addAlbum.ShowDialog();

            if (addAlbum.CreatedAlbum != null)
            {
                InitializeAlbumComboBox();
                addSongComboBoxAlbum.SelectedValue = addAlbum.CreatedAlbum.AlbumId;
            }
        }

        private void addSongButtonAddArtist_Click(object sender, System.EventArgs e)
        {
            var addArtist = new AddArtist();
            addArtist.ShowDialog();

            if (addArtist.CreatedArtist != null)
            {
                InitializeArtistComboBox();
                addSongComboBoxArtist.SelectedValue = addArtist.CreatedArtist.ArtistId;
            }
        }
    }
}
