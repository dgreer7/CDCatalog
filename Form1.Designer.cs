namespace CDCatalog
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabAddSong = new System.Windows.Forms.TabPage();
            this.tabAddAlbum = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabAddSong);
            this.tabControlMain.Controls.Add(this.tabAddAlbum);
            this.tabControlMain.Location = new System.Drawing.Point(1, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(530, 405);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabAddSong
            // 
            this.tabAddSong.Location = new System.Drawing.Point(4, 25);
            this.tabAddSong.Name = "tabAddSong";
            this.tabAddSong.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSong.Size = new System.Drawing.Size(522, 376);
            this.tabAddSong.TabIndex = 0;
            this.tabAddSong.Text = "Add Song";
            this.tabAddSong.UseVisualStyleBackColor = true;
            // 
            // tabAddAlbum
            // 
            this.tabAddAlbum.Location = new System.Drawing.Point(4, 25);
            this.tabAddAlbum.Name = "tabAddAlbum";
            this.tabAddAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAlbum.Size = new System.Drawing.Size(522, 376);
            this.tabAddAlbum.TabIndex = 1;
            this.tabAddAlbum.Text = "Add Album";
            this.tabAddAlbum.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 418);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "CD Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSong;
        private System.Windows.Forms.TabPage tabAddAlbum;
    }
}

