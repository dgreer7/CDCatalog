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
            this.tabViewSongs = new System.Windows.Forms.TabPage();
            this.tabAddSong = new System.Windows.Forms.TabPage();
            this.tabAddAlbum = new System.Windows.Forms.TabPage();
            this.dataGridViewSongs = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabViewSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabViewSongs);
            this.tabControlMain.Controls.Add(this.tabAddSong);
            this.tabControlMain.Controls.Add(this.tabAddAlbum);
            this.tabControlMain.Location = new System.Drawing.Point(1, 1);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(475, 413);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabViewSongs
            // 
            this.tabViewSongs.Controls.Add(this.dataGridViewSongs);
            this.tabViewSongs.Location = new System.Drawing.Point(4, 22);
            this.tabViewSongs.Name = "tabViewSongs";
            this.tabViewSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewSongs.Size = new System.Drawing.Size(467, 387);
            this.tabViewSongs.TabIndex = 2;
            this.tabViewSongs.Text = "View Songs";
            this.tabViewSongs.UseVisualStyleBackColor = true;
            // 
            // tabAddSong
            // 
            this.tabAddSong.Location = new System.Drawing.Point(4, 22);
            this.tabAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddSong.Name = "tabAddSong";
            this.tabAddSong.Padding = new System.Windows.Forms.Padding(2);
            this.tabAddSong.Size = new System.Drawing.Size(467, 387);
            this.tabAddSong.TabIndex = 0;
            this.tabAddSong.Text = "Add Song";
            this.tabAddSong.UseVisualStyleBackColor = true;
            // 
            // tabAddAlbum
            // 
            this.tabAddAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabAddAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddAlbum.Name = "tabAddAlbum";
            this.tabAddAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.tabAddAlbum.Size = new System.Drawing.Size(467, 387);
            this.tabAddAlbum.TabIndex = 1;
            this.tabAddAlbum.Text = "Add Album";
            this.tabAddAlbum.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSongs
            // 
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSongs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.Size = new System.Drawing.Size(467, 387);
            this.dataGridViewSongs.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 415);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "CD Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabViewSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabAddSong;
        private System.Windows.Forms.TabPage tabAddAlbum;
        private System.Windows.Forms.TabPage tabViewSongs;
        private System.Windows.Forms.DataGridView dataGridViewSongs;
    }
}

