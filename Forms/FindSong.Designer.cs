namespace CDCatalog.Forms
{
    partial class FindSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindSong));
            this.findSongPanel = new System.Windows.Forms.Panel();
            this.findSongRadioButtonByArtist = new System.Windows.Forms.RadioButton();
            this.findSongRadioButtonByGenre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.findSongRadioButtonBySongTitle = new System.Windows.Forms.RadioButton();
            this.findSongComboBoxGenre = new System.Windows.Forms.ComboBox();
            this.findSongLabelGenre = new System.Windows.Forms.Label();
            this.findSongComboBoxArtist = new System.Windows.Forms.ComboBox();
            this.findSongLabelArtist = new System.Windows.Forms.Label();
            this.findSongLabelSongTitle = new System.Windows.Forms.Label();
            this.findSongTextBoxSongTitle = new System.Windows.Forms.TextBox();
            this.findSongButton = new System.Windows.Forms.Button();
            this.findSongPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findSongPanel
            // 
            this.findSongPanel.Controls.Add(this.findSongButton);
            this.findSongPanel.Controls.Add(this.findSongRadioButtonByArtist);
            this.findSongPanel.Controls.Add(this.findSongRadioButtonByGenre);
            this.findSongPanel.Controls.Add(this.label1);
            this.findSongPanel.Controls.Add(this.findSongRadioButtonBySongTitle);
            this.findSongPanel.Controls.Add(this.findSongComboBoxGenre);
            this.findSongPanel.Controls.Add(this.findSongLabelGenre);
            this.findSongPanel.Controls.Add(this.findSongComboBoxArtist);
            this.findSongPanel.Controls.Add(this.findSongLabelArtist);
            this.findSongPanel.Controls.Add(this.findSongLabelSongTitle);
            this.findSongPanel.Controls.Add(this.findSongTextBoxSongTitle);
            this.findSongPanel.Location = new System.Drawing.Point(12, 12);
            this.findSongPanel.Name = "findSongPanel";
            this.findSongPanel.Size = new System.Drawing.Size(555, 124);
            this.findSongPanel.TabIndex = 23;
            // 
            // findSongRadioButtonByArtist
            // 
            this.findSongRadioButtonByArtist.AutoSize = true;
            this.findSongRadioButtonByArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongRadioButtonByArtist.Location = new System.Drawing.Point(466, 10);
            this.findSongRadioButtonByArtist.Name = "findSongRadioButtonByArtist";
            this.findSongRadioButtonByArtist.Size = new System.Drawing.Size(59, 22);
            this.findSongRadioButtonByArtist.TabIndex = 38;
            this.findSongRadioButtonByArtist.Text = "Artist";
            this.findSongRadioButtonByArtist.UseVisualStyleBackColor = true;
            // 
            // findSongRadioButtonByGenre
            // 
            this.findSongRadioButtonByGenre.AutoSize = true;
            this.findSongRadioButtonByGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongRadioButtonByGenre.Location = new System.Drawing.Point(332, 10);
            this.findSongRadioButtonByGenre.Name = "findSongRadioButtonByGenre";
            this.findSongRadioButtonByGenre.Size = new System.Drawing.Size(67, 22);
            this.findSongRadioButtonByGenre.TabIndex = 35;
            this.findSongRadioButtonByGenre.Text = "Genre";
            this.findSongRadioButtonByGenre.UseVisualStyleBackColor = true;
            this.findSongRadioButtonByGenre.CheckedChanged += new System.EventHandler(this.findSongRadioButtonByGenre_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Locate Song by";
            // 
            // findSongRadioButtonBySongTitle
            // 
            this.findSongRadioButtonBySongTitle.AutoSize = true;
            this.findSongRadioButtonBySongTitle.Checked = true;
            this.findSongRadioButtonBySongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongRadioButtonBySongTitle.Location = new System.Drawing.Point(177, 9);
            this.findSongRadioButtonBySongTitle.Name = "findSongRadioButtonBySongTitle";
            this.findSongRadioButtonBySongTitle.Size = new System.Drawing.Size(92, 22);
            this.findSongRadioButtonBySongTitle.TabIndex = 36;
            this.findSongRadioButtonBySongTitle.TabStop = true;
            this.findSongRadioButtonBySongTitle.Text = "Song Title";
            this.findSongRadioButtonBySongTitle.UseVisualStyleBackColor = true;
            this.findSongRadioButtonBySongTitle.CheckedChanged += new System.EventHandler(this.findSongRadioButtonBySongTitle_CheckedChanged);
            // 
            // findSongComboBoxGenre
            // 
            this.findSongComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findSongComboBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongComboBoxGenre.FormattingEnabled = true;
            this.findSongComboBoxGenre.Location = new System.Drawing.Point(144, 47);
            this.findSongComboBoxGenre.Name = "findSongComboBoxGenre";
            this.findSongComboBoxGenre.Size = new System.Drawing.Size(409, 28);
            this.findSongComboBoxGenre.TabIndex = 32;
            // 
            // findSongLabelGenre
            // 
            this.findSongLabelGenre.AutoSize = true;
            this.findSongLabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongLabelGenre.Location = new System.Drawing.Point(2, 50);
            this.findSongLabelGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findSongLabelGenre.Name = "findSongLabelGenre";
            this.findSongLabelGenre.Size = new System.Drawing.Size(60, 22);
            this.findSongLabelGenre.TabIndex = 34;
            this.findSongLabelGenre.Text = "Genre";
            // 
            // findSongComboBoxArtist
            // 
            this.findSongComboBoxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findSongComboBoxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongComboBoxArtist.FormattingEnabled = true;
            this.findSongComboBoxArtist.Location = new System.Drawing.Point(144, 47);
            this.findSongComboBoxArtist.Name = "findSongComboBoxArtist";
            this.findSongComboBoxArtist.Size = new System.Drawing.Size(409, 28);
            this.findSongComboBoxArtist.TabIndex = 5;
            // 
            // findSongLabelArtist
            // 
            this.findSongLabelArtist.AutoSize = true;
            this.findSongLabelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongLabelArtist.Location = new System.Drawing.Point(2, 50);
            this.findSongLabelArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findSongLabelArtist.Name = "findSongLabelArtist";
            this.findSongLabelArtist.Size = new System.Drawing.Size(51, 22);
            this.findSongLabelArtist.TabIndex = 28;
            this.findSongLabelArtist.Text = "Artist";
            // 
            // findSongLabelSongTitle
            // 
            this.findSongLabelSongTitle.AutoSize = true;
            this.findSongLabelSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongLabelSongTitle.Location = new System.Drawing.Point(2, 52);
            this.findSongLabelSongTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findSongLabelSongTitle.Name = "findSongLabelSongTitle";
            this.findSongLabelSongTitle.Size = new System.Drawing.Size(92, 22);
            this.findSongLabelSongTitle.TabIndex = 18;
            this.findSongLabelSongTitle.Text = "Song Title";
            // 
            // findSongTextBoxSongTitle
            // 
            this.findSongTextBoxSongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongTextBoxSongTitle.Location = new System.Drawing.Point(144, 47);
            this.findSongTextBoxSongTitle.Margin = new System.Windows.Forms.Padding(2);
            this.findSongTextBoxSongTitle.Name = "findSongTextBoxSongTitle";
            this.findSongTextBoxSongTitle.Size = new System.Drawing.Size(409, 27);
            this.findSongTextBoxSongTitle.TabIndex = 0;
            // 
            // findSongButton
            // 
            this.findSongButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findSongButton.Location = new System.Drawing.Point(199, 88);
            this.findSongButton.Name = "findSongButton";
            this.findSongButton.Size = new System.Drawing.Size(155, 33);
            this.findSongButton.TabIndex = 39;
            this.findSongButton.Text = "Find";
            this.findSongButton.UseVisualStyleBackColor = true;
            this.findSongButton.Click += new System.EventHandler(this.findSongButton_Click);
            // 
            // FindSong
            // 
            this.AcceptButton = this.findSongButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 147);
            this.Controls.Add(this.findSongPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindSong";
            this.Text = "Find Song";
            this.findSongPanel.ResumeLayout(false);
            this.findSongPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel findSongPanel;
        private System.Windows.Forms.ComboBox findSongComboBoxGenre;
        private System.Windows.Forms.Label findSongLabelGenre;
        private System.Windows.Forms.ComboBox findSongComboBoxArtist;
        private System.Windows.Forms.Label findSongLabelArtist;
        private System.Windows.Forms.Label findSongLabelSongTitle;
        private System.Windows.Forms.TextBox findSongTextBoxSongTitle;
        private System.Windows.Forms.RadioButton findSongRadioButtonByArtist;
        private System.Windows.Forms.RadioButton findSongRadioButtonByGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton findSongRadioButtonBySongTitle;
        private System.Windows.Forms.Button findSongButton;
    }
}