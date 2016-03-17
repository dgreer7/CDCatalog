namespace CDCatalog.Forms
{
    partial class UpdateSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSong));
            this.updateSongPanel = new System.Windows.Forms.Panel();
            this.updateSongButton = new System.Windows.Forms.Button();
            this.updateSongLabel = new System.Windows.Forms.Label();
            this.updateSongTextBox = new System.Windows.Forms.TextBox();
            this.updateSongPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateSongPanel
            // 
            this.updateSongPanel.Controls.Add(this.updateSongButton);
            this.updateSongPanel.Controls.Add(this.updateSongLabel);
            this.updateSongPanel.Controls.Add(this.updateSongTextBox);
            this.updateSongPanel.Location = new System.Drawing.Point(12, 13);
            this.updateSongPanel.Name = "updateSongPanel";
            this.updateSongPanel.Size = new System.Drawing.Size(368, 91);
            this.updateSongPanel.TabIndex = 20;
            // 
            // updateSongButton
            // 
            this.updateSongButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSongButton.Location = new System.Drawing.Point(182, 53);
            this.updateSongButton.Name = "updateSongButton";
            this.updateSongButton.Size = new System.Drawing.Size(155, 30);
            this.updateSongButton.TabIndex = 1;
            this.updateSongButton.Text = "Update";
            this.updateSongButton.UseVisualStyleBackColor = true;
            this.updateSongButton.Click += new System.EventHandler(this.updateSongButton_Click);
            // 
            // updateSongLabel
            // 
            this.updateSongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSongLabel.Location = new System.Drawing.Point(2, 0);
            this.updateSongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateSongLabel.Name = "updateSongLabel";
            this.updateSongLabel.Size = new System.Drawing.Size(364, 50);
            this.updateSongLabel.TabIndex = 18;
            this.updateSongLabel.Text = "Update rating of Song by Artist";
            // 
            // updateSongTextBox
            // 
            this.updateSongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSongTextBox.Location = new System.Drawing.Point(26, 52);
            this.updateSongTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateSongTextBox.MaxLength = 1;
            this.updateSongTextBox.Name = "updateSongTextBox";
            this.updateSongTextBox.Size = new System.Drawing.Size(127, 27);
            this.updateSongTextBox.TabIndex = 0;
            // 
            // UpdateSong
            // 
            this.AcceptButton = this.updateSongButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 113);
            this.Controls.Add(this.updateSongPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSong";
            this.Text = "Update Song";
            this.updateSongPanel.ResumeLayout(false);
            this.updateSongPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updateSongPanel;
        private System.Windows.Forms.Button updateSongButton;
        private System.Windows.Forms.Label updateSongLabel;
        private System.Windows.Forms.TextBox updateSongTextBox;
    }
}