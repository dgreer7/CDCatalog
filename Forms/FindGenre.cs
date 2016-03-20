namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FindGenre : Form
    {
        CDCatalogRepository repository = new CDCatalogRepository();

        public IList<Genre> FoundGenres { get; private set; }

        public FindGenre()
        {
            InitializeComponent();

#if DEBUG
            FindGenreTextBox.Text = "Rock";
#endif
        }

        private void findGenreButton_Click(object sender, System.EventArgs e)
        {
            var formHelper = new FormHelper();

            if (formHelper.TextBoxHasContents(FindGenreTextBox))
            {
                FoundGenres = repository.SearchGenreByGenreName(FindGenreTextBox.Text);
                if (FoundGenres.Count > 0)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Unable to locate any matching genres.");
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Please enter a genre.", "Data validation error");
                DialogResult = DialogResult.None;
            }
        }
    }
}
