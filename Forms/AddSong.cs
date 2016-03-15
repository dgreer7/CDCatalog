namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class AddSong : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        FormHelper formHelper = new FormHelper();
        private const int MINSONGLENGTH = 20;
        private const int MAXSONGLENGTH = 999;

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
            int rating, songLength, trackNumber;
            if (IsFormDataValid(out rating, out songLength, out trackNumber))
            {
                Artist artist;
                Album album;
                var genre = (Genre)addSongComboBoxGenre.SelectedItem;

                GetArtistAndAlbum(out artist, out album);

                repository.CreateSong(addSongTextBoxSongTitle.Text, artist, genre, songLength, rating, album, trackNumber);
                Close();
            }
        }

        private bool IsFormDataValid(out int rating, out int songLength, out int trackNumber)
        {
            var formDataValid = true;

            //Data validation for song title textbox
            if (!formHelper.TextBoxHasContents(addSongTextBoxSongTitle))
            {
                MessageBox.Show("Please enter a song name.", "Input validation error");
                addSongTextBoxSongTitle.Focus();
                formDataValid = false;
            }

            //Data validation for song length
            if (!formHelper.TextBoxHasContents(addSongTextBoxSongLength))
            {
                MessageBox.Show("Please enter the song length in seconds.", "Input validation error");
                addSongTextBoxSongLength.Focus();
                formDataValid = false;
            }

            //Data validation for track number if adding to album
            trackNumber = 0;
            if (addSongTextBoxSongTrackNumber.Visible && !formHelper.TextBoxHasContents(addSongTextBoxSongTrackNumber) 
                && int.TryParse(addSongTextBoxSongTrackNumber.Text.Trim(), out trackNumber) && trackNumber == 0)
            {
                MessageBox.Show("Please enter the track number which must be greater than 0.", "Input validation error");
                addSongTextBoxSongTrackNumber.Focus();
                formDataValid = false;
            }

            //Validate that if song length field contains data as is withing app config set mins and max.
            songLength = 0;
            if (!formHelper.TextBoxHasContents(addSongTextBoxSongLength) || !int.TryParse(addSongTextBoxSongLength.Text.Trim(), out songLength) || songLength < MINSONGLENGTH || songLength > MAXSONGLENGTH)
            {
                MessageBox.Show(string.Format("Song length can only be between {0} and {1} seconds.", MINSONGLENGTH, MAXSONGLENGTH), "Input validation error");
                addSongTextBoxSongLength.Focus();
                formDataValid = false;
            }

            rating = 0;
            if (formHelper.TextBoxHasContents(addSongTextBoxRating))
            {
                //Validate that if rating field contains data, it is within 1 and 5.
                if (!int.TryParse(addSongTextBoxRating.Text.Trim(), out rating) || rating > 5 || rating < 1)
                {
                    MessageBox.Show("Rating can only be between 1 and 5", "Input validation error");
                    addSongTextBoxRating.Focus();
                    formDataValid = false;
                }
            }

            return formDataValid;
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
