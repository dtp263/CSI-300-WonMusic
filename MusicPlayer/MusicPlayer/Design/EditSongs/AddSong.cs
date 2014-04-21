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
            try
            {
                myConfiguration.Configure();
            }
            catch (Exception)
            {
                
                throw;
            }
            try
            {
                mySessionFactory = myConfiguration.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            mySession = mySessionFactory.OpenSession();

            using (mySession.BeginTransaction())
            {
                Artist newSongArtist = new Artist { Name = artist_textbox.Text };
                try
                {
                    mySession.SaveOrUpdate(newSongArtist);
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }

                // TODO Create and save Album object

                Song newSong = new Song {   title = title_textbox.Text, 
                                            priceUS = (float)price_input.Value,
                                            rating = (float)rating_input.Value,
                                            artistId = newSongArtist.ID,
                                            };
                mySession.SaveOrUpdate(newSong);

                mySession.Transaction.Commit();
            }
 


        }
    }
}