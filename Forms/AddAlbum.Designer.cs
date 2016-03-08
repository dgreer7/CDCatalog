namespace CDCatalog.Forms
{
    partial class AddAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbum));
            this.addGenrePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.addAlbumLabelAlbumYear = new System.Windows.Forms.Label();
            this.addAlbumTextBoxAlbumYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAlbumTextBoxRating = new System.Windows.Forms.TextBox();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.addAlbumLabelAlbumName = new System.Windows.Forms.Label();
            this.addAlbumTxtBoxAlbumName = new System.Windows.Forms.TextBox();
            this.addAlbumComboBoxArtist = new System.Windows.Forms.ComboBox();
            this.addGenrePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addGenrePanel
            // 
            this.addGenrePanel.Controls.Add(this.addAlbumComboBoxArtist);
            this.addGenrePanel.Controls.Add(this.label4);
            this.addGenrePanel.Controls.Add(this.addAlbumLabelAlbumYear);
            this.addGenrePanel.Controls.Add(this.addAlbumTextBoxAlbumYear);
            this.addGenrePanel.Controls.Add(this.label1);
            this.addGenrePanel.Controls.Add(this.addAlbumTextBoxRating);
            this.addGenrePanel.Controls.Add(this.addAlbumButton);
            this.addGenrePanel.Controls.Add(this.addAlbumLabelAlbumName);
            this.addGenrePanel.Controls.Add(this.addAlbumTxtBoxAlbumName);
            this.addGenrePanel.Location = new System.Drawing.Point(12, 12);
            this.addGenrePanel.Name = "addGenrePanel";
            this.addGenrePanel.Size = new System.Drawing.Size(352, 193);
            this.addGenrePanel.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Artist";
            // 
            // addAlbumLabelAlbumYear
            // 
            this.addAlbumLabelAlbumYear.AutoSize = true;
            this.addAlbumLabelAlbumYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumLabelAlbumYear.Location = new System.Drawing.Point(2, 51);
            this.addAlbumLabelAlbumYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addAlbumLabelAlbumYear.Name = "addAlbumLabelAlbumYear";
            this.addAlbumLabelAlbumYear.Size = new System.Drawing.Size(103, 22);
            this.addAlbumLabelAlbumYear.TabIndex = 23;
            this.addAlbumLabelAlbumYear.Text = "Album Year";
            // 
            // addAlbumTxtBoxAlbumYear
            // 
            this.addAlbumTextBoxAlbumYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumTextBoxAlbumYear.Location = new System.Drawing.Point(157, 46);
            this.addAlbumTextBoxAlbumYear.Margin = new System.Windows.Forms.Padding(2);
            this.addAlbumTextBoxAlbumYear.Name = "addAlbumTxtBoxAlbumYear";
            this.addAlbumTextBoxAlbumYear.Size = new System.Drawing.Size(147, 27);
            this.addAlbumTextBoxAlbumYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rating";
            // 
            // addAlbumTextBoxRating
            // 
            this.addAlbumTextBoxRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumTextBoxRating.Location = new System.Drawing.Point(157, 80);
            this.addAlbumTextBoxRating.Margin = new System.Windows.Forms.Padding(2);
            this.addAlbumTextBoxRating.Name = "addAlbumTextBoxRating";
            this.addAlbumTextBoxRating.Size = new System.Drawing.Size(147, 27);
            this.addAlbumTextBoxRating.TabIndex = 2;
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumButton.Location = new System.Drawing.Point(102, 160);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(155, 30);
            this.addAlbumButton.TabIndex = 5;
            this.addAlbumButton.Text = "Add";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // addAlbumLabelAlbumName
            // 
            this.addAlbumLabelAlbumName.AutoSize = true;
            this.addAlbumLabelAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumLabelAlbumName.Location = new System.Drawing.Point(2, 17);
            this.addAlbumLabelAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addAlbumLabelAlbumName.Name = "addAlbumLabelAlbumName";
            this.addAlbumLabelAlbumName.Size = new System.Drawing.Size(112, 22);
            this.addAlbumLabelAlbumName.TabIndex = 18;
            this.addAlbumLabelAlbumName.Text = "Album Name";
            // 
            // addAlbumTxtBoxAlbumName
            // 
            this.addAlbumTxtBoxAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumTxtBoxAlbumName.Location = new System.Drawing.Point(157, 12);
            this.addAlbumTxtBoxAlbumName.Margin = new System.Windows.Forms.Padding(2);
            this.addAlbumTxtBoxAlbumName.Name = "addAlbumTxtBoxAlbumName";
            this.addAlbumTxtBoxAlbumName.Size = new System.Drawing.Size(147, 27);
            this.addAlbumTxtBoxAlbumName.TabIndex = 0;
            // 
            // addAlbumComboBoxArtist
            // 
            this.addAlbumComboBoxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlbumComboBoxArtist.FormattingEnabled = true;
            this.addAlbumComboBoxArtist.Location = new System.Drawing.Point(157, 114);
            this.addAlbumComboBoxArtist.Name = "addAlbumComboBoxArtist";
            this.addAlbumComboBoxArtist.Size = new System.Drawing.Size(147, 28);
            this.addAlbumComboBoxArtist.TabIndex = 3;
            // 
            // AddAlbum
            // 
            this.AcceptButton = this.addAlbumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 217);
            this.Controls.Add(this.addGenrePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAlbum";
            this.Text = "Add Album";
            this.addGenrePanel.ResumeLayout(false);
            this.addGenrePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addGenrePanel;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Label addAlbumLabelAlbumName;
        private System.Windows.Forms.TextBox addAlbumTxtBoxAlbumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addAlbumLabelAlbumYear;
        private System.Windows.Forms.TextBox addAlbumTextBoxAlbumYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addAlbumTextBoxRating;
        private System.Windows.Forms.ComboBox addAlbumComboBoxArtist;
    }
}