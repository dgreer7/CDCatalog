namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class AddAlbum : Form
    {
        public Album CreatedAlbum { get; private set; }
        CDCatalogRepository repository = new CDCatalogRepository();

        public AddAlbum()
        {
            InitializeComponent();
            InitializeArtistComboBox();

#if DEBUG
            var rand = new System.Random();
            addAlbumTxtBoxAlbumName.Text = "My Favorite band";
            addAlbumTextBoxAlbumYear.Text = rand.Next(1878, System.DateTime.Today.Year).ToString();
#endif
        }

        private void InitializeArtistComboBox()
        {
            addAlbumComboBoxArtist.DataSource = repository.GetAllArtists();
            addAlbumComboBoxArtist.DisplayMember = "ArtistName";
            addAlbumComboBoxArtist.ValueMember = "ArtistId";
        }

        private void addAlbumButton_Click(object sender, System.EventArgs e)
        {
            //using FormHelper, validate that required fileds are filled with data
            var formHelper = new FormHelper();
            var requiredFields = new List<TextBox> {addAlbumTxtBoxAlbumName, addAlbumTextBoxAlbumYear};

            if (formHelper.NotNull(requiredFields))
            {
                //pulls the selected artist from the dropdown
                var artist = (Artist)addAlbumComboBoxArtist.SelectedItem;
                //use helper to store album year
                var year = formHelper.GetIntFromTextBox(addAlbumTextBoxAlbumYear);
                //use helper to album rating, defaults to 0 if not filled.
                var rating = formHelper.GetIntFromTextBox(addAlbumTextBoxRating) != -1 ? formHelper.GetIntFromTextBox(addAlbumTextBoxRating) : 0;

                CreatedAlbum = repository.CreateAlbum(addAlbumTxtBoxAlbumName.Text.Trim(), artist, year, rating);
                Close();
            }
            else
            {
                addAlbumLabelAlbumName.ForeColor = System.Drawing.Color.Red;
                addAlbumLabelAlbumYear.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Required field missing.");
            }
        }

        private void addAlbumButtonAddArtist_Click(object sender, System.EventArgs e)
        {
            var addArtist = new AddArtist();
            addArtist.ShowDialog();
            
            if (addArtist.CreatedArtist != null)
            {
                InitializeArtistComboBox();
                addAlbumComboBoxArtist.SelectedValue = addArtist.CreatedArtist.ArtistId;
            }
        }
    }
}
