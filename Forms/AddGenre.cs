using System;
using System.Collections.Generic;
namespace CDCatalog
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            var repository = new CDCatalogRepository();
            repository.CreateGenre(addSongTxtBoxSongGenre.Text.Trim());
            this.Close();
        }
    }
}
