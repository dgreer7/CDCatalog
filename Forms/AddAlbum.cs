namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Linq;
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
            var requiredFields = new List<TextBox> { addAlbumTxtBoxAlbumName, addAlbumTextBoxAlbumYear };
            var formDataValid = true;

            if (!formHelper.TextBoxHasContents(addAlbumTxtBoxAlbumName))
            {
                MessageBox.Show("Please enter an album name.", "Input validation error");
                addAlbumTxtBoxAlbumName.Focus();
                formDataValid = false;
            }

            if (!formHelper.TextBoxHasContents(addAlbumTextBoxAlbumYear))
            {
                MessageBox.Show("Please enter the year the album was released.", "Input validation error");
                addAlbumTextBoxAlbumYear.Focus();
                formDataValid = false;
            }

            var year = 0;
            if (formHelper.TextBoxHasContents(addAlbumTextBoxAlbumYear))
            {
                //Validate that year textbox contains an int which is not before 1878 and not after this year
                if (!int.TryParse(addAlbumTextBoxAlbumYear.Text.Trim(), out year) || year < 1878 || year > System.DateTime.Today.Year)
                {
                    MessageBox.Show("Please enter a valid year.", "Input validation error");
                    addAlbumTextBoxAlbumYear.Focus();
                    formDataValid = false;
                }
            }

            var rating = 0;
            if (formHelper.TextBoxHasContents(addAlbumTextBoxRating))
            {
                //Validate that if rating field contains data, it is within 1 and 5.
                if (!int.TryParse(addAlbumTextBoxRating.Text.Trim(), out rating) || rating > 5 || rating < 1)
                {
                    MessageBox.Show("Rating can only be between 1 and 5", "Input validation error");
                    addAlbumTextBoxRating.Focus();
                    formDataValid = false;
                }
            }

            if (formDataValid)
            {
                //pulls the selected artist from the dropdown
                var artist = (Artist)addAlbumComboBoxArtist.SelectedItem;
                var newAlbum = addAlbumTxtBoxAlbumName.Text.Trim();
                //check if album with above artist already exists before adding a new one
                var albums = repository.SearchAlbumsByAlbumTitleExclusive(newAlbum);
                //check if matching album name also has a matching artist name
                var albumsWithMatchingArtist = albums.Where(a => a.Artist_Name == artist.ArtistName).ToList();
                if (albums.Count == 0 || albumsWithMatchingArtist.Count == 0)
                {
                    CreatedAlbum = repository.CreateAlbum(newAlbum, artist, year, rating);
                    Close();
                }
                else
                {
                    MessageBox.Show("You wanted to add " + newAlbum + ", but " + albums[0].Title + " by " + albumsWithMatchingArtist.First().Artist_Name + " already exsists.", "Album/aritst must be unique");
                    addAlbumTxtBoxAlbumName.Focus();
                }
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
