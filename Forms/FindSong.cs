namespace CDCatalog.Forms
{
    using CDCatalog.Processor;
    using CDCatalog.Repository;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FindSong : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        public IList<SongView> FoundSongs { get; private set; }
        public IList<AlbumSongResult> FoundAlbumsAndSongs { get; private set; }
        public bool FindBothSongAndAlbum;

        public FindSong(bool findBothSongAndAlbum)
        {
            FindBothSongAndAlbum = findBothSongAndAlbum;
            InitializeComponent();
            ShowCorectFields();
            InitializeArtistComboBox();
            InitializeGenreComboBox();
            AdaptFormToIntendedUse();

#if DEBUG
            findSongTextBoxSongTitle.Text = "Inside";
#endif
        }

        private void AdaptFormToIntendedUse()
        {
            Text = FindBothSongAndAlbum ? "Find Songs and Albums" : "Find Song";
            findSongLabelSongTitle.Text = FindBothSongAndAlbum ? "Title" : "Song Title";
            findSongLabelLocateBy.Text = FindBothSongAndAlbum ? "Locate Album or Song by" : "Locate Song by";
            findSongRadioButtonBySongTitle.Text = FindBothSongAndAlbum ? "Title" : "Song Title";
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

            //Check if form is used to find song or song and album
            if (FindBothSongAndAlbum)
            {
                var processor = new ProcessSongAlbumAggregator();
                if (findSongRadioButtonBySongTitle.Checked)
                {
                    FoundAlbumsAndSongs = processor.FindSongOrAlbumByTitle(findSongTextBoxSongTitle.Text.Trim());
                }
                //if searching by aritst
                else if (findSongRadioButtonByArtist.Checked)
                {
                    FoundAlbumsAndSongs = processor.FindSongOrAlbumByArtist(((Artist)findSongComboBoxArtist.SelectedItem).ArtistName);
                }
                //if searching by genre
                else
                {
                    FoundAlbumsAndSongs = processor.FindSongOrAlbumByGenre(((Genre)findSongComboBoxGenre.SelectedItem).GenreName);
                }
                //if no results were returnd show message box and prevent dialog from closing
                if (FoundAlbumsAndSongs.Count == 0)
                {
                    MessageBox.Show("Unable to locate any matching Albums or Songs.");
                    DialogResult = DialogResult.None;
                }
                else
                    Close();
            }
            else
            {
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
}
