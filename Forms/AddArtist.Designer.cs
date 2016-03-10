namespace CDCatalog.Forms
{
    partial class AddArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtist));
            this.addGenrePanel = new System.Windows.Forms.Panel();
            this.addArtistButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addArtistTxtBoxArtistName = new System.Windows.Forms.TextBox();
            this.addGenrePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addGenrePanel
            // 
            this.addGenrePanel.Controls.Add(this.addArtistButton);
            this.addGenrePanel.Controls.Add(this.label3);
            this.addGenrePanel.Controls.Add(this.addArtistTxtBoxArtistName);
            this.addGenrePanel.Location = new System.Drawing.Point(12, 12);
            this.addGenrePanel.Name = "addGenrePanel";
            this.addGenrePanel.Size = new System.Drawing.Size(266, 145);
            this.addGenrePanel.TabIndex = 20;
            // 
            // addArtistButton
            // 
            this.addArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtistButton.Location = new System.Drawing.Point(52, 97);
            this.addArtistButton.Name = "addArtistButton";
            this.addArtistButton.Size = new System.Drawing.Size(155, 30);
            this.addArtistButton.TabIndex = 1;
            this.addArtistButton.Text = "Add";
            this.addArtistButton.UseVisualStyleBackColor = true;
            this.addArtistButton.Click += new System.EventHandler(this.addArtistButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Artist Name";
            // 
            // addArtistTxtBoxArtistName
            // 
            this.addArtistTxtBoxArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addArtistTxtBoxArtistName.Location = new System.Drawing.Point(52, 56);
            this.addArtistTxtBoxArtistName.Margin = new System.Windows.Forms.Padding(2);
            this.addArtistTxtBoxArtistName.Name = "addArtistTxtBoxArtistName";
            this.addArtistTxtBoxArtistName.Size = new System.Drawing.Size(155, 27);
            this.addArtistTxtBoxArtistName.TabIndex = 0;
            // 
            // AddArtist
            // 
            this.AcceptButton = this.addArtistButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 171);
            this.Controls.Add(this.addGenrePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArtist";
            this.Text = "Add Artist";
            this.addGenrePanel.ResumeLayout(false);
            this.addGenrePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addGenrePanel;
        private System.Windows.Forms.Button addArtistButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addArtistTxtBoxArtistName;
    }
}