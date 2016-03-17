namespace CDCatalog.Forms
{
    partial class UpdateAlbum
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
            this.updateAlbumPanel = new System.Windows.Forms.Panel();
            this.updateAlbumButton = new System.Windows.Forms.Button();
            this.updateAlbumLabel = new System.Windows.Forms.Label();
            this.updateAlbumTextBox = new System.Windows.Forms.TextBox();
            this.updateAlbumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateAlbumPanel
            // 
            this.updateAlbumPanel.Controls.Add(this.updateAlbumButton);
            this.updateAlbumPanel.Controls.Add(this.updateAlbumLabel);
            this.updateAlbumPanel.Controls.Add(this.updateAlbumTextBox);
            this.updateAlbumPanel.Location = new System.Drawing.Point(12, 11);
            this.updateAlbumPanel.Name = "updateAlbumPanel";
            this.updateAlbumPanel.Size = new System.Drawing.Size(368, 91);
            this.updateAlbumPanel.TabIndex = 21;
            // 
            // updateAlbumButton
            // 
            this.updateAlbumButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAlbumButton.Location = new System.Drawing.Point(182, 53);
            this.updateAlbumButton.Name = "updateAlbumButton";
            this.updateAlbumButton.Size = new System.Drawing.Size(155, 30);
            this.updateAlbumButton.TabIndex = 1;
            this.updateAlbumButton.Text = "Update";
            this.updateAlbumButton.UseVisualStyleBackColor = true;
            this.updateAlbumButton.Click += new System.EventHandler(this.updateAlbumButton_Click);
            // 
            // updateAlbumLabel
            // 
            this.updateAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAlbumLabel.Location = new System.Drawing.Point(2, 0);
            this.updateAlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateAlbumLabel.Name = "updateAlbumLabel";
            this.updateAlbumLabel.Size = new System.Drawing.Size(364, 50);
            this.updateAlbumLabel.TabIndex = 18;
            this.updateAlbumLabel.Text = "Update rating of Album by Artist";
            // 
            // updateAlbumTextBox
            // 
            this.updateAlbumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAlbumTextBox.Location = new System.Drawing.Point(26, 52);
            this.updateAlbumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateAlbumTextBox.MaxLength = 1;
            this.updateAlbumTextBox.Name = "updateAlbumTextBox";
            this.updateAlbumTextBox.Size = new System.Drawing.Size(127, 27);
            this.updateAlbumTextBox.TabIndex = 0;
            // 
            // UpdateAlbum
            // 
            this.AcceptButton = this.updateAlbumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 113);
            this.Controls.Add(this.updateAlbumPanel);
            this.Name = "UpdateAlbum";
            this.Text = "Update Album";
            this.updateAlbumPanel.ResumeLayout(false);
            this.updateAlbumPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateAlbumPanel;
        private System.Windows.Forms.Button updateAlbumButton;
        private System.Windows.Forms.Label updateAlbumLabel;
        private System.Windows.Forms.TextBox updateAlbumTextBox;
    }
}