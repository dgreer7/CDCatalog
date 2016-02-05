namespace CDCatalog
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabViewSongs = new System.Windows.Forms.TabPage();
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.tabAddSong = new System.Windows.Forms.TabPage();
            this.tabAddAlbum = new System.Windows.Forms.TabPage();
            this.addSongTxtBoxTitle = new System.Windows.Forms.TextBox();
            this.addSongLblTitle = new System.Windows.Forms.Label();
            this.addSongLblArtist = new System.Windows.Forms.Label();
            this.addSongTxtBoxArtist = new System.Windows.Forms.TextBox();
            this.addSongLblTrackNumber = new System.Windows.Forms.Label();
            this.addSongTxtBoxTrackNumber = new System.Windows.Forms.TextBox();
            this.addSongLblAlbum = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbum = new System.Windows.Forms.TextBox();
            this.addSongLblRating = new System.Windows.Forms.Label();
            this.addSongTxtBoxRating = new System.Windows.Forms.TextBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabViewSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.tabAddSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabViewSongs);
            this.tabControlMain.Controls.Add(this.tabAddSong);
            this.tabControlMain.Controls.Add(this.tabAddAlbum);
            this.tabControlMain.Location = new System.Drawing.Point(1, 1);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(633, 508);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabViewSongs
            // 
            this.tabViewSongs.Controls.Add(this.dataGridViewSongs);
            this.tabViewSongs.Location = new System.Drawing.Point(4, 25);
            this.tabViewSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabViewSongs.Name = "tabViewSongs";
            this.tabViewSongs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabViewSongs.Size = new System.Drawing.Size(625, 479);
            this.tabViewSongs.TabIndex = 2;
            this.tabViewSongs.Text = "View Songs";
            this.tabViewSongs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSongs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.Size = new System.Drawing.Size(623, 476);
            this.dataGridViewSongs.TabIndex = 0;
            // 
            // tabAddSong
            // 
            this.tabAddSong.Controls.Add(this.addSongButton);
            this.tabAddSong.Controls.Add(this.addSongLblRating);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxRating);
            this.tabAddSong.Controls.Add(this.addSongLblAlbum);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxAlbum);
            this.tabAddSong.Controls.Add(this.addSongLblTrackNumber);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxTrackNumber);
            this.tabAddSong.Controls.Add(this.addSongLblArtist);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxArtist);
            this.tabAddSong.Controls.Add(this.addSongLblTitle);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxTitle);
            this.tabAddSong.Location = new System.Drawing.Point(4, 25);
            this.tabAddSong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddSong.Name = "tabAddSong";
            this.tabAddSong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddSong.Size = new System.Drawing.Size(625, 479);
            this.tabAddSong.TabIndex = 0;
            this.tabAddSong.Text = "Add Song";
            this.tabAddSong.UseVisualStyleBackColor = true;
            // 
            // tabAddAlbum
            // 
            this.tabAddAlbum.Location = new System.Drawing.Point(4, 25);
            this.tabAddAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddAlbum.Name = "tabAddAlbum";
            this.tabAddAlbum.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddAlbum.Size = new System.Drawing.Size(625, 479);
            this.tabAddAlbum.TabIndex = 1;
            this.tabAddAlbum.Text = "Add Album";
            this.tabAddAlbum.UseVisualStyleBackColor = true;
            // 
            // addSongTxtBoxTitle
            // 
            this.addSongTxtBoxTitle.Location = new System.Drawing.Point(86, 109);
            this.addSongTxtBoxTitle.Name = "addSongTxtBoxTitle";
            this.addSongTxtBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxTitle.TabIndex = 0;
            // 
            // addSongLblTitle
            // 
            this.addSongLblTitle.AutoSize = true;
            this.addSongLblTitle.Location = new System.Drawing.Point(86, 86);
            this.addSongLblTitle.Name = "addSongLblTitle";
            this.addSongLblTitle.Size = new System.Drawing.Size(35, 17);
            this.addSongLblTitle.TabIndex = 1;
            this.addSongLblTitle.Text = "Title";
            // 
            // addSongLblArtist
            // 
            this.addSongLblArtist.AutoSize = true;
            this.addSongLblArtist.Location = new System.Drawing.Point(86, 144);
            this.addSongLblArtist.Name = "addSongLblArtist";
            this.addSongLblArtist.Size = new System.Drawing.Size(40, 17);
            this.addSongLblArtist.TabIndex = 3;
            this.addSongLblArtist.Text = "Artist";
            // 
            // addSongTxtBoxArtist
            // 
            this.addSongTxtBoxArtist.Location = new System.Drawing.Point(86, 167);
            this.addSongTxtBoxArtist.Name = "addSongTxtBoxArtist";
            this.addSongTxtBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxArtist.TabIndex = 2;
            // 
            // addSongLblTrackNumber
            // 
            this.addSongLblTrackNumber.AutoSize = true;
            this.addSongLblTrackNumber.Location = new System.Drawing.Point(252, 86);
            this.addSongLblTrackNumber.Name = "addSongLblTrackNumber";
            this.addSongLblTrackNumber.Size = new System.Drawing.Size(98, 17);
            this.addSongLblTrackNumber.TabIndex = 5;
            this.addSongLblTrackNumber.Text = "Track Number";
            // 
            // addSongTxtBoxTrackNumber
            // 
            this.addSongTxtBoxTrackNumber.Location = new System.Drawing.Point(252, 109);
            this.addSongTxtBoxTrackNumber.Name = "addSongTxtBoxTrackNumber";
            this.addSongTxtBoxTrackNumber.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxTrackNumber.TabIndex = 4;
            // 
            // addSongLblAlbum
            // 
            this.addSongLblAlbum.AutoSize = true;
            this.addSongLblAlbum.Location = new System.Drawing.Point(252, 144);
            this.addSongLblAlbum.Name = "addSongLblAlbum";
            this.addSongLblAlbum.Size = new System.Drawing.Size(47, 17);
            this.addSongLblAlbum.TabIndex = 7;
            this.addSongLblAlbum.Text = "Album";
            // 
            // addSongTxtBoxAlbum
            // 
            this.addSongTxtBoxAlbum.Location = new System.Drawing.Point(252, 167);
            this.addSongTxtBoxAlbum.Name = "addSongTxtBoxAlbum";
            this.addSongTxtBoxAlbum.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxAlbum.TabIndex = 6;
            // 
            // addSongLblRating
            // 
            this.addSongLblRating.AutoSize = true;
            this.addSongLblRating.Location = new System.Drawing.Point(86, 203);
            this.addSongLblRating.Name = "addSongLblRating";
            this.addSongLblRating.Size = new System.Drawing.Size(49, 17);
            this.addSongLblRating.TabIndex = 9;
            this.addSongLblRating.Text = "Rating";
            // 
            // addSongTxtBoxRating
            // 
            this.addSongTxtBoxRating.Location = new System.Drawing.Point(86, 226);
            this.addSongTxtBoxRating.Name = "addSongTxtBoxRating";
            this.addSongTxtBoxRating.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxRating.TabIndex = 8;
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(89, 277);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(261, 41);
            this.addSongButton.TabIndex = 10;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 511);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "CD Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabViewSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.tabAddSong.ResumeLayout(false);
            this.tabAddSong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSong;
        private System.Windows.Forms.TabPage tabAddAlbum;
        private System.Windows.Forms.TabPage tabViewSongs;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Label addSongLblRating;
        private System.Windows.Forms.TextBox addSongTxtBoxRating;
        private System.Windows.Forms.Label addSongLblAlbum;
        private System.Windows.Forms.TextBox addSongTxtBoxAlbum;
        private System.Windows.Forms.Label addSongLblTrackNumber;
        private System.Windows.Forms.TextBox addSongTxtBoxTrackNumber;
        private System.Windows.Forms.Label addSongLblArtist;
        private System.Windows.Forms.TextBox addSongTxtBoxArtist;
        private System.Windows.Forms.Label addSongLblTitle;
        private System.Windows.Forms.TextBox addSongTxtBoxTitle;
    }
}

