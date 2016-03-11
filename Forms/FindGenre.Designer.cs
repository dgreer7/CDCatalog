namespace CDCatalog.Forms
{
    partial class FindGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindGenre));
            this.findGenrePanel = new System.Windows.Forms.Panel();
            this.findGenreButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FindGenreTextBox = new System.Windows.Forms.TextBox();
            this.findGenrePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findGenrePanel
            // 
            this.findGenrePanel.Controls.Add(this.findGenreButton);
            this.findGenrePanel.Controls.Add(this.label3);
            this.findGenrePanel.Controls.Add(this.FindGenreTextBox);
            this.findGenrePanel.Location = new System.Drawing.Point(12, 12);
            this.findGenrePanel.Name = "findGenrePanel";
            this.findGenrePanel.Size = new System.Drawing.Size(266, 122);
            this.findGenrePanel.TabIndex = 20;
            // 
            // findGenreButton
            // 
            this.findGenreButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGenreButton.Location = new System.Drawing.Point(56, 87);
            this.findGenreButton.Name = "findGenreButton";
            this.findGenreButton.Size = new System.Drawing.Size(155, 30);
            this.findGenreButton.TabIndex = 19;
            this.findGenreButton.Text = "Find";
            this.findGenreButton.UseVisualStyleBackColor = true;
            this.findGenreButton.Click += new System.EventHandler(this.findGenreButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Find Genre by Name";
            // 
            // FindGenreTextBox
            // 
            this.FindGenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindGenreTextBox.Location = new System.Drawing.Point(2, 43);
            this.FindGenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FindGenreTextBox.Name = "FindGenreTextBox";
            this.FindGenreTextBox.Size = new System.Drawing.Size(262, 27);
            this.FindGenreTextBox.TabIndex = 17;
            // 
            // FindGenre
            // 
            this.AcceptButton = this.findGenreButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 146);
            this.Controls.Add(this.findGenrePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindGenre";
            this.Text = "Find Genre";
            this.findGenrePanel.ResumeLayout(false);
            this.findGenrePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel findGenrePanel;
        private System.Windows.Forms.Button findGenreButton;
        private System.Windows.Forms.TextBox FindGenreTextBox;
        private System.Windows.Forms.Label label3;
    }
}