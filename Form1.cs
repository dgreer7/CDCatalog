using System.Data.Entity.Migrations.Sql;

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
            //Upon load, keep tabs sized with the window
            KeepTabSizedWithWindow();

            //experiment with dataGrid
            //using (CDCatalogEntities entity = new CDCatalogEntities())
            //{
            //    var query = entity.Songs.Distinct();
            //    dataGridViewSongs.DataSource = query.ToList();
            //}

        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //Upon resizing of form, keep tabs sized with the window
            KeepTabSizedWithWindow();
        }

        private void KeepTabSizedWithWindow()
        {
            tabControlMain.Width = this.ClientSize.Width;
            tabControlMain.Height = this.ClientSize.Height;
            dataGridViewSongs.Width = this.ClientSize.Width;
            dataGridViewSongs.Height = this.ClientSize.Height;
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                var nonNullableTextBoxes = new List<TextBox>
                {
                //Textboxes that are required to contain content for a song to be added
                addSongTxtBoxTitle,
                addSongTxtBoxArtist,
                addSongTxtBoxSongLength,
                addSongTxtBoxSongRating,
                addSongTxtBoxAlbum,
                addSongTxtBoxTrackNumber,
                addSongTxtBoxSongGenre,
                addSongTxtBoxAlbumYear,
                addSongTxtBoxAlbumRating
                };

                if (NotNull(nonNullableTextBoxes))
                {
                    Connector connection = new Connector();

                    //Sends form data to be added to db
                    connection.AddSong(addSongTxtBoxTitle.Text.Trim(), addSongTxtBoxArtist.Text.Trim(),
                    Int32.Parse(addSongTxtBoxSongRating.Text.Trim()), addSongTxtBoxSongGenre.Text.Trim(),
                    Int32.Parse(addSongTxtBoxSongLength.Text.Trim()), Int32.Parse(addSongTxtBoxTrackNumber.Text.Trim()),
                    addSongTxtBoxAlbum.Text.Trim(), Int32.Parse(addSongTxtBoxAlbumYear.Text.Trim()),
                    Int32.Parse(addSongTxtBoxAlbumRating.Text.Trim()));
                }

                ClearSongInfoTextBoxes();

                //increment track number and set focus to title field
                addSongTxtBoxTrackNumber.Text = (Int32.Parse(addSongTxtBoxTrackNumber.Text) + 1).ToString();
                addSongTxtBoxTitle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: ", ex.Message);
            }
        }

        private void btnRateFindSong_Click(object sender, EventArgs e)
        {
            try
            {
                using (CDCatalogEntities context = new CDCatalogEntities())
                {
                    Connector connector = new Connector();
                    List<Song> songs = connector.FindSongs(context, "text");
                    //rateDataGridView.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: ", ex.Message);
            }
        }

        private void ClearSongInfoTextBoxes()
        {
            addSongTxtBoxTitle.Clear();
            addSongTxtBoxSongLength.Clear();
            addSongTxtBoxSongRating.Clear();
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