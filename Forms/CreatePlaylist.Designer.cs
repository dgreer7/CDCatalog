namespace CDCatalog.Forms
{
    partial class CreatePlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlaylist));
            this.createPlaylistPanel = new System.Windows.Forms.Panel();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.createPlaylistTextBox = new System.Windows.Forms.TextBox();
            this.createPlaylistPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createPlaylistPanel
            // 
            this.createPlaylistPanel.Controls.Add(this.createPlaylistButton);
            this.createPlaylistPanel.Controls.Add(this.label3);
            this.createPlaylistPanel.Controls.Add(this.createPlaylistTextBox);
            this.createPlaylistPanel.Location = new System.Drawing.Point(12, 12);
            this.createPlaylistPanel.Name = "createPlaylistPanel";
            this.createPlaylistPanel.Size = new System.Drawing.Size(266, 122);
            this.createPlaylistPanel.TabIndex = 21;
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaylistButton.Location = new System.Drawing.Point(56, 87);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(155, 30);
            this.createPlaylistButton.TabIndex = 19;
            this.createPlaylistButton.Text = "Create";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Desired Length in Minutes";
            // 
            // createPlaylistTextBox
            // 
            this.createPlaylistTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaylistTextBox.Location = new System.Drawing.Point(2, 43);
            this.createPlaylistTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.createPlaylistTextBox.MaxLength = 3;
            this.createPlaylistTextBox.Name = "createPlaylistTextBox";
            this.createPlaylistTextBox.Size = new System.Drawing.Size(262, 27);
            this.createPlaylistTextBox.TabIndex = 17;
            // 
            // CreatePlaylist
            // 
            this.AcceptButton = this.createPlaylistButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 146);
            this.Controls.Add(this.createPlaylistPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePlaylist";
            this.Text = "Create Playlist";
            this.createPlaylistPanel.ResumeLayout(false);
            this.createPlaylistPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel createPlaylistPanel;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox createPlaylistTextBox;
    }
}