namespace CDCatalog.Forms
{
    partial class DisplaySongInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySongInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.displaySongTitle = new System.Windows.Forms.Label();
            this.displaySongArtist = new System.Windows.Forms.Label();
            this.displaySongAlbum = new System.Windows.Forms.Label();
            this.displaySongTrackNumber = new System.Windows.Forms.Label();
            this.displaySongLength = new System.Windows.Forms.Label();
            this.displaySongRating = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displaySongRating);
            this.panel1.Controls.Add(this.displaySongLength);
            this.panel1.Controls.Add(this.displaySongTrackNumber);
            this.panel1.Controls.Add(this.displaySongAlbum);
            this.panel1.Controls.Add(this.displaySongArtist);
            this.panel1.Controls.Add(this.displaySongTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 189);
            this.panel1.TabIndex = 0;
            // 
            // displaySongTitle
            // 
            this.displaySongTitle.AutoSize = true;
            this.displaySongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongTitle.Location = new System.Drawing.Point(3, 0);
            this.displaySongTitle.Name = "displaySongTitle";
            this.displaySongTitle.Size = new System.Drawing.Size(51, 20);
            this.displaySongTitle.TabIndex = 0;
            this.displaySongTitle.Text = "label1";
            // 
            // displaySongArtist
            // 
            this.displaySongArtist.AutoSize = true;
            this.displaySongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongArtist.Location = new System.Drawing.Point(3, 32);
            this.displaySongArtist.Name = "displaySongArtist";
            this.displaySongArtist.Size = new System.Drawing.Size(51, 20);
            this.displaySongArtist.TabIndex = 1;
            this.displaySongArtist.Text = "label1";
            // 
            // displaySongAlbum
            // 
            this.displaySongAlbum.AutoSize = true;
            this.displaySongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongAlbum.Location = new System.Drawing.Point(3, 63);
            this.displaySongAlbum.Name = "displaySongAlbum";
            this.displaySongAlbum.Size = new System.Drawing.Size(51, 20);
            this.displaySongAlbum.TabIndex = 2;
            this.displaySongAlbum.Text = "label1";
            // 
            // displaySongTrackNumber
            // 
            this.displaySongTrackNumber.AutoSize = true;
            this.displaySongTrackNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongTrackNumber.Location = new System.Drawing.Point(3, 96);
            this.displaySongTrackNumber.Name = "displaySongTrackNumber";
            this.displaySongTrackNumber.Size = new System.Drawing.Size(51, 20);
            this.displaySongTrackNumber.TabIndex = 3;
            this.displaySongTrackNumber.Text = "label1";
            // 
            // displaySongLength
            // 
            this.displaySongLength.AutoSize = true;
            this.displaySongLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongLength.Location = new System.Drawing.Point(3, 128);
            this.displaySongLength.Name = "displaySongLength";
            this.displaySongLength.Size = new System.Drawing.Size(51, 20);
            this.displaySongLength.TabIndex = 4;
            this.displaySongLength.Text = "label1";
            // 
            // displaySongRating
            // 
            this.displaySongRating.AutoSize = true;
            this.displaySongRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySongRating.Location = new System.Drawing.Point(3, 164);
            this.displaySongRating.Name = "displaySongRating";
            this.displaySongRating.Size = new System.Drawing.Size(51, 20);
            this.displaySongRating.TabIndex = 5;
            this.displaySongRating.Text = "label1";
            // 
            // DisplaySongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 212);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplaySongInfo";
            this.Text = "Display Song Info";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplaySongInfo_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displaySongRating;
        private System.Windows.Forms.Label displaySongLength;
        private System.Windows.Forms.Label displaySongTrackNumber;
        private System.Windows.Forms.Label displaySongAlbum;
        private System.Windows.Forms.Label displaySongArtist;
        private System.Windows.Forms.Label displaySongTitle;
    }
}