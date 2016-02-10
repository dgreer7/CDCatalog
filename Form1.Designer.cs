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
            this.label3 = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbumYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongLength = new System.Windows.Forms.TextBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.addSongLblRating = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongRating = new System.Windows.Forms.TextBox();
            this.addSongLblAlbum = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbum = new System.Windows.Forms.TextBox();
            this.addSongLblTrackNumber = new System.Windows.Forms.Label();
            this.addSongTxtBoxTrackNumber = new System.Windows.Forms.TextBox();
            this.addSongLblArtist = new System.Windows.Forms.Label();
            this.addSongTxtBoxArtist = new System.Windows.Forms.TextBox();
            this.addSongLblTitle = new System.Windows.Forms.Label();
            this.addSongTxtBoxTitle = new System.Windows.Forms.TextBox();
            this.tabAddAlbum = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbumRating = new System.Windows.Forms.TextBox();
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
            this.tabControlMain.Size = new System.Drawing.Size(508, 439);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabViewSongs
            // 
            this.tabViewSongs.Controls.Add(this.dataGridViewSongs);
            this.tabViewSongs.Location = new System.Drawing.Point(4, 25);
            this.tabViewSongs.Margin = new System.Windows.Forms.Padding(4);
            this.tabViewSongs.Name = "tabViewSongs";
            this.tabViewSongs.Padding = new System.Windows.Forms.Padding(4);
            this.tabViewSongs.Size = new System.Drawing.Size(500, 410);
            this.tabViewSongs.TabIndex = 2;
            this.tabViewSongs.Text = "View Songs";
            this.tabViewSongs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSongs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.Size = new System.Drawing.Size(623, 476);
            this.dataGridViewSongs.TabIndex = 0;
            // 
            // tabAddSong
            // 
            this.tabAddSong.Controls.Add(this.label4);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxAlbumRating);
            this.tabAddSong.Controls.Add(this.label3);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxSongGenre);
            this.tabAddSong.Controls.Add(this.label2);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxAlbumYear);
            this.tabAddSong.Controls.Add(this.label1);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxSongLength);
            this.tabAddSong.Controls.Add(this.addSongButton);
            this.tabAddSong.Controls.Add(this.addSongLblRating);
            this.tabAddSong.Controls.Add(this.addSongTxtBoxSongRating);
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
            this.tabAddSong.Size = new System.Drawing.Size(500, 410);
            this.tabAddSong.TabIndex = 0;
            this.tabAddSong.Text = "Add Song";
            this.tabAddSong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Song Genre";
            // 
            // addSongTxtBoxSongGenre
            // 
            this.addSongTxtBoxSongGenre.Location = new System.Drawing.Point(249, 54);
            this.addSongTxtBoxSongGenre.Name = "addSongTxtBoxSongGenre";
            this.addSongTxtBoxSongGenre.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxSongGenre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Album Year";
            // 
            // addSongTxtBoxAlbumYear
            // 
            this.addSongTxtBoxAlbumYear.Location = new System.Drawing.Point(249, 230);
            this.addSongTxtBoxAlbumYear.Name = "addSongTxtBoxAlbumYear";
            this.addSongTxtBoxAlbumYear.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxAlbumYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Song Length";
            // 
            // addSongTxtBoxSongLength
            // 
            this.addSongTxtBoxSongLength.Location = new System.Drawing.Point(80, 235);
            this.addSongTxtBoxSongLength.Name = "addSongTxtBoxSongLength";
            this.addSongTxtBoxSongLength.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxSongLength.TabIndex = 3;
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(80, 331);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(267, 41);
            this.addSongButton.TabIndex = 8;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // addSongLblRating
            // 
            this.addSongLblRating.AutoSize = true;
            this.addSongLblRating.Location = new System.Drawing.Point(83, 148);
            this.addSongLblRating.Name = "addSongLblRating";
            this.addSongLblRating.Size = new System.Drawing.Size(86, 17);
            this.addSongLblRating.TabIndex = 9;
            this.addSongLblRating.Text = "Song Rating";
            // 
            // addSongTxtBoxSongRating
            // 
            this.addSongTxtBoxSongRating.Location = new System.Drawing.Point(83, 171);
            this.addSongTxtBoxSongRating.Name = "addSongTxtBoxSongRating";
            this.addSongTxtBoxSongRating.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxSongRating.TabIndex = 2;
            // 
            // addSongLblAlbum
            // 
            this.addSongLblAlbum.AutoSize = true;
            this.addSongLblAlbum.Location = new System.Drawing.Point(249, 148);
            this.addSongLblAlbum.Name = "addSongLblAlbum";
            this.addSongLblAlbum.Size = new System.Drawing.Size(88, 17);
            this.addSongLblAlbum.TabIndex = 7;
            this.addSongLblAlbum.Text = "Album Name";
            // 
            // addSongTxtBoxAlbum
            // 
            this.addSongTxtBoxAlbum.Location = new System.Drawing.Point(249, 171);
            this.addSongTxtBoxAlbum.Name = "addSongTxtBoxAlbum";
            this.addSongTxtBoxAlbum.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxAlbum.TabIndex = 6;
            // 
            // addSongLblTrackNumber
            // 
            this.addSongLblTrackNumber.AutoSize = true;
            this.addSongLblTrackNumber.Location = new System.Drawing.Point(249, 89);
            this.addSongLblTrackNumber.Name = "addSongLblTrackNumber";
            this.addSongLblTrackNumber.Size = new System.Drawing.Size(98, 17);
            this.addSongLblTrackNumber.TabIndex = 5;
            this.addSongLblTrackNumber.Text = "Track Number";
            // 
            // addSongTxtBoxTrackNumber
            // 
            this.addSongTxtBoxTrackNumber.Location = new System.Drawing.Point(249, 112);
            this.addSongTxtBoxTrackNumber.Name = "addSongTxtBoxTrackNumber";
            this.addSongTxtBoxTrackNumber.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxTrackNumber.TabIndex = 5;
            // 
            // addSongLblArtist
            // 
            this.addSongLblArtist.AutoSize = true;
            this.addSongLblArtist.Location = new System.Drawing.Point(83, 89);
            this.addSongLblArtist.Name = "addSongLblArtist";
            this.addSongLblArtist.Size = new System.Drawing.Size(40, 17);
            this.addSongLblArtist.TabIndex = 3;
            this.addSongLblArtist.Text = "Artist";
            // 
            // addSongTxtBoxArtist
            // 
            this.addSongTxtBoxArtist.Location = new System.Drawing.Point(83, 112);
            this.addSongTxtBoxArtist.Name = "addSongTxtBoxArtist";
            this.addSongTxtBoxArtist.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxArtist.TabIndex = 1;
            // 
            // addSongLblTitle
            // 
            this.addSongLblTitle.AutoSize = true;
            this.addSongLblTitle.Location = new System.Drawing.Point(83, 31);
            this.addSongLblTitle.Name = "addSongLblTitle";
            this.addSongLblTitle.Size = new System.Drawing.Size(35, 17);
            this.addSongLblTitle.TabIndex = 1;
            this.addSongLblTitle.Text = "Title";
            // 
            // addSongTxtBoxTitle
            // 
            this.addSongTxtBoxTitle.Location = new System.Drawing.Point(83, 54);
            this.addSongTxtBoxTitle.Name = "addSongTxtBoxTitle";
            this.addSongTxtBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxTitle.TabIndex = 0;
            // 
            // tabAddAlbum
            // 
            this.tabAddAlbum.Location = new System.Drawing.Point(4, 25);
            this.tabAddAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddAlbum.Name = "tabAddAlbum";
            this.tabAddAlbum.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddAlbum.Size = new System.Drawing.Size(500, 410);
            this.tabAddAlbum.TabIndex = 1;
            this.tabAddAlbum.Text = "Add Album";
            this.tabAddAlbum.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Album Rating";
            // 
            // textBox1
            // 
            this.addSongTxtBoxAlbumRating.Location = new System.Drawing.Point(249, 290);
            this.addSongTxtBoxAlbumRating.Name = "textBox1";
            this.addSongTxtBoxAlbumRating.Size = new System.Drawing.Size(100, 22);
            this.addSongTxtBoxAlbumRating.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AcceptButton = this.addSongButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 436);
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
        private System.Windows.Forms.TextBox addSongTxtBoxSongRating;
        private System.Windows.Forms.Label addSongLblAlbum;
        private System.Windows.Forms.TextBox addSongTxtBoxAlbum;
        private System.Windows.Forms.Label addSongLblTrackNumber;
        private System.Windows.Forms.TextBox addSongTxtBoxTrackNumber;
        private System.Windows.Forms.Label addSongLblArtist;
        private System.Windows.Forms.TextBox addSongTxtBoxArtist;
        private System.Windows.Forms.Label addSongLblTitle;
        private System.Windows.Forms.TextBox addSongTxtBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addSongTxtBoxSongLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addSongTxtBoxSongGenre;
        private System.Windows.Forms.TextBox addSongTxtBoxAlbumYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addSongTxtBoxAlbumRating;
    }
}

