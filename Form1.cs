namespace CDCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
                Artist artist = FindOrCreateArtist(addSongTxtBoxArtist.Text.Trim());

                nonNullableTextBoxes.Clear();
                nonNullableTextBoxes.Add(addSongTxtBoxAlbum);
                nonNullableTextBoxes.Add(addSongTxtBoxTrackNumber);

                Album album = null ;

                if (NotNull(nonNullableTextBoxes))
                {
                    album = FindOrCreateAlbum(addSongTxtBoxAlbum.Text.Trim());
                }

                using (CDCatalogEntities CDCatalogEntity = new CDCatalogEntities())
                {
                    Song song = new Song
                    {
                        Title = addSongTxtBoxTitle.Text.Trim(),
                        Rating = Int32.Parse(addSongTxtBoxRating.Text.Trim()),
                        Artist = artist
                    };

                    if (album != null)
                    {
                        song.Album = album;
                        song.TrackNumber = Int32.Parse(addSongLblTrackNumber.Text.Trim());
                    }

                    CDCatalogEntity.Songs.Add(song);
                }
            }
        }

        private Album FindOrCreateAlbum(string albumText)
        {
            Album album;

            using (CDCatalogEntities CDCatalogEntity = new CDCatalogEntities())
            {
                album = CDCatalogEntity.Albums.Where(a => a.Title == albumText).First();

                if (album == null)
                {
                    album = new Album
                    {
                        Title = albumText
                    };

                    CDCatalogEntity.Albums.Add(album);
                }
            }

            return album;
        }

        private Artist FindOrCreateArtist(string artistText)
        {
            Artist artist;

            using (CDCatalogEntities CDCatalogEntity = new CDCatalogEntities())
            {
                artist = CDCatalogEntity.Artists.Where(a => a.ArtistName == artistText).First();

                if (artist == null)
                {
                    artist = new Artist
                    {
                        ArtistName = artistText
                    };

                    CDCatalogEntity.Artists.Add(artist);
                }
            }

            return artist;
        }

        private bool NotNull(List<TextBox> nonNullableTextBoxes)
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