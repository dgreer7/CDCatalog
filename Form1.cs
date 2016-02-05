namespace CDCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeepTabSizedWithWindow();

            using (CDCatalogEntities CDCatalogEntity = new CDCatalogEntities())
            {

            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            KeepTabSizedWithWindow();
        }

        private void KeepTabSizedWithWindow()
        {
            tabControlMain.Width = this.ClientSize.Width;
            tabControlMain.Height = this.ClientSize.Height;
            dataGridViewSongs.Width = this.ClientSize.Width;
            dataGridViewSongs.Height = this.ClientSize.Height;
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            List<TextBox> nonNullableTextBoxes = new List<TextBox>
            {
                addSongTxtBoxTitle,
                addSongTxtBoxRating,
                addSongTxtBoxArtist
            };

            if (NotNull(nonNullableTextBoxes))
            {
                using (CDCatalogEntities CDCatalogEntity = new CDCatalogEntities())
                {
                    Artist artist = new Artist { ArtistName = addSongTxtBoxArtist.Text.Trim() };

                    Song song = new Song
                    {
                        Title = addSongTxtBoxTitle.Text.Trim(),
                        Rating = Int32.Parse(addSongTxtBoxRating.Text.Trim()),
                        Artist = artist
                        //Album
                        //TrackNumber
                    };

                    CDCatalogEntity.Songs.Add(song);
                }
            }
        }

        public bool NotNull(List<TextBox> nonNullableTextBoxes)
        {
            foreach (TextBox txtBox in nonNullableTextBoxes)
            {
                if (txtBox.Text.Trim().Length == 0 || txtBox == null)
                    return false;
            }
            return true;
        }
    }
}