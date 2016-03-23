namespace CDCatalog.Forms
{
    partial class DisplayAlbumInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayAlbumInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayAlbumArtist = new System.Windows.Forms.Label();
            this.displayAlbumTitle = new System.Windows.Forms.Label();
            this.displayAlbumRating = new System.Windows.Forms.Label();
            this.displayAlbumYear = new System.Windows.Forms.Label();
            this.displayAlbumInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAlbumInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayAlbumRating);
            this.panel1.Controls.Add(this.displayAlbumYear);
            this.panel1.Controls.Add(this.displayAlbumArtist);
            this.panel1.Controls.Add(this.displayAlbumTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 56);
            this.panel1.TabIndex = 1;
            // 
            // displayAlbumArtist
            // 
            this.displayAlbumArtist.AutoSize = true;
            this.displayAlbumArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAlbumArtist.Location = new System.Drawing.Point(3, 32);
            this.displayAlbumArtist.Name = "displayAlbumArtist";
            this.displayAlbumArtist.Size = new System.Drawing.Size(51, 20);
            this.displayAlbumArtist.TabIndex = 1;
            this.displayAlbumArtist.Text = "label1";
            // 
            // displayAlbumTitle
            // 
            this.displayAlbumTitle.AutoSize = true;
            this.displayAlbumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAlbumTitle.Location = new System.Drawing.Point(3, 0);
            this.displayAlbumTitle.Name = "displayAlbumTitle";
            this.displayAlbumTitle.Size = new System.Drawing.Size(51, 20);
            this.displayAlbumTitle.TabIndex = 0;
            this.displayAlbumTitle.Text = "label1";
            // 
            // displayAlbumRating
            // 
            this.displayAlbumRating.AutoSize = true;
            this.displayAlbumRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAlbumRating.Location = new System.Drawing.Point(532, 32);
            this.displayAlbumRating.Name = "displayAlbumRating";
            this.displayAlbumRating.Size = new System.Drawing.Size(51, 20);
            this.displayAlbumRating.TabIndex = 3;
            this.displayAlbumRating.Text = "label1";
            // 
            // displayAlbumYear
            // 
            this.displayAlbumYear.AutoSize = true;
            this.displayAlbumYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAlbumYear.Location = new System.Drawing.Point(532, 0);
            this.displayAlbumYear.Name = "displayAlbumYear";
            this.displayAlbumYear.Size = new System.Drawing.Size(51, 20);
            this.displayAlbumYear.TabIndex = 2;
            this.displayAlbumYear.Text = "label1";
            // 
            // displayAlbumInfoDataGridView
            // 
            this.displayAlbumInfoDataGridView.AllowUserToAddRows = false;
            this.displayAlbumInfoDataGridView.AllowUserToDeleteRows = false;
            this.displayAlbumInfoDataGridView.AllowUserToOrderColumns = true;
            this.displayAlbumInfoDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayAlbumInfoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.displayAlbumInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayAlbumInfoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.displayAlbumInfoDataGridView.Location = new System.Drawing.Point(12, 75);
            this.displayAlbumInfoDataGridView.Name = "displayAlbumInfoDataGridView";
            this.displayAlbumInfoDataGridView.Size = new System.Drawing.Size(880, 271);
            this.displayAlbumInfoDataGridView.TabIndex = 2;
            // 
            // DisplayAlbumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 363);
            this.Controls.Add(this.displayAlbumInfoDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayAlbumInfo";
            this.Text = "Display Album Info";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayAlbumInfo_KeyDown);
            this.Resize += new System.EventHandler(this.DisplayAlbumInfo_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAlbumInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayAlbumArtist;
        private System.Windows.Forms.Label displayAlbumTitle;
        private System.Windows.Forms.Label displayAlbumRating;
        private System.Windows.Forms.Label displayAlbumYear;
        private System.Windows.Forms.DataGridView displayAlbumInfoDataGridView;
    }
}