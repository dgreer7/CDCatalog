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
                addSongTxtBoxTrackLength,
                addSongTxtBoxRating,
                addSongTxtBoxAlbum,
                addSongTxtBoxTrackNumber

                };

                if (NotNull(nonNullableTextBoxes))
                {
                    Connector connection = new Connector();
                    connection.AddSong(addSongTxtBoxTitle.Text.Trim(),
                        addSongTxtBoxArtist.Text.Trim(),
                        Int32.Parse(addSongTxtBoxRating.Text.Trim()),
                        Int32.Parse(addSongTxtBoxTrackLength.Text.Trim()));
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
            addSongTxtBoxTrackLength.Clear();
            addSongTxtBoxRating.Clear();
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