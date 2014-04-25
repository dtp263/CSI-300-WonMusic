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

namespace MusicPlayer.Design.Display
{
    public partial class SearchWnd : Form
    {
        //Dictionaries
        Dictionary<int, Song> CacheSong;
        Dictionary<int, Artist> CacheArtist;
        Dictionary<int, Album> CacheAlbum;

        public SearchWnd()
        {
            InitializeComponent();

			//Initialize dictionaries
			CacheSong = new Dictionary<int, Song>();
			CacheArtist = new Dictionary<int, MusicPlayer.Artist>();
			CacheAlbum = new Dictionary<int, MusicPlayer.Album>();

			ISession mySession = NHAccess.OpenSession();

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<Song>();
                IList<Song> list = criteria.List<Song>();
                foreach (Song item in list)
                {
                    try
                    {
                        CacheSong.Add(item.ID, item);
                    }
                    catch(ArgumentException e)
                    {

                    }

                    Artist songArtist = mySession.Get<Artist>(item.ArtistID);
                    try
                    {
                        CacheArtist.Add(songArtist.ID, songArtist);
                    }
                    catch(ArgumentException e)
                    {

                    }

                    Album songAlbum = mySession.Get<Album>(item.AlbumID);
                    try
                    {
                        CacheAlbum.Add(songAlbum.ID, songAlbum);
                    }
                    catch(ArgumentException e)
                    {

                    }
                }

                mySession.Transaction.Commit();
            }
        }

        private void SearchResultsFld_Add(Song newSong, Artist newSongArtist, Album newSongAlbum)
        {
            ListViewItem item = new ListViewItem(new[] { newSong.Title, newSongArtist.Name, newSongAlbum.Title });
            SearchResultsFld.Items.Add(item);
        }

        private void SearchBttn_Click(object sender, EventArgs e)
        {
            switch (SearchBttn.Text)
            {
                case "Search":
                    SearchBttn.Text = "Reset";
                    SearchResultsFld.Clear();
                    
                    //Search songs
                    foreach (KeyValuePair<int, Song> aSong in CacheSong)
                    {
						log.Text += aSong.Value.Title;
						if (aSong.Value.Title.Contains(SearchFld.Text))
						{
							log.Text += " MATCHES";
							SearchResultsFld_Add(aSong.Value, CacheArtist[aSong.Value.ArtistID], CacheAlbum[aSong.Value.AlbumID]);
						}
						else
						{
							log.Text += " DOES NOT MATCH";
						}
						log.Text += '\n';
                    }

                    //Search artists
                    foreach (KeyValuePair<int, Artist> aArtist in CacheArtist)
                    {
                        if (aArtist.Value.Name.Contains(SearchFld.Text))
                        {
                            //Artist matches, so find all songs by artist and add them
                            foreach (KeyValuePair<int, Song> aSong in CacheSong)
                            {
                                if (aSong.Value.ArtistID == aArtist.Value.ID)
                                {
                                    SearchResultsFld_Add(aSong.Value, aArtist.Value, CacheAlbum[aSong.Value.AlbumID]);
                                }
                            }
                        }
                    }

                    //Search albums
                    foreach (KeyValuePair<int, Album> aAlbum in CacheAlbum)
                    {
                        if (aAlbum.Value.Title.Contains(SearchFld.Text))
                        {
                            //Album matches, so find all songs in album and add them
                            foreach (KeyValuePair<int, Song> aSong in CacheSong)
                            {
                                if (aSong.Value.AlbumID == aAlbum.Value.ID)
                                {
                                    SearchResultsFld_Add(aSong.Value, CacheArtist[aSong.Value.ArtistID], aAlbum.Value);
                                }
                            }
                        }
                    }
                    break;
                case "Reset":
                    SearchBttn.Text = "Search";
                    SearchResultsFld.Clear();
                    break;
            }
        }
    }
}
