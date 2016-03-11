namespace CDCatalog.Forms
{
    partial class AddSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSong));
            this.addSongPanel = new System.Windows.Forms.Panel();
            this.addSongCheckBoxSongToAlbum = new System.Windows.Forms.CheckBox();
            this.addSongButtonAddGenre = new System.Windows.Forms.Button();
            this.addSongComboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addSongLabelSongTrackNumber = new System.Windows.Forms.Label();
            this.addSongTextBoxSongTrackNumber = new System.Windows.Forms.TextBox();
            this.addSongComboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.addSongLabelSongAlbum = new System.Windows.Forms.Label();
            this.addSongButtonAddArtist = new System.Windows.Forms.Button();
            this.addSongComboBoxArtist = new System.Windows.Forms.ComboBox();
            this.addSongLabelSongArtist = new System.Windows.Forms.Label();
            this.addSongLabelSongLength = new System.Windows.Forms.Label();
            this.addSongTextBoxSongLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSongTextBoxRating = new System.Windows.Forms.TextBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.addSongLabelSongTitle = new System.Windows.Forms.Label();
            this.addSongTextBoxSongTitle = new System.Windows.Forms.TextBox();
            this.addSongButtonAddAlbum = new System.Windows.Forms.Button();
            this.addSongPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSongPanel
            // 
            this.addSongPanel.Controls.Add(this.addSongCheckBoxSongToAlbum);
            this.addSongPanel.Controls.Add(this.addSongButtonAddGenre);
            this.addSongPanel.Controls.Add(this.addSongComboBoxGenre);
            this.addSongPanel.Controls.Add(this.label3);
            this.addSongPanel.Controls.Add(this.addSongLabelSongTrackNumber);
            this.addSongPanel.Controls.Add(this.addSongTextBoxSongTrackNumber);
            this.addSongPanel.Controls.Add(this.addSongComboBoxAlbum);
            this.addSongPanel.Controls.Add(this.addSongLabelSongAlbum);
            this.addSongPanel.Controls.Add(this.addSongButtonAddArtist);
            this.addSongPanel.Controls.Add(this.addSongComboBoxArtist);
            this.addSongPanel.Controls.Add(this.addSongLabelSongArtist);
            this.addSongPanel.Controls.Add(this.addSongLabelSongLength);
            this.addSongPanel.Controls.Add(this.addSongTextBoxSongLength);
            this.addSongPanel.Controls.Add(this.label1);
            this.addSongPanel.Controls.Add(this.addSongTextBoxRating);
            this.addSongPanel.Controls.Add(this.addSongButton);
            this.addSongPanel.Controls.Add(this.addSongLabelSongTitle);
            this.addSongPanel.Controls.Add(this.addSongTextBoxSongTitle);
            this.addSongPanel.Controls.Add(this.addSongButtonAddAlbum);
            this.addSongPanel.Location = new System.Drawing.Point(12, 12);
            this.addSongPanel.Name = "addSongPanel";
            this.addSongPanel.Size = new System.Drawing.Size(555, 307);
            this.addSongPanel.TabIndex = 22;
            // 
            // addSongCheckBoxSongToAlbum
            // 
            this.addSongCheckBoxSongToAlbum.AutoSize = true;
            this.addSongCheckBoxSongToAlbum.Checked = true;
            this.addSongCheckBoxSongToAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addSongCheckBoxSongToAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongCheckBoxSongToAlbum.Location = new System.Drawing.Point(6, 153);
            this.addSongCheckBoxSongToAlbum.Name = "addSongCheckBoxSongToAlbum";
            this.addSongCheckBoxSongToAlbum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addSongCheckBoxSongToAlbum.Size = new System.Drawing.Size(183, 26);
            this.addSongCheckBoxSongToAlbum.TabIndex = 35;
            this.addSongCheckBoxSongToAlbum.Text = "Add Song to Album";
            this.addSongCheckBoxSongToAlbum.UseVisualStyleBackColor = true;
            this.addSongCheckBoxSongToAlbum.CheckedChanged += new System.EventHandler(this.addSongCheckBoxSong_CheckedChanged);
            // 
            // addSongButtonAddGenre
            // 
            this.addSongButtonAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButtonAddGenre.Location = new System.Drawing.Point(520, 106);
            this.addSongButtonAddGenre.Name = "addSongButtonAddGenre";
            this.addSongButtonAddGenre.Size = new System.Drawing.Size(32, 28);
            this.addSongButtonAddGenre.TabIndex = 33;
            this.addSongButtonAddGenre.Text = "...";
            this.addSongButtonAddGenre.UseVisualStyleBackColor = true;
            this.addSongButtonAddGenre.Click += new System.EventHandler(this.addSongButtonAddGenre_Click);
            // 
            // addSongComboBoxGenre
            // 
            this.addSongComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSongComboBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongComboBoxGenre.FormattingEnabled = true;
            this.addSongComboBoxGenre.Location = new System.Drawing.Point(144, 106);
            this.addSongComboBoxGenre.Name = "addSongComboBoxGenre";
            this.addSongComboBoxGenre.Size = new System.Drawing.Size(370, 28);
            this.addSongComboBoxGenre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Genre";
            // 
            // addSongLabelSongTrackNumber
            // 
            this.addSongLabelSongTrackNumber.AutoSize = true;
            this.addSongLabelSongTrackNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongLabelSongTrackNumber.Location = new System.Drawing.Point(2, 234);
            this.addSongLabelSongTrackNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLabelSongTrackNumber.Name = "addSongLabelSongTrackNumber";
            this.addSongLabelSongTrackNumber.Size = new System.Drawing.Size(124, 22);
            this.addSongLabelSongTrackNumber.TabIndex = 31;
            this.addSongLabelSongTrackNumber.Text = "Track Number";
            // 
            // addSongTextBoxSongTrackNumber
            // 
            this.addSongTextBoxSongTrackNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongTextBoxSongTrackNumber.Location = new System.Drawing.Point(144, 229);
            this.addSongTextBoxSongTrackNumber.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTextBoxSongTrackNumber.MaxLength = 4;
            this.addSongTextBoxSongTrackNumber.Name = "addSongTextBoxSongTrackNumber";
            this.addSongTextBoxSongTrackNumber.Size = new System.Drawing.Size(370, 27);
            this.addSongTextBoxSongTrackNumber.TabIndex = 4;
            // 
            // addSongComboBoxAlbum
            // 
            this.addSongComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSongComboBoxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongComboBoxAlbum.FormattingEnabled = true;
            this.addSongComboBoxAlbum.Location = new System.Drawing.Point(144, 196);
            this.addSongComboBoxAlbum.Name = "addSongComboBoxAlbum";
            this.addSongComboBoxAlbum.Size = new System.Drawing.Size(370, 28);
            this.addSongComboBoxAlbum.TabIndex = 5;
            // 
            // addSongLabelSongAlbum
            // 
            this.addSongLabelSongAlbum.AutoSize = true;
            this.addSongLabelSongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongLabelSongAlbum.Location = new System.Drawing.Point(2, 199);
            this.addSongLabelSongAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLabelSongAlbum.Name = "addSongLabelSongAlbum";
            this.addSongLabelSongAlbum.Size = new System.Drawing.Size(60, 22);
            this.addSongLabelSongAlbum.TabIndex = 28;
            this.addSongLabelSongAlbum.Text = "Album";
            // 
            // addSongButtonAddArtist
            // 
            this.addSongButtonAddArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButtonAddArtist.Location = new System.Drawing.Point(520, 195);
            this.addSongButtonAddArtist.Name = "addSongButtonAddArtist";
            this.addSongButtonAddArtist.Size = new System.Drawing.Size(32, 28);
            this.addSongButtonAddArtist.TabIndex = 8;
            this.addSongButtonAddArtist.Text = "...";
            this.addSongButtonAddArtist.UseVisualStyleBackColor = true;
            this.addSongButtonAddArtist.Click += new System.EventHandler(this.addSongButtonAddArtist_Click);
            // 
            // addSongComboBoxArtist
            // 
            this.addSongComboBoxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addSongComboBoxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongComboBoxArtist.FormattingEnabled = true;
            this.addSongComboBoxArtist.Location = new System.Drawing.Point(144, 195);
            this.addSongComboBoxArtist.Name = "addSongComboBoxArtist";
            this.addSongComboBoxArtist.Size = new System.Drawing.Size(370, 28);
            this.addSongComboBoxArtist.TabIndex = 7;
            // 
            // addSongLabelSongArtist
            // 
            this.addSongLabelSongArtist.AutoSize = true;
            this.addSongLabelSongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongLabelSongArtist.Location = new System.Drawing.Point(2, 199);
            this.addSongLabelSongArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLabelSongArtist.Name = "addSongLabelSongArtist";
            this.addSongLabelSongArtist.Size = new System.Drawing.Size(51, 22);
            this.addSongLabelSongArtist.TabIndex = 25;
            this.addSongLabelSongArtist.Text = "Artist";
            // 
            // addSongLabelSongLength
            // 
            this.addSongLabelSongLength.AutoSize = true;
            this.addSongLabelSongLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongLabelSongLength.Location = new System.Drawing.Point(2, 79);
            this.addSongLabelSongLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLabelSongLength.Name = "addSongLabelSongLength";
            this.addSongLabelSongLength.Size = new System.Drawing.Size(112, 22);
            this.addSongLabelSongLength.TabIndex = 23;
            this.addSongLabelSongLength.Text = "Song Length";
            // 
            // addSongTextBoxSongLength
            // 
            this.addSongTextBoxSongLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongTextBoxSongLength.Location = new System.Drawing.Point(144, 74);
            this.addSongTextBoxSongLength.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTextBoxSongLength.MaxLength = 3;
            this.addSongTextBoxSongLength.Name = "addSongTextBoxSongLength";
            this.addSongTextBoxSongLength.Size = new System.Drawing.Size(370, 27);
            this.addSongTextBoxSongLength.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rating";
            // 
            // addSongTextBoxRating
            // 
            this.addSongTextBoxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongTextBoxRating.Location = new System.Drawing.Point(144, 43);
            this.addSongTextBoxRating.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTextBoxRating.MaxLength = 1;
            this.addSongTextBoxRating.Name = "addSongTextBoxRating";
            this.addSongTextBoxRating.Size = new System.Drawing.Size(370, 27);
            this.addSongTextBoxRating.TabIndex = 1;
            // 
            // addSongButton
            // 
            this.addSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButton.Location = new System.Drawing.Point(199, 271);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(155, 33);
            this.addSongButton.TabIndex = 9;
            this.addSongButton.Text = "Add";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // addSongLabelSongTitle
            // 
            this.addSongLabelSongTitle.AutoSize = true;
            this.addSongLabelSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongLabelSongTitle.Location = new System.Drawing.Point(2, 17);
            this.addSongLabelSongTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addSongLabelSongTitle.Name = "addSongLabelSongTitle";
            this.addSongLabelSongTitle.Size = new System.Drawing.Size(92, 22);
            this.addSongLabelSongTitle.TabIndex = 18;
            this.addSongLabelSongTitle.Text = "Song Title";
            // 
            // addSongTextBoxSongTitle
            // 
            this.addSongTextBoxSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongTextBoxSongTitle.Location = new System.Drawing.Point(144, 12);
            this.addSongTextBoxSongTitle.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTextBoxSongTitle.Name = "addSongTextBoxSongTitle";
            this.addSongTextBoxSongTitle.Size = new System.Drawing.Size(370, 27);
            this.addSongTextBoxSongTitle.TabIndex = 0;
            // 
            // addSongButtonAddAlbum
            // 
            this.addSongButtonAddAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButtonAddAlbum.Location = new System.Drawing.Point(520, 196);
            this.addSongButtonAddAlbum.Name = "addSongButtonAddAlbum";
            this.addSongButtonAddAlbum.Size = new System.Drawing.Size(32, 28);
            this.addSongButtonAddAlbum.TabIndex = 6;
            this.addSongButtonAddAlbum.Text = "...";
            this.addSongButtonAddAlbum.UseVisualStyleBackColor = true;
            this.addSongButtonAddAlbum.Click += new System.EventHandler(this.addSongButtonAddAlbum_Click);
            // 
            // AddSong
            // 
            this.AcceptButton = this.addSongButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 331);
            this.Controls.Add(this.addSongPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSong";
            this.Text = "Add Song";
            this.addSongPanel.ResumeLayout(false);
            this.addSongPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addSongPanel;
        private System.Windows.Forms.Label addSongLabelSongTrackNumber;
        private System.Windows.Forms.TextBox addSongTextBoxSongTrackNumber;
        private System.Windows.Forms.Button addSongButtonAddAlbum;
        private System.Windows.Forms.ComboBox addSongComboBoxAlbum;
        private System.Windows.Forms.Label addSongLabelSongAlbum;
        private System.Windows.Forms.Button addSongButtonAddArtist;
        private System.Windows.Forms.ComboBox addSongComboBoxArtist;
        private System.Windows.Forms.Label addSongLabelSongArtist;
        private System.Windows.Forms.Label addSongLabelSongLength;
        private System.Windows.Forms.TextBox addSongTextBoxSongLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addSongTextBoxRating;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Label addSongLabelSongTitle;
        private System.Windows.Forms.TextBox addSongTextBoxSongTitle;
        private System.Windows.Forms.Button addSongButtonAddGenre;
        private System.Windows.Forms.ComboBox addSongComboBoxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox addSongCheckBoxSongToAlbum;
    }
}