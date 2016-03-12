namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FindAlbum : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();
        private IList<Album> foundAlbums;
        public IList<Album> FoundAlbums
        {
            get { return foundAlbums; }
            private set
            {
                foundAlbums = value;
            }
        }

        public FindAlbum()
        {
            InitializeComponent();
            ShowCorectFields();
            InitializeArtistComboBox();

#if DEBUG
            findAlbumTxtBoxAlbumName.Text = "Play";
#endif
        }

        private void ShowCorectFields()
        {
            findAlbumLabelAlbumName.Visible = findAlbumRadioButtonByAlbumName.Checked;
            findAlbumTxtBoxAlbumName.Visible = findAlbumRadioButtonByAlbumName.Checked;
            findAlbumLabelArtist.Visible = findAlbumRadioButtonByArtist.Checked;
            findAlbumComboBoxArtist.Visible = findAlbumRadioButtonByArtist.Checked;
        }

        private void InitializeArtistComboBox()
        {
            findAlbumComboBoxArtist.DataSource = repository.GetAllArtists();
            findAlbumComboBoxArtist.DisplayMember = "ArtistName";
            findAlbumComboBoxArtist.ValueMember = "ArtistId";
        }

        private void findAlbumRadioButtonByAlbumName_CheckedChanged(object sender, EventArgs e)
        {
            ShowCorectFields();
        }

        private void findAlbumButton_Click(object sender, EventArgs e)
        {
            var formHelper = new FormHelper();

            if (findAlbumRadioButtonByAlbumName.Checked && formHelper.TextBoxNotNull(new List<TextBox> { findAlbumTxtBoxAlbumName }))
            {
                FoundAlbums = repository.SearchAlbumsByAlbumTitle(findAlbumTxtBoxAlbumName.Text);
                if (FoundAlbums.Count == 0)
                    MessageBox.Show("Unable to locate any matching albumns.");
                else
                    Close();
            }
            else
            {
                FoundAlbums = repository.SearchAlbumsByArtistName(((Artist)findAlbumComboBoxArtist.SelectedItem).ArtistName);
                if (FoundAlbums.Count == 0)
                    MessageBox.Show("Unable to locate any matching albumns.");
                else
                    Close();
            }
                
        }
    }
}
