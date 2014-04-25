namespace MusicPlayer.Design.EditSongs
{
    partial class EditSong
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
			this.ReleaseDateLbl = new System.Windows.Forms.Label();
			this.ReleaseDateFld = new System.Windows.Forms.DateTimePicker();
			this.BpmFld = new System.Windows.Forms.NumericUpDown();
			this.BpmLbl = new System.Windows.Forms.Label();
			this.EditBttn = new System.Windows.Forms.Button();
			this.AlbumFld = new System.Windows.Forms.TextBox();
			this.ArtistFld = new System.Windows.Forms.TextBox();
			this.TitleFld = new System.Windows.Forms.TextBox();
			this.AlbumLbl = new System.Windows.Forms.Label();
			this.ArtistLbl = new System.Windows.Forms.Label();
			this.TitleLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BpmFld)).BeginInit();
			this.SuspendLayout();
			// 
			// ReleaseDateLbl
			// 
			this.ReleaseDateLbl.AutoSize = true;
			this.ReleaseDateLbl.Location = new System.Drawing.Point(20, 136);
			this.ReleaseDateLbl.Name = "ReleaseDateLbl";
			this.ReleaseDateLbl.Size = new System.Drawing.Size(75, 13);
			this.ReleaseDateLbl.TabIndex = 27;
			this.ReleaseDateLbl.Text = "Release Date:";
			// 
			// ReleaseDateFld
			// 
			this.ReleaseDateFld.Location = new System.Drawing.Point(57, 152);
			this.ReleaseDateFld.Name = "ReleaseDateFld";
			this.ReleaseDateFld.Size = new System.Drawing.Size(200, 20);
			this.ReleaseDateFld.TabIndex = 22;
			this.ReleaseDateFld.Value = new System.DateTime(2014, 4, 20, 0, 0, 0, 0);
			// 
			// BpmFld
			// 
			this.BpmFld.Location = new System.Drawing.Point(57, 104);
			this.BpmFld.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.BpmFld.Name = "BpmFld";
			this.BpmFld.Size = new System.Drawing.Size(49, 20);
			this.BpmFld.TabIndex = 21;
			// 
			// BpmLbl
			// 
			this.BpmLbl.AutoSize = true;
			this.BpmLbl.Location = new System.Drawing.Point(20, 106);
			this.BpmLbl.Name = "BpmLbl";
			this.BpmLbl.Size = new System.Drawing.Size(33, 13);
			this.BpmLbl.TabIndex = 26;
			this.BpmLbl.Text = "BPM:";
			// 
			// EditBttn
			// 
			this.EditBttn.Location = new System.Drawing.Point(26, 182);
			this.EditBttn.Name = "EditBttn";
			this.EditBttn.Size = new System.Drawing.Size(253, 23);
			this.EditBttn.TabIndex = 24;
			this.EditBttn.Text = "Save Changes";
			this.EditBttn.UseVisualStyleBackColor = true;
			this.EditBttn.Click += new System.EventHandler(this.EditBttn_Click);
			// 
			// AlbumFld
			// 
			this.AlbumFld.Location = new System.Drawing.Point(57, 77);
			this.AlbumFld.Name = "AlbumFld";
			this.AlbumFld.Size = new System.Drawing.Size(200, 20);
			this.AlbumFld.TabIndex = 20;
			// 
			// ArtistFld
			// 
			this.ArtistFld.Location = new System.Drawing.Point(57, 50);
			this.ArtistFld.Name = "ArtistFld";
			this.ArtistFld.Size = new System.Drawing.Size(206, 20);
			this.ArtistFld.TabIndex = 18;
			// 
			// TitleFld
			// 
			this.TitleFld.Location = new System.Drawing.Point(57, 21);
			this.TitleFld.Name = "TitleFld";
			this.TitleFld.Size = new System.Drawing.Size(209, 20);
			this.TitleFld.TabIndex = 16;
			// 
			// AlbumLbl
			// 
			this.AlbumLbl.AutoSize = true;
			this.AlbumLbl.Location = new System.Drawing.Point(20, 78);
			this.AlbumLbl.Name = "AlbumLbl";
			this.AlbumLbl.Size = new System.Drawing.Size(39, 13);
			this.AlbumLbl.TabIndex = 19;
			this.AlbumLbl.Text = "Album:";
			// 
			// ArtistLbl
			// 
			this.ArtistLbl.AutoSize = true;
			this.ArtistLbl.Location = new System.Drawing.Point(20, 50);
			this.ArtistLbl.Name = "ArtistLbl";
			this.ArtistLbl.Size = new System.Drawing.Size(33, 13);
			this.ArtistLbl.TabIndex = 17;
			this.ArtistLbl.Text = "Artist:";
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(20, 21);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(30, 13);
			this.TitleLbl.TabIndex = 15;
			this.TitleLbl.Text = "Title:";
			// 
			// EditSong
			// 
			this.AcceptButton = this.EditBttn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 217);
			this.Controls.Add(this.ReleaseDateLbl);
			this.Controls.Add(this.ReleaseDateFld);
			this.Controls.Add(this.BpmFld);
			this.Controls.Add(this.BpmLbl);
			this.Controls.Add(this.EditBttn);
			this.Controls.Add(this.AlbumFld);
			this.Controls.Add(this.ArtistFld);
			this.Controls.Add(this.TitleFld);
			this.Controls.Add(this.AlbumLbl);
			this.Controls.Add(this.ArtistLbl);
			this.Controls.Add(this.TitleLbl);
			this.Name = "EditSong";
			this.Text = "Edit a Song";
			((System.ComponentModel.ISupportInitialize)(this.BpmFld)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReleaseDateLbl;
        private System.Windows.Forms.DateTimePicker ReleaseDateFld;
        private System.Windows.Forms.NumericUpDown BpmFld;
        private System.Windows.Forms.Label BpmLbl;
        private System.Windows.Forms.Button EditBttn;
        private System.Windows.Forms.TextBox AlbumFld;
        private System.Windows.Forms.TextBox ArtistFld;
        private System.Windows.Forms.TextBox TitleFld;
        private System.Windows.Forms.Label AlbumLbl;
        private System.Windows.Forms.Label ArtistLbl;
        private System.Windows.Forms.Label TitleLbl;
    }
}