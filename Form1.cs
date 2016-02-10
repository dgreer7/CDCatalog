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
            try
            {
                List<TextBox> nonNullableTextBoxes = new List<TextBox>
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
                    connection.AddSong(addSongTxtBoxTitle.Text.Trim(), addSongTxtBoxArtist.Text.Trim(),
                        Int32.Parse(addSongTxtBoxSongRating.Text.Trim()), addSongTxtBoxSongGenre.Text.Trim(),
                        Int32.Parse(addSongTxtBoxSongLength.Text.Trim()), Int32.Parse(addSongTxtBoxTrackNumber.Text.Trim()),
                        addSongTxtBoxAlbum.Text.Trim(), Int32.Parse(addSongTxtBoxAlbumYear.Text.Trim()), 
                        Int32.Parse(addSongTxtBoxAlbumRating.Text.Trim()));
                }

                ClearSongInfoTextBoxes();
            }
            catch
            {

            }
        }

        private void ClearSongInfoTextBoxes()
        {
            addSongTxtBoxTitle.Clear();
            addSongTxtBoxSongLength.Clear();
            addSongTxtBoxSongRating.Clear();
            addSongTxtBoxTrackNumber.Text = (Int32.Parse(addSongTxtBoxTrackNumber.Text) + 1).ToString();
            addSongTxtBoxTitle.Focus();

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