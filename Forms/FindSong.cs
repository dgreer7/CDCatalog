namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FindSong : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        public IList<Song> FoundSongs { get; private set; }

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
            findSongLabelSongTitle.Visible = findSongRadioButtonBySongTitle.Checked;
            findSongTextBoxSongTitle.Visible = findSongRadioButtonBySongTitle.Checked;
            findSongLabelGenre.Visible = findSongRadioButtonByGenre.Checked;
            findSongComboBoxGenre.Visible = findSongRadioButtonByGenre.Checked;
            findSongLabelArtist.Visible = findSongRadioButtonByArtist.Checked;
            findSongComboBoxArtist.Visible = findSongRadioButtonByArtist.Checked;
        }

        private void InitializeArtistComboBox()
        {
            findSongComboBoxArtist.DataSource = repository.GetAllArtists();
            findSongComboBoxArtist.DisplayMember = "ArtistName";
            findSongComboBoxArtist.ValueMember = "ArtistId";
        }

        private void InitializeGenreComboBox()
        {
            findSongComboBoxGenre.DataSource = repository.GetAllGenres();
            findSongComboBoxGenre.DisplayMember = "GenreName";
            findSongComboBoxGenre.ValueMember = "GenreId";
        }

        private void findSongRadioButtonBySongTitle_CheckedChanged(object sender, EventArgs e)
        {
            ShowCorectFields();
        }

        private void findSongRadioButtonByGenre_CheckedChanged(object sender, EventArgs e)
        {
            ShowCorectFields();
        }

        private void findSongButton_Click(object sender, EventArgs e)
        {
            var formHelper = new FormHelper();

            if (findSongRadioButtonBySongTitle.Checked && formHelper.TextBoxNotNull(new List<TextBox> { findSongTextBoxSongTitle }))
            {
                FoundSongs = repository.SearchSongsBySongTitle(findSongTextBoxSongTitle.Text.Trim());
            }
            else if (findSongRadioButtonByArtist.Checked)
            {
                FoundSongs = repository.SearchSongsByArtistName(((Artist)findSongComboBoxArtist.SelectedItem).ArtistName);
            }
            else
            {
                FoundSongs = repository.SearchSongsByGenreName(((Genre)findSongComboBoxGenre.SelectedItem).GenreName);
            }
            if (FoundSongs.Count == 0)
                MessageBox.Show("Unable to locate any matching songs.");
            else
                Close();
        }
    }
}
