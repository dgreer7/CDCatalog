namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class AddArtist : Form
    {
        public Artist CreatedArtist { get; private set; }

        public AddArtist()
        {
            InitializeComponent();
        }

        private void addArtistButton_Click(object sender, System.EventArgs e)
        {
            var repository = new CDCatalogRepository();
            var formHelper = new FormHelper();

            if (!formHelper.TextBoxHasContents(addArtistTxtBoxArtistName))
            {
                MessageBox.Show("Please enter an artist name.", "Input validation error");
                addArtistTxtBoxArtistName.Focus();
            }
            else
            {
                var newArtist = addArtistTxtBoxArtistName.Text.Trim();
                var artists = repository.SearchArtistByExactArtistName(newArtist);

                if (artists.Count > 0)
                {
                    MessageBox.Show("You wanted to add " + newArtist + ", but " + artists[0].ArtistName + " already exsists.", "Artist must be unique");
                    addArtistTxtBoxArtistName.Focus();
                }
                else
                {
                    CreatedArtist = repository.CreateArtist(addArtistTxtBoxArtistName.Text.Trim());
                    this.Close();
                }
            }
        }
    }
}
