namespace MusicPlayer.Design.EditSongs
{
    partial class AddSong
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
            this.title_label = new System.Windows.Forms.Label();
            this.artist_label = new System.Windows.Forms.Label();
            this.album_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.song_file_label = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.artist_textbox = new System.Windows.Forms.TextBox();
            this.album_textbox = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.NumericUpDown();
            this.choose_song_textbox = new System.Windows.Forms.TextBox();
            this.add_song_button = new System.Windows.Forms.Button();
            this.rating_input = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.price_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating_input)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(13, 39);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(30, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title:";
            // 
            // artist_label
            // 
            this.artist_label.AutoSize = true;
            this.artist_label.Location = new System.Drawing.Point(13, 68);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(33, 13);
            this.artist_label.TabIndex = 1;
            this.artist_label.Text = "Artist:";
            // 
            // album_label
            // 
            this.album_label.AutoSize = true;
            this.album_label.Location = new System.Drawing.Point(13, 96);
            this.album_label.Name = "album_label";
            this.album_label.Size = new System.Drawing.Size(39, 13);
            this.album_label.TabIndex = 2;
            this.album_label.Text = "Album:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(13, 126);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(64, 13);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Price: (US$)";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(11, 160);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(41, 13);
            this.rating_label.TabIndex = 4;
            this.rating_label.Text = "Rating:";
            // 
            // song_file_label
            // 
            this.song_file_label.AutoSize = true;
            this.song_file_label.Location = new System.Drawing.Point(12, 210);
            this.song_file_label.Name = "song_file_label";
            this.song_file_label.Size = new System.Drawing.Size(54, 13);
            this.song_file_label.TabIndex = 5;
            this.song_file_label.Text = "Song File:";
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(50, 39);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(209, 20);
            this.title_textbox.TabIndex = 6;
            // 
            // artist_textbox
            // 
            this.artist_textbox.Location = new System.Drawing.Point(53, 68);
            this.artist_textbox.Name = "artist_textbox";
            this.artist_textbox.Size = new System.Drawing.Size(206, 20);
            this.artist_textbox.TabIndex = 7;
            // 
            // album_textbox
            // 
            this.album_textbox.Location = new System.Drawing.Point(59, 96);
            this.album_textbox.Name = "album_textbox";
            this.album_textbox.Size = new System.Drawing.Size(200, 20);
            this.album_textbox.TabIndex = 8;
            // 
            // price_input
            // 
            this.price_input.DecimalPlaces = 2;
            this.price_input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price_input.Location = new System.Drawing.Point(84, 126);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(120, 20);
            this.price_input.TabIndex = 9;
            this.price_input.Tag = "";
            // 
            // choose_song_textbox
            // 
            this.choose_song_textbox.Location = new System.Drawing.Point(72, 207);
            this.choose_song_textbox.Name = "choose_song_textbox";
            this.choose_song_textbox.Size = new System.Drawing.Size(134, 20);
            this.choose_song_textbox.TabIndex = 11;
            this.choose_song_textbox.Text = "Click to choose song...";
            this.choose_song_textbox.TextChanged += new System.EventHandler(this.choose_song_textbox_TextChanged);
            // 
            // add_song_button
            // 
            this.add_song_button.Location = new System.Drawing.Point(22, 250);
            this.add_song_button.Name = "add_song_button";
            this.add_song_button.Size = new System.Drawing.Size(247, 23);
            this.add_song_button.TabIndex = 12;
            this.add_song_button.Text = "Add Song";
            this.add_song_button.UseVisualStyleBackColor = true;
            this.add_song_button.Click += new System.EventHandler(this.add_song_button_Click);
            // 
            // rating_input
            // 
            this.rating_input.DecimalPlaces = 1;
            this.rating_input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rating_input.Location = new System.Drawing.Point(59, 158);
            this.rating_input.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rating_input.Name = "rating_input";
            this.rating_input.Size = new System.Drawing.Size(41, 20);
            this.rating_input.TabIndex = 13;
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 492);
            this.Controls.Add(this.rating_input);
            this.Controls.Add(this.add_song_button);
            this.Controls.Add(this.choose_song_textbox);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.album_textbox);
            this.Controls.Add(this.artist_textbox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.song_file_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.album_label);
            this.Controls.Add(this.artist_label);
            this.Controls.Add(this.title_label);
            this.Name = "AddSong";
            this.Text = "AddSong";
            ((System.ComponentModel.ISupportInitialize)(this.price_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label artist_label;
        private System.Windows.Forms.Label album_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.Label song_file_label;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.TextBox artist_textbox;
        private System.Windows.Forms.TextBox album_textbox;
        private System.Windows.Forms.NumericUpDown price_input;
        private System.Windows.Forms.TextBox choose_song_textbox;
        private System.Windows.Forms.Button add_song_button;
        private System.Windows.Forms.NumericUpDown rating_input;
    }
}