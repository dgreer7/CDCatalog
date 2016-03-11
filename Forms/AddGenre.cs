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
            CreatedGenre = repository.CreateGenre(addSongTxtBoxSongGenre.Text.Trim());
            Close();
        }
    }
}
