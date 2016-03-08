namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class AddAlbum : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();

        public AddAlbum()
        {
            InitializeComponent();
            addAlbumTextBoxRating.MaxLength = 1;
            addAlbumTextBoxAlbumYear.MaxLength = 4;
            addAlbumComboBoxArtist.DataSource = repository.GetAllArtists();
            addAlbumComboBoxArtist.DisplayMember = "ArtistName";
            addAlbumComboBoxArtist.ValueMember = "ArtistId";

#if DEBUG
            addAlbumTxtBoxAlbumName.Text = "My Favorite band";
            addAlbumTextBoxAlbumYear.Text = "2006";
#endif
        }

        private void addAlbumButton_Click(object sender, System.EventArgs e)
        {
            //using FormHelper, validate that required fileds are filled with data
            var formHelper = new FormHelper();
            var requiredFields = new List<TextBox> {addAlbumTxtBoxAlbumName, addAlbumTextBoxAlbumYear};

            if (formHelper.NotNull(requiredFields))
            {
                var artist = repository.GetArtistByID((int)addAlbumComboBoxArtist.SelectedValue);
                var year = formHelper.GetIntFromTextBox(addAlbumTextBoxAlbumYear);
                
                repository.CreateAlbum(addAlbumTxtBoxAlbumName.Text.Trim(), artist, year, 2);
                Close();
            }
            else
            {
                addAlbumLabelAlbumName.ForeColor = System.Drawing.Color.Red;
                addAlbumLabelAlbumYear.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Required field missing.");
            }
        }
    }
}
