using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace MusicPlayer.Design.EditSongs
{
    public partial class AddSong : Form
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public AddSong()
        {
            InitializeComponent();
        }

        private void choose_song_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Audio files | *.wav;*.mp3;";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    choose_song_textbox.Text = openFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_song_button_Click(object sender, EventArgs e)
        {
            myConfiguration = new Configuration();
            myConfiguration.AddAssembly(Assembly.GetCallingAssembly());
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            using (mySession.BeginTransaction())
            {
                var format_id = 1; // This is the id for an unknown format
                var length_seconds = 100;
                var bit_rate = 320;


                Artist newSongArtist = new Artist();
                newSongArtist = newSongArtist.getIfExistsOrCreate(artist_textbox.Text, mySession);
                mySession.SaveOrUpdate(newSongArtist);


                Album newAlbum = new Album();
                newAlbum = newAlbum.getIfExistsOrCreate(album_textbox.Text, newSongArtist.ID, releasedate_picker.Value, mySession);
                mySession.SaveOrUpdate(newAlbum);


                // TODO Create and save Album object
                Song newSong = new Song();
                newSong = newSong.getIfExistsOrCreate(title_textbox.Text, length_seconds, newSongArtist.ID, newAlbum.ID, format_id,(int)bpm_input.Value, bit_rate, mySession);
                mySession.SaveOrUpdate(newSong);
                
                mySession.Transaction.Commit();
            }
            this.Close();
 
            

        }
    }
}