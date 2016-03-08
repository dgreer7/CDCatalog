﻿namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class AddArtist : Form
    {
        public AddArtist()
        {
            InitializeComponent();
        }

        private void addArtistButton_Click(object sender, System.EventArgs e)
        {
            var repository = new CDCatalogRepository();
            repository.CreateArtist(addArtistTxtBoxArtistName.Text.Trim());
            this.Close();
        }
    }
}