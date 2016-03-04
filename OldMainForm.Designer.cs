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
            this.label4 = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbumRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addSongTxtBoxAlbumYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongLength = new System.Windows.Forms.TextBox();
            this.btnAddSong = new System.Windows.Forms.Button();
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
            this.tabRateSong = new System.Windows.Forms.TabPage();
            this.btnRatingAddRating = new System.Windows.Forms.Button();
            this.rateTxtBoxAddRating = new System.Windows.Forms.TextBox();
            this.btnRateFindAlbum = new System.Windows.Forms.Button();
            this.btnRateFindSong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rateTxtBoxAlbumTitle = new System.Windows.Forms.TextBox();
            this.rateDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.rateTxtBoxSongTitle = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabViewSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.tabAddSong.SuspendLayout();
            this.tabRateSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabViewSongs);
            this.tabControlMain.Controls.Add(this.tabAddSong);
            this.tabControlMain.Controls.Add(this.tabAddAlbum);
            this.tabControlMain.Controls.Add(this.tabRateSong);
            this.tabControlMain.Location = new System.Drawing.Point(1, 1);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(381, 357);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabViewSongs
            // 
            this.tabViewSongs.Controls.Add(this.dataGridViewSongs);
            this.tabViewSongs.Location = new System.Drawing.Point(4, 22);
            this.tabViewSongs.Name = "tabViewSongs";
            this.tabViewSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewSongs.Size = new System.Drawing.Size(373, 331);
            this.tabViewSongs.TabIndex = 2;
            this.tabViewSongs.Text = "View Songs";
            this.tabViewSongs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.Size = new System.Drawing.Size(373, 331);
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
            this.tabAddSong.Controls.Add(this.btnAddSong);
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
            this.tabAddSong.Location = new System.Drawing.Point(4, 22);
            this.tabAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddSong.Name = "tabAddSong";
            this.tabAddSong.Padding = new System.Windows.Forms.Padding(2);
            this.tabAddSong.Size = new System.Drawing.Size(373, 331);
            this.tabAddSong.TabIndex = 0;
            this.tabAddSong.Text = "Add Song";
            this.tabAddSong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Album Rating";
            // 
            // addSongTxtBoxAlbumRating
            // 
            this.addSongTxtBoxAlbumRating.Location = new System.Drawing.Point(187, 236);
            this.addSongTxtBoxAlbumRating.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxAlbumRating.Name = "addSongTxtBoxAlbumRating";
            this.addSongTxtBoxAlbumRating.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxAlbumRating.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Song Genre";
            // 
            // addSongTxtBoxSongGenre
            // 
            this.addSongTxtBoxSongGenre.Location = new System.Drawing.Point(187, 44);
            this.addSongTxtBoxSongGenre.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxSongGenre.Name = "addSongTxtBoxSongGenre";
            this.addSongTxtBoxSongGenre.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxSongGenre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Album Year";
            // 
            // addSongTxtBoxAlbumYear
            // 
            this.addSongTxtBoxAlbumYear.Location = new System.Drawing.Point(187, 187);
            this.addSongTxtBoxAlbumYear.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxAlbumYear.Name = "addSongTxtBoxAlbumYear";
            this.addSongTxtBoxAlbumYear.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxAlbumYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Song Length";
            // 
            // addSongTxtBoxSongLength
            // 
            this.addSongTxtBoxSongLength.Location = new System.Drawing.Point(60, 191);
            this.addSongTxtBoxSongLength.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxSongLength.Name = "addSongTxtBoxSongLength";
            this.addSongTxtBoxSongLength.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxSongLength.TabIndex = 3;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(60, 269);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(200, 33);
            this.btnAddSong.TabIndex = 8;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // addSongLblRating
            // 
            this.addSongLblRating.AutoSize = true;
            this.addSongLblRating.Location = new System.Drawing.Point(62, 120);
            this.addSongLblRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLblRating.Name = "addSongLblRating";
            this.addSongLblRating.Size = new System.Drawing.Size(66, 13);
            this.addSongLblRating.TabIndex = 9;
            this.addSongLblRating.Text = "Song Rating";
            // 
            // addSongTxtBoxSongRating
            // 
            this.addSongTxtBoxSongRating.Location = new System.Drawing.Point(62, 139);
            this.addSongTxtBoxSongRating.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxSongRating.Name = "addSongTxtBoxSongRating";
            this.addSongTxtBoxSongRating.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxSongRating.TabIndex = 2;
            // 
            // addSongLblAlbum
            // 
            this.addSongLblAlbum.AutoSize = true;
            this.addSongLblAlbum.Location = new System.Drawing.Point(187, 120);
            this.addSongLblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLblAlbum.Name = "addSongLblAlbum";
            this.addSongLblAlbum.Size = new System.Drawing.Size(67, 13);
            this.addSongLblAlbum.TabIndex = 7;
            this.addSongLblAlbum.Text = "Album Name";
            // 
            // addSongTxtBoxAlbum
            // 
            this.addSongTxtBoxAlbum.Location = new System.Drawing.Point(187, 139);
            this.addSongTxtBoxAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxAlbum.Name = "addSongTxtBoxAlbum";
            this.addSongTxtBoxAlbum.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxAlbum.TabIndex = 6;
            // 
            // addSongLblTrackNumber
            // 
            this.addSongLblTrackNumber.AutoSize = true;
            this.addSongLblTrackNumber.Location = new System.Drawing.Point(187, 72);
            this.addSongLblTrackNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLblTrackNumber.Name = "addSongLblTrackNumber";
            this.addSongLblTrackNumber.Size = new System.Drawing.Size(75, 13);
            this.addSongLblTrackNumber.TabIndex = 5;
            this.addSongLblTrackNumber.Text = "Track Number";
            // 
            // addSongTxtBoxTrackNumber
            // 
            this.addSongTxtBoxTrackNumber.Location = new System.Drawing.Point(187, 91);
            this.addSongTxtBoxTrackNumber.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxTrackNumber.Name = "addSongTxtBoxTrackNumber";
            this.addSongTxtBoxTrackNumber.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxTrackNumber.TabIndex = 5;
            // 
            // addSongLblArtist
            // 
            this.addSongLblArtist.AutoSize = true;
            this.addSongLblArtist.Location = new System.Drawing.Point(62, 72);
            this.addSongLblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLblArtist.Name = "addSongLblArtist";
            this.addSongLblArtist.Size = new System.Drawing.Size(30, 13);
            this.addSongLblArtist.TabIndex = 3;
            this.addSongLblArtist.Text = "Artist";
            // 
            // addSongTxtBoxArtist
            // 
            this.addSongTxtBoxArtist.Location = new System.Drawing.Point(62, 91);
            this.addSongTxtBoxArtist.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxArtist.Name = "addSongTxtBoxArtist";
            this.addSongTxtBoxArtist.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxArtist.TabIndex = 1;
            // 
            // addSongLblTitle
            // 
            this.addSongLblTitle.AutoSize = true;
            this.addSongLblTitle.Location = new System.Drawing.Point(62, 25);
            this.addSongLblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLblTitle.Name = "addSongLblTitle";
            this.addSongLblTitle.Size = new System.Drawing.Size(27, 13);
            this.addSongLblTitle.TabIndex = 1;
            this.addSongLblTitle.Text = "Title";
            // 
            // addSongTxtBoxTitle
            // 
            this.addSongTxtBoxTitle.Location = new System.Drawing.Point(62, 44);
            this.addSongTxtBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxTitle.Name = "addSongTxtBoxTitle";
            this.addSongTxtBoxTitle.Size = new System.Drawing.Size(76, 20);
            this.addSongTxtBoxTitle.TabIndex = 0;
            // 
            // tabAddAlbum
            // 
            this.tabAddAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabAddAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddAlbum.Name = "tabAddAlbum";
            this.tabAddAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.tabAddAlbum.Size = new System.Drawing.Size(373, 331);
            this.tabAddAlbum.TabIndex = 1;
            this.tabAddAlbum.Text = "Add Album";
            this.tabAddAlbum.UseVisualStyleBackColor = true;
            // 
            // tabRateSong
            // 
            this.tabRateSong.Controls.Add(this.btnRatingAddRating);
            this.tabRateSong.Controls.Add(this.rateTxtBoxAddRating);
            this.tabRateSong.Controls.Add(this.btnRateFindAlbum);
            this.tabRateSong.Controls.Add(this.btnRateFindSong);
            this.tabRateSong.Controls.Add(this.label6);
            this.tabRateSong.Controls.Add(this.rateTxtBoxAlbumTitle);
            this.tabRateSong.Controls.Add(this.rateDataGridView);
            this.tabRateSong.Controls.Add(this.label5);
            this.tabRateSong.Controls.Add(this.rateTxtBoxSongTitle);
            this.tabRateSong.Location = new System.Drawing.Point(4, 22);
            this.tabRateSong.Name = "tabRateSong";
            this.tabRateSong.Padding = new System.Windows.Forms.Padding(3);
            this.tabRateSong.Size = new System.Drawing.Size(373, 331);
            this.tabRateSong.TabIndex = 3;
            this.tabRateSong.Text = "Rate Song or Album";
            this.tabRateSong.UseVisualStyleBackColor = true;
            // 
            // btnRatingAddRating
            // 
            this.btnRatingAddRating.Location = new System.Drawing.Point(141, 111);
            this.btnRatingAddRating.Name = "btnRatingAddRating";
            this.btnRatingAddRating.Size = new System.Drawing.Size(75, 23);
            this.btnRatingAddRating.TabIndex = 5;
            this.btnRatingAddRating.Text = "Add Rating";
            this.btnRatingAddRating.UseVisualStyleBackColor = true;
            // 
            // rateTxtBoxAddRating
            // 
            this.rateTxtBoxAddRating.Location = new System.Drawing.Point(141, 81);
            this.rateTxtBoxAddRating.Margin = new System.Windows.Forms.Padding(2);
            this.rateTxtBoxAddRating.Name = "rateTxtBoxAddRating";
            this.rateTxtBoxAddRating.Size = new System.Drawing.Size(76, 20);
            this.rateTxtBoxAddRating.TabIndex = 4;
            // 
            // btnRateFindAlbum
            // 
            this.btnRateFindAlbum.Location = new System.Drawing.Point(242, 64);
            this.btnRateFindAlbum.Name = "btnRateFindAlbum";
            this.btnRateFindAlbum.Size = new System.Drawing.Size(109, 23);
            this.btnRateFindAlbum.TabIndex = 3;
            this.btnRateFindAlbum.Text = "Find Album";
            this.btnRateFindAlbum.UseVisualStyleBackColor = true;
            // 
            // btnRateFindSong
            // 
            this.btnRateFindSong.Location = new System.Drawing.Point(15, 64);
            this.btnRateFindSong.Name = "btnRateFindSong";
            this.btnRateFindSong.Size = new System.Drawing.Size(107, 23);
            this.btnRateFindSong.TabIndex = 1;
            this.btnRateFindSong.Text = "Find Song";
            this.btnRateFindSong.UseVisualStyleBackColor = true;
            this.btnRateFindSong.Click += new System.EventHandler(this.btnRateFindSong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Album Title";
            // 
            // rateTxtBoxAlbumTitle
            // 
            this.rateTxtBoxAlbumTitle.Location = new System.Drawing.Point(242, 35);
            this.rateTxtBoxAlbumTitle.Margin = new System.Windows.Forms.Padding(2);
            this.rateTxtBoxAlbumTitle.Name = "rateTxtBoxAlbumTitle";
            this.rateTxtBoxAlbumTitle.Size = new System.Drawing.Size(109, 20);
            this.rateTxtBoxAlbumTitle.TabIndex = 2;
            // 
            // rateDataGridView
            // 
            this.rateDataGridView.AllowUserToAddRows = false;
            this.rateDataGridView.AllowUserToDeleteRows = false;
            this.rateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateDataGridView.Location = new System.Drawing.Point(8, 142);
            this.rateDataGridView.Name = "rateDataGridView";
            this.rateDataGridView.ReadOnly = true;
            this.rateDataGridView.Size = new System.Drawing.Size(359, 188);
            this.rateDataGridView.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Song Title";
            // 
            // rateTxtBoxSongTitle
            // 
            this.rateTxtBoxSongTitle.Location = new System.Drawing.Point(15, 35);
            this.rateTxtBoxSongTitle.Margin = new System.Windows.Forms.Padding(2);
            this.rateTxtBoxSongTitle.Name = "rateTxtBoxSongTitle";
            this.rateTxtBoxSongTitle.Size = new System.Drawing.Size(107, 20);
            this.rateTxtBoxSongTitle.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnAddSong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 354);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "CD Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabViewSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.tabAddSong.ResumeLayout(false);
            this.tabAddSong.PerformLayout();
            this.tabRateSong.ResumeLayout(false);
            this.tabRateSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSong;
        private System.Windows.Forms.TabPage tabAddAlbum;
        private System.Windows.Forms.TabPage tabViewSongs;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
        private System.Windows.Forms.Button btnAddSong;
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
        private System.Windows.Forms.TabPage tabRateSong;
        private System.Windows.Forms.Button btnRatingAddRating;
        private System.Windows.Forms.TextBox rateTxtBoxAddRating;
        private System.Windows.Forms.Button btnRateFindAlbum;
        private System.Windows.Forms.Button btnRateFindSong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rateTxtBoxAlbumTitle;
        private System.Windows.Forms.DataGridView rateDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rateTxtBoxSongTitle;
    }
}

