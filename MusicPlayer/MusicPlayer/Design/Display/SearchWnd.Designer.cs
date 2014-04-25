namespace MusicPlayer.Design.Display
{
    partial class SearchWnd
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
			this.SearchFld = new System.Windows.Forms.TextBox();
			this.SearchResultsFld = new System.Windows.Forms.ListView();
			this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SearchBttn = new System.Windows.Forms.Button();
			this.log = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SearchFld
			// 
			this.SearchFld.Location = new System.Drawing.Point(12, 15);
			this.SearchFld.Name = "SearchFld";
			this.SearchFld.Size = new System.Drawing.Size(502, 20);
			this.SearchFld.TabIndex = 5;
			// 
			// SearchResultsFld
			// 
			this.SearchResultsFld.BackColor = System.Drawing.SystemColors.Window;
			this.SearchResultsFld.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Track,
            this.Artist,
            this.Album});
			this.SearchResultsFld.Location = new System.Drawing.Point(12, 41);
			this.SearchResultsFld.Name = "SearchResultsFld";
			this.SearchResultsFld.Size = new System.Drawing.Size(600, 400);
			this.SearchResultsFld.TabIndex = 7;
			this.SearchResultsFld.UseCompatibleStateImageBehavior = false;
			this.SearchResultsFld.View = System.Windows.Forms.View.Details;
			// 
			// Track
			// 
			this.Track.Text = "Track";
			this.Track.Width = 225;
			// 
			// Artist
			// 
			this.Artist.Text = "Artist";
			this.Artist.Width = 150;
			// 
			// Album
			// 
			this.Album.Text = "Album";
			this.Album.Width = 225;
			// 
			// SearchBttn
			// 
			this.SearchBttn.Location = new System.Drawing.Point(521, 13);
			this.SearchBttn.Name = "SearchBttn";
			this.SearchBttn.Size = new System.Drawing.Size(91, 23);
			this.SearchBttn.TabIndex = 8;
			this.SearchBttn.Text = "Search";
			this.SearchBttn.UseVisualStyleBackColor = true;
			this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
			// 
			// log
			// 
			this.log.Location = new System.Drawing.Point(12, 447);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(600, 217);
			this.log.TabIndex = 9;
			// 
			// SearchWnd
			// 
			this.AcceptButton = this.SearchBttn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 676);
			this.Controls.Add(this.log);
			this.Controls.Add(this.SearchBttn);
			this.Controls.Add(this.SearchResultsFld);
			this.Controls.Add(this.SearchFld);
			this.Name = "SearchWnd";
			this.Text = "Search";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchFld;
        private System.Windows.Forms.ListView SearchResultsFld;
        private System.Windows.Forms.ColumnHeader Track;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.Button SearchBttn;
		private System.Windows.Forms.TextBox log;
    }
}