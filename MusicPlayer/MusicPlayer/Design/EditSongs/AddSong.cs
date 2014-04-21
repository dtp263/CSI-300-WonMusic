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
                var artists = mySession.QueryOver<Artist>().Where(x => x.Name == artist_textbox.Text);


                // TODO this should not be hardcoded
                Artist newSongArtist = new Artist { Name = artist_textbox.Text, CountryId = 1 };

                try
                {
                    mySession.SaveOrUpdate(newSongArtist);
                }
                catch (Exception)
                {
                    
                    throw;
                }

                
                // TODO Create and save Album object

                Song newSong = new Song {   Title = title_textbox.Text, 
                                            PriceUS = (float)price_input.Value,
                                            Rating = (float)rating_input.Value,
                                            ArtistId = newSongArtist.ID,
                                            };
                mySession.SaveOrUpdate(newSong);

                mySession.Transaction.Commit();
            }
            this.Close();
 
            

        }
    }
}