namespace MusicPlayer.Design.Display
{
    partial class ChooseDisplay
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
            this.title_button = new System.Windows.Forms.Button();
            this.Artist = new System.Windows.Forms.Button();
            this.album_button = new System.Windows.Forms.Button();
            this.songs_list_view = new System.Windows.Forms.ListView();
            this.Titles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Albums = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // title_button
            // 
            this.title_button.Location = new System.Drawing.Point(13, 13);
            this.title_button.Name = "title_button";
            this.title_button.Size = new System.Drawing.Size(75, 23);
            this.title_button.TabIndex = 0;
            this.title_button.Text = "Title";
            this.title_button.UseVisualStyleBackColor = true;
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(95, 12);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(75, 23);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Artist";
            this.Artist.UseVisualStyleBackColor = true;
            // 
            // album_button
            // 
            this.album_button.Location = new System.Drawing.Point(177, 12);
            this.album_button.Name = "album_button";
            this.album_button.Size = new System.Drawing.Size(75, 23);
            this.album_button.TabIndex = 2;
            this.album_button.Text = "Album";
            this.album_button.UseVisualStyleBackColor = true;
            // 
            // songs_list_view
            // 
            this.songs_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titles,
            this.Artists,
            this.Albums});
            this.songs_list_view.Location = new System.Drawing.Point(13, 43);
            this.songs_list_view.Name = "songs_list_view";
            this.songs_list_view.Size = new System.Drawing.Size(447, 285);
            this.songs_list_view.TabIndex = 3;
            this.songs_list_view.UseCompatibleStateImageBehavior = false;
            this.songs_list_view.View = System.Windows.Forms.View.Details;
            // 
            // Titles
            // 
            this.Titles.Text = "Title";
            this.Titles.Width = 150;
            // 
            // Artists
            // 
            this.Artists.Text = "Artist";
            this.Artists.Width = 150;
            // 
            // Albums
            // 
            this.Albums.Text = "Album";
            this.Albums.Width = 150;
            // 
            // ChooseDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 340);
            this.Controls.Add(this.songs_list_view);
            this.Controls.Add(this.album_button);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.title_button);
            this.Name = "ChooseDisplay";
            this.Text = "ChooseDisplay";
            this.Load += new System.EventHandler(this.ChooseDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button title_button;
        private System.Windows.Forms.Button Artist;
        private System.Windows.Forms.Button album_button;
        private System.Windows.Forms.ListView songs_list_view;
        private System.Windows.Forms.ColumnHeader Titles;
        private System.Windows.Forms.ColumnHeader Artists;
        private System.Windows.Forms.ColumnHeader Albums;
    }
}