using MusicPlayer.Design.Display;
using MusicPlayer.Design.EditSongs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
   public partial class Player : Form
   {
      public Player()
      {
         InitializeComponent();
      }

      private void add_a_song_Click(object sender, EventArgs e)
      {
          AddSong form = new AddSong();
          form.Show();
      }

      private void display_button_Click(object sender, EventArgs e)
      {
          ChooseDisplay displays = new ChooseDisplay();
          displays.Show();
      }

      private void button4_Click(object sender, EventArgs e)
      {
          SearchWnd search = new SearchWnd();
          search.Show();
      }
   }
}
