namespace CDCatalog.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.generateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findSongToolStripMenuItem,
            this.findAlbumToolStripMenuItem,
            this.findGenreToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findSongToolStripMenuItem
            // 
            this.findSongToolStripMenuItem.Name = "findSongToolStripMenuItem";
            this.findSongToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.findSongToolStripMenuItem.Text = "Song";
            this.findSongToolStripMenuItem.Click += new System.EventHandler(this.findSongToolStripMenuItem_Click);
            // 
            // findAlbumToolStripMenuItem
            // 
            this.findAlbumToolStripMenuItem.Name = "findAlbumToolStripMenuItem";
            this.findAlbumToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.findAlbumToolStripMenuItem.Text = "Album";
            this.findAlbumToolStripMenuItem.Click += new System.EventHandler(this.findAlbumToolStripMenuItem_Click);
            // 
            // findGenreToolStripMenuItem
            // 
            this.findGenreToolStripMenuItem.Name = "findGenreToolStripMenuItem";
            this.findGenreToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.findGenreToolStripMenuItem.Text = "Genre";
            this.findGenreToolStripMenuItem.Click += new System.EventHandler(this.findGenreToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlbumToolStripMenuItem,
            this.addArtistToolStripMenuItem,
            this.addGenreToolStripMenuItem,
            this.addSongToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.updateToolStripMenuItem.Text = "Add";
            // 
            // addAlbumToolStripMenuItem
            // 
            this.addAlbumToolStripMenuItem.Name = "addAlbumToolStripMenuItem";
            this.addAlbumToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addAlbumToolStripMenuItem.Text = "Album";
            this.addAlbumToolStripMenuItem.Click += new System.EventHandler(this.albumnToolStripMenuItem1_Click);
            // 
            // addArtistToolStripMenuItem
            // 
            this.addArtistToolStripMenuItem.Name = "addArtistToolStripMenuItem";
            this.addArtistToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addArtistToolStripMenuItem.Text = "Artist";
            this.addArtistToolStripMenuItem.Click += new System.EventHandler(this.artistToolStripMenuItem_Click);
            // 
            // addGenreToolStripMenuItem
            // 
            this.addGenreToolStripMenuItem.Name = "addGenreToolStripMenuItem";
            this.addGenreToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addGenreToolStripMenuItem.Text = "Genre";
            this.addGenreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem1_Click);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addSongToolStripMenuItem.Text = "Song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.songToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSongToolStripMenuItem,
            this.updateAlbumToolStripMenuItem,
            this.updateGenreToolStripMenuItem});
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // updateSongToolStripMenuItem
            // 
            this.updateSongToolStripMenuItem.Name = "updateSongToolStripMenuItem";
            this.updateSongToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.updateSongToolStripMenuItem.Text = "Song";
            // 
            // updateAlbumToolStripMenuItem
            // 
            this.updateAlbumToolStripMenuItem.Name = "updateAlbumToolStripMenuItem";
            this.updateAlbumToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.updateAlbumToolStripMenuItem.Text = "Album";
            // 
            // updateGenreToolStripMenuItem
            // 
            this.updateGenreToolStripMenuItem.Name = "updateGenreToolStripMenuItem";
            this.updateGenreToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.updateGenreToolStripMenuItem.Text = "Genre";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // mainFormDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainFormDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainFormDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainFormDataGridView.Location = new System.Drawing.Point(0, 31);
            this.mainFormDataGridView.Name = "mainFormDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainFormDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainFormDataGridView.Size = new System.Drawing.Size(488, 341);
            this.mainFormDataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 373);
            this.Controls.Add(this.mainFormDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CD Catalog";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addArtistToolStripMenuItem;
        private System.Windows.Forms.DataGridView mainFormDataGridView;
    }
}