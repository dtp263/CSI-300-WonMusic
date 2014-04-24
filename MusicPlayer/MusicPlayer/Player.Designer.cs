namespace MusicPlayer
{
   partial class Player
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
            this.display_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.add_a_song = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_button
            // 
            this.display_button.Location = new System.Drawing.Point(83, 78);
            this.display_button.Name = "display_button";
            this.display_button.Size = new System.Drawing.Size(145, 23);
            this.display_button.TabIndex = 0;
            this.display_button.Text = "Display Music";
            this.display_button.UseVisualStyleBackColor = true;
            this.display_button.Click += new System.EventHandler(this.display_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play a Song";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Playlists";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(68, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // add_a_song
            // 
            this.add_a_song.Location = new System.Drawing.Point(327, 199);
            this.add_a_song.Name = "add_a_song";
            this.add_a_song.Size = new System.Drawing.Size(269, 23);
            this.add_a_song.TabIndex = 4;
            this.add_a_song.Text = "Add A Song";
            this.add_a_song.UseVisualStyleBackColor = true;
            this.add_a_song.Click += new System.EventHandler(this.add_a_song_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.add_a_song);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.display_button);
            this.Name = "Player";
            this.Text = "MusicPlayer";
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button display_button;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button add_a_song;
   }
}

