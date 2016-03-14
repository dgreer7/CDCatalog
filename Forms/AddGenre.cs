namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System;
    using System.Windows.Forms;

    public partial class AddGenre : Form
    {
        public Genre CreatedGenre { get; private set; }

        public AddGenre()
        {
            InitializeComponent();
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            var repository = new CDCatalogRepository();
            var formHelper = new FormHelper();

            if (!formHelper.TextBoxHasContents(addSongTxtBoxSongGenre))
            {
                MessageBox.Show("Please enter a genre.", "Input validation error");
                addSongTxtBoxSongGenre.Focus();
            }
            else
            {
                var newGenre = addSongTxtBoxSongGenre.Text.Trim();
                var genres = repository.SearchGenreByGenreName(newGenre);

                if (genres.Count > 0)
                {
                    MessageBox.Show("You wanted to add " + newGenre + ", but " + genres[0].GenreName + " already exsists.", "Genre must be unique");
                    addSongTxtBoxSongGenre.Focus();
                }
                else
                {
                    CreatedGenre = repository.CreateGenre(addSongTxtBoxSongGenre.Text.Trim());
                    Close();
                }
            }
        }
    }
}
