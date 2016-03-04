namespace CDCatalog
{
    partial class AddGenre
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
            this.label3 = new System.Windows.Forms.Label();
            this.addSongTxtBoxSongGenre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSongButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Genre Name";
            // 
            // addSongTxtBoxSongGenre
            // 
            this.addSongTxtBoxSongGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongTxtBoxSongGenre.Location = new System.Drawing.Point(52, 56);
            this.addSongTxtBoxSongGenre.Margin = new System.Windows.Forms.Padding(2);
            this.addSongTxtBoxSongGenre.Name = "addSongTxtBoxSongGenre";
            this.addSongTxtBoxSongGenre.Size = new System.Drawing.Size(155, 27);
            this.addSongTxtBoxSongGenre.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addSongButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addSongTxtBoxSongGenre);
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 145);
            this.panel1.TabIndex = 19;
            // 
            // addSongButton
            // 
            this.addSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSongButton.Location = new System.Drawing.Point(52, 97);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(155, 30);
            this.addSongButton.TabIndex = 19;
            this.addSongButton.Text = "Add";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 185);
            this.Controls.Add(this.panel1);
            this.Name = "AddGenre";
            this.Text = "AddGenre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addSongTxtBoxSongGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addSongButton;
    }
}