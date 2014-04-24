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
            this.song_file_label = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.artist_textbox = new System.Windows.Forms.TextBox();
            this.album_textbox = new System.Windows.Forms.TextBox();
            this.choose_song_textbox = new System.Windows.Forms.TextBox();
            this.add_song_button = new System.Windows.Forms.Button();
            this.bpm_label = new System.Windows.Forms.Label();
            this.bpm_input = new System.Windows.Forms.NumericUpDown();
            this.releasedate_picker = new System.Windows.Forms.DateTimePicker();
            this.releasedate_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bpm_input)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(16, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(30, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title:";
            // 
            // artist_label
            // 
            this.artist_label.AutoSize = true;
            this.artist_label.Location = new System.Drawing.Point(16, 49);
            this.artist_label.Name = "artist_label";
            this.artist_label.Size = new System.Drawing.Size(33, 13);
            this.artist_label.TabIndex = 1;
            this.artist_label.Text = "Artist:";
            // 
            // album_label
            // 
            this.album_label.AutoSize = true;
            this.album_label.Location = new System.Drawing.Point(16, 77);
            this.album_label.Name = "album_label";
            this.album_label.Size = new System.Drawing.Size(39, 13);
            this.album_label.TabIndex = 2;
            this.album_label.Text = "Album:";
            // 
            // song_file_label
            // 
            this.song_file_label.AutoSize = true;
            this.song_file_label.Location = new System.Drawing.Point(22, 200);
            this.song_file_label.Name = "song_file_label";
            this.song_file_label.Size = new System.Drawing.Size(54, 13);
            this.song_file_label.TabIndex = 5;
            this.song_file_label.Text = "Song File:";
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(53, 20);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(209, 20);
            this.title_textbox.TabIndex = 1;
            // 
            // artist_textbox
            // 
            this.artist_textbox.Location = new System.Drawing.Point(53, 49);
            this.artist_textbox.Name = "artist_textbox";
            this.artist_textbox.Size = new System.Drawing.Size(206, 20);
            this.artist_textbox.TabIndex = 2;
            // 
            // album_textbox
            // 
            this.album_textbox.Location = new System.Drawing.Point(53, 76);
            this.album_textbox.Name = "album_textbox";
            this.album_textbox.Size = new System.Drawing.Size(200, 20);
            this.album_textbox.TabIndex = 3;
            // 
            // choose_song_textbox
            // 
            this.choose_song_textbox.Location = new System.Drawing.Point(82, 197);
            this.choose_song_textbox.Name = "choose_song_textbox";
            this.choose_song_textbox.Size = new System.Drawing.Size(134, 20);
            this.choose_song_textbox.TabIndex = 11;
            this.choose_song_textbox.Text = "Click to choose song...";
            this.choose_song_textbox.TextChanged += new System.EventHandler(this.choose_song_textbox_TextChanged);
            // 
            // add_song_button
            // 
            this.add_song_button.Location = new System.Drawing.Point(32, 240);
            this.add_song_button.Name = "add_song_button";
            this.add_song_button.Size = new System.Drawing.Size(247, 23);
            this.add_song_button.TabIndex = 6;
            this.add_song_button.Text = "Add Song";
            this.add_song_button.UseVisualStyleBackColor = true;
            this.add_song_button.Click += new System.EventHandler(this.add_song_button_Click);
            // 
            // bpm_label
            // 
            this.bpm_label.AutoSize = true;
            this.bpm_label.Location = new System.Drawing.Point(16, 105);
            this.bpm_label.Name = "bpm_label";
            this.bpm_label.Size = new System.Drawing.Size(33, 13);
            this.bpm_label.TabIndex = 12;
            this.bpm_label.Text = "BPM:";
            // 
            // bpm_input
            // 
            this.bpm_input.Location = new System.Drawing.Point(53, 103);
            this.bpm_input.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.bpm_input.Name = "bpm_input";
            this.bpm_input.Size = new System.Drawing.Size(49, 20);
            this.bpm_input.TabIndex = 4;
            // 
            // releasedate_picker
            // 
            this.releasedate_picker.Location = new System.Drawing.Point(53, 151);
            this.releasedate_picker.Name = "releasedate_picker";
            this.releasedate_picker.Size = new System.Drawing.Size(200, 20);
            this.releasedate_picker.TabIndex = 5;
            this.releasedate_picker.Value = new System.DateTime(2014, 4, 20, 0, 0, 0, 0);
            // 
            // releasedate_label
            // 
            this.releasedate_label.AutoSize = true;
            this.releasedate_label.Location = new System.Drawing.Point(19, 135);
            this.releasedate_label.Name = "releasedate_label";
            this.releasedate_label.Size = new System.Drawing.Size(75, 13);
            this.releasedate_label.TabIndex = 14;
            this.releasedate_label.Text = "Release Date:";
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 303);
            this.Controls.Add(this.releasedate_label);
            this.Controls.Add(this.releasedate_picker);
            this.Controls.Add(this.bpm_input);
            this.Controls.Add(this.bpm_label);
            this.Controls.Add(this.add_song_button);
            this.Controls.Add(this.choose_song_textbox);
            this.Controls.Add(this.album_textbox);
            this.Controls.Add(this.artist_textbox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.song_file_label);
            this.Controls.Add(this.album_label);
            this.Controls.Add(this.artist_label);
            this.Controls.Add(this.title_label);
            this.Name = "AddSong";
            this.Text = "AddSong";
            ((System.ComponentModel.ISupportInitialize)(this.bpm_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label artist_label;
        private System.Windows.Forms.Label album_label;
        private System.Windows.Forms.Label song_file_label;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.TextBox artist_textbox;
        private System.Windows.Forms.TextBox album_textbox;
        private System.Windows.Forms.TextBox choose_song_textbox;
        private System.Windows.Forms.Button add_song_button;
        private System.Windows.Forms.Label bpm_label;
        private System.Windows.Forms.NumericUpDown bpm_input;
        private System.Windows.Forms.DateTimePicker releasedate_picker;
        private System.Windows.Forms.Label releasedate_label;
    }
}