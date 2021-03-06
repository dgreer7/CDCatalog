﻿namespace CDCatalog.Forms
{
    using CDCatalog.Repository;
    using System.Windows.Forms;

    public partial class UpdateSong : Form
    {
        private string SongTitleToUpdate { get; set; }
        private string AlbumTitleOfSong { get; set; }


        public UpdateSong(string songTitle, string albumName = null)
        {
            SongTitleToUpdate = songTitle;
            AlbumTitleOfSong = albumName;
            InitializeComponent();
            SetUpLabelText();
        }

        private void SetUpLabelText()
        {
            if (AlbumTitleOfSong != null)
                updateSongLabel.Text = string.Format("Update rating of {0} by {1}:", SongTitleToUpdate, AlbumTitleOfSong);
            else
                updateSongLabel.Text = string.Format("Update rating of {0}:", SongTitleToUpdate);
        }

        private void updateSongButton_Click(object sender, System.EventArgs e)
        {
            var repository = new CDCatalogRepository();
            var formHelper = new FormHelper();

            int songRating = 0;

            //Check if textbox has an int and it is between 0 and 5 (inclusive)
            if (int.TryParse(updateSongTextBox.Text.Trim(), out songRating) && songRating >= 0 && songRating <= 5)
            {
                //if AlbumTitle not provided assing null to album
                var albums = AlbumTitleOfSong != null ? repository.SearchAlbumsByAlbumTitleExclusive(AlbumTitleOfSong) : null;
                //Send update to reposistory based on whether album name provided
                if (AlbumTitleOfSong == null)
                    repository.UpdateSongRating(SongTitleToUpdate, songRating);

                else
                    repository.UpdateSongRating(SongTitleToUpdate, songRating, albums[0]);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a rating can only be between 1 and 5", "Input validation error");
                updateSongTextBox.Focus();
                DialogResult = DialogResult.None;
            }
        }
    }
}
