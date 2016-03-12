namespace CDCatalog.Forms
{
    partial class FindAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAlbum));
            this.findAlbumPanel = new System.Windows.Forms.Panel();
            this.findAlbumComboBoxArtist = new System.Windows.Forms.ComboBox();
            this.findAlbumLabelArtist = new System.Windows.Forms.Label();
            this.findAlbumButton = new System.Windows.Forms.Button();
            this.findAlbumLabelAlbumName = new System.Windows.Forms.Label();
            this.findAlbumTxtBoxAlbumName = new System.Windows.Forms.TextBox();
            this.findAlbumRadioButtonByAlbumName = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.findAlbumRadioButtonByArtist = new System.Windows.Forms.RadioButton();
            this.findAlbumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findAlbumPanel
            // 
            this.findAlbumPanel.Controls.Add(this.findAlbumRadioButtonByArtist);
            this.findAlbumPanel.Controls.Add(this.label1);
            this.findAlbumPanel.Controls.Add(this.findAlbumRadioButtonByAlbumName);
            this.findAlbumPanel.Controls.Add(this.findAlbumComboBoxArtist);
            this.findAlbumPanel.Controls.Add(this.findAlbumLabelArtist);
            this.findAlbumPanel.Controls.Add(this.findAlbumButton);
            this.findAlbumPanel.Controls.Add(this.findAlbumLabelAlbumName);
            this.findAlbumPanel.Controls.Add(this.findAlbumTxtBoxAlbumName);
            this.findAlbumPanel.Location = new System.Drawing.Point(12, 12);
            this.findAlbumPanel.Name = "findAlbumPanel";
            this.findAlbumPanel.Size = new System.Drawing.Size(509, 124);
            this.findAlbumPanel.TabIndex = 21;
            // 
            // findAlbumComboBoxArtist
            // 
            this.findAlbumComboBoxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findAlbumComboBoxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumComboBoxArtist.FormattingEnabled = true;
            this.findAlbumComboBoxArtist.Location = new System.Drawing.Point(144, 47);
            this.findAlbumComboBoxArtist.Name = "findAlbumComboBoxArtist";
            this.findAlbumComboBoxArtist.Size = new System.Drawing.Size(362, 28);
            this.findAlbumComboBoxArtist.TabIndex = 1;
            // 
            // findAlbumLabelArtist
            // 
            this.findAlbumLabelArtist.AutoSize = true;
            this.findAlbumLabelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumLabelArtist.Location = new System.Drawing.Point(2, 53);
            this.findAlbumLabelArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findAlbumLabelArtist.Name = "findAlbumLabelArtist";
            this.findAlbumLabelArtist.Size = new System.Drawing.Size(51, 22);
            this.findAlbumLabelArtist.TabIndex = 25;
            this.findAlbumLabelArtist.Text = "Artist";
            // 
            // findAlbumButton
            // 
            this.findAlbumButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumButton.Location = new System.Drawing.Point(177, 88);
            this.findAlbumButton.Name = "findAlbumButton";
            this.findAlbumButton.Size = new System.Drawing.Size(155, 33);
            this.findAlbumButton.TabIndex = 2;
            this.findAlbumButton.Text = "Find";
            this.findAlbumButton.UseVisualStyleBackColor = true;
            this.findAlbumButton.Click += new System.EventHandler(this.findAlbumButton_Click);
            // 
            // findAlbumLabelAlbumName
            // 
            this.findAlbumLabelAlbumName.AutoSize = true;
            this.findAlbumLabelAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumLabelAlbumName.Location = new System.Drawing.Point(2, 53);
            this.findAlbumLabelAlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findAlbumLabelAlbumName.Name = "findAlbumLabelAlbumName";
            this.findAlbumLabelAlbumName.Size = new System.Drawing.Size(112, 22);
            this.findAlbumLabelAlbumName.TabIndex = 18;
            this.findAlbumLabelAlbumName.Text = "Album Name";
            // 
            // findAlbumTxtBoxAlbumName
            // 
            this.findAlbumTxtBoxAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumTxtBoxAlbumName.Location = new System.Drawing.Point(144, 48);
            this.findAlbumTxtBoxAlbumName.Margin = new System.Windows.Forms.Padding(2);
            this.findAlbumTxtBoxAlbumName.Name = "findAlbumTxtBoxAlbumName";
            this.findAlbumTxtBoxAlbumName.Size = new System.Drawing.Size(362, 27);
            this.findAlbumTxtBoxAlbumName.TabIndex = 1;
            // 
            // findAlbumRadioButtonByAlbumName
            // 
            this.findAlbumRadioButtonByAlbumName.AutoSize = true;
            this.findAlbumRadioButtonByAlbumName.Checked = true;
            this.findAlbumRadioButtonByAlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumRadioButtonByAlbumName.Location = new System.Drawing.Point(177, 8);
            this.findAlbumRadioButtonByAlbumName.Name = "findAlbumRadioButtonByAlbumName";
            this.findAlbumRadioButtonByAlbumName.Size = new System.Drawing.Size(111, 22);
            this.findAlbumRadioButtonByAlbumName.TabIndex = 26;
            this.findAlbumRadioButtonByAlbumName.TabStop = true;
            this.findAlbumRadioButtonByAlbumName.Text = "Album Name";
            this.findAlbumRadioButtonByAlbumName.UseVisualStyleBackColor = true;
            this.findAlbumRadioButtonByAlbumName.CheckedChanged += new System.EventHandler(this.findAlbumRadioButtonByAlbumName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Locate Album by";
            // 
            // findAlbumRadioButtonByArtist
            // 
            this.findAlbumRadioButtonByArtist.AutoSize = true;
            this.findAlbumRadioButtonByArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAlbumRadioButtonByArtist.Location = new System.Drawing.Point(332, 9);
            this.findAlbumRadioButtonByArtist.Name = "findAlbumRadioButtonByArtist";
            this.findAlbumRadioButtonByArtist.Size = new System.Drawing.Size(59, 22);
            this.findAlbumRadioButtonByArtist.TabIndex = 0;
            this.findAlbumRadioButtonByArtist.Text = "Artist";
            this.findAlbumRadioButtonByArtist.UseVisualStyleBackColor = true;
            // 
            // FindAlbum
            // 
            this.AcceptButton = this.findAlbumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 146);
            this.Controls.Add(this.findAlbumPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindAlbum";
            this.Text = "Find Album";
            this.findAlbumPanel.ResumeLayout(false);
            this.findAlbumPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label findAlbumLabelArtist;
        private System.Windows.Forms.Button findAlbumButton;
        private System.Windows.Forms.TextBox findAlbumTxtBoxAlbumName;
        private System.Windows.Forms.Label findAlbumLabelAlbumName;
        private System.Windows.Forms.ComboBox findAlbumComboBoxArtist;
        private System.Windows.Forms.Panel findAlbumPanel;
        private System.Windows.Forms.RadioButton findAlbumRadioButtonByArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton findAlbumRadioButtonByAlbumName;
    }
}