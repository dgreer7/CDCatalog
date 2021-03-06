﻿namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddAlbum : Form
    {
        public Album CreatedAlbum { get; private set; }
        CDCatalogRepository repository = new CDCatalogRepository();
        FormHelper formHelper = new FormHelper();

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

        /// <summary>
        /// Will check that all forms required for creating an album contain valid data.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="rating"></param>
        /// <returnsBoolean></returns>
        private bool IsFormDataValid(out int year, out int rating)
        {
            var formDataValid = true;
            //Using FormHelper to check that textbox contains a name.
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

            year = 0;
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

            rating = 0;
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

            return formDataValid;
        }

        private void addAlbumButton_Click(object sender, System.EventArgs e)
        {
            //using FormHelper, validate that required fileds are filled with data

            var requiredFields = new List<TextBox> { addAlbumTxtBoxAlbumName, addAlbumTextBoxAlbumYear };
            int year, rating;

            if (IsFormDataValid(out year, out rating))
            {
                //pulls the selected artist from the dropdown
                var artist = (Artist)addAlbumComboBoxArtist.SelectedItem;
                var newAlbum = addAlbumTxtBoxAlbumName.Text.Trim();
                //check if album with above artist already exists before adding a new one
                var albums = repository.SearchAlbumsByAlbumTitleExclusive(newAlbum);
                //check if matching album name also has a matching artist name
                var albumsWithMatchingArtist = albums.Where(a => a.ArtistId == artist.ArtistId).ToList();
                //will not add album if same name with same artist has been found
                if (albumsWithMatchingArtist.Count == 0)
                {
                    CreatedAlbum = repository.CreateAlbum(newAlbum, artist, year, rating);
                    Close();
                }
                else
                {
                    MessageBox.Show(string.Format("You wanted to add {0}, but {1} by {2} already exists.",
                        newAlbum, albumsWithMatchingArtist.First().Title, artist.ArtistName),
                        "Album/aritst must be unique");
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
                addAlbumButton.Focus();
            }
        }
    }
}
