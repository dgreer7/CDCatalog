namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FindSong : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        public IList<SongView> FoundSongs { get; private set; }

        public FindSong()
        {
            InitializeComponent();
            ShowCorectFields();
            InitializeArtistComboBox();
            InitializeGenreComboBox();

#if DEBUG
            findSongTextBoxSongTitle.Text = "Inside";
#endif
        }

        private void ShowCorectFields()
        {
            //will set fields visible if radio button is checked for that element
            findSongLabelSongTitle.Visible = findSongRadioButtonBySongTitle.Checked;
            findSongTextBoxSongTitle.Visible = findSongRadioButtonBySongTitle.Checked;
            findSongLabelGenre.Visible = findSongRadioButtonByGenre.Checked;
            findSongComboBoxGenre.Visible = findSongRadioButtonByGenre.Checked;
            findSongLabelArtist.Visible = findSongRadioButtonByArtist.Checked;
            findSongComboBoxArtist.Visible = findSongRadioButtonByArtist.Checked;
        }

        private void InitializeArtistComboBox()
        {
            //Sets datasource, display and it's corrisponding value
            findSongComboBoxArtist.DataSource = repository.GetAllArtists();
            findSongComboBoxArtist.DisplayMember = "ArtistName";
            findSongComboBoxArtist.ValueMember = "ArtistId";
        }

        private void InitializeGenreComboBox()
        {
            //Sets datasource, display and it's corrisponding value
            findSongComboBoxGenre.DataSource = repository.GetAllGenres();
            findSongComboBoxGenre.DisplayMember = "GenreName";
            findSongComboBoxGenre.ValueMember = "GenreId";
        }

        private void findSongRadioButtonBySongTitle_CheckedChanged(object sender, EventArgs e)
        {
            //Update display if radio button is changed
            ShowCorectFields();
        }

        private void findSongRadioButtonByGenre_CheckedChanged(object sender, EventArgs e)
        {
            //Update display if radio button is changed
            ShowCorectFields();
        }

        private void findSongButton_Click(object sender, EventArgs e)
        {
            var formHelper = new FormHelper();

            //if searching by song title 
            if (findSongRadioButtonBySongTitle.Checked)
            {
                FoundSongs = repository.SearchSongsBySongTitle(findSongTextBoxSongTitle.Text.Trim());
            }
            //if searching by aritst
            else if (findSongRadioButtonByArtist.Checked)
            {
                FoundSongs = repository.SearchSongsByArtistName(((Artist)findSongComboBoxArtist.SelectedItem).ArtistName);
            }
            //if searching by genre
            else
            {
                FoundSongs = repository.SearchSongsByGenreName(((Genre)findSongComboBoxGenre.SelectedItem).GenreName);
            }
            //if no results were returnd show message box and prevent dialog from closing
            if (FoundSongs.Count == 0)
            {
                MessageBox.Show("Unable to locate any matching songs.");
                DialogResult = DialogResult.None;
            }
            else
                Close();
        }
    }
}
