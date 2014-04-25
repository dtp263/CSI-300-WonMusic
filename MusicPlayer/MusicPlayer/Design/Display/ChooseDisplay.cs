using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Design.Display
{
    public partial class ChooseDisplay : Form
    {
        public ChooseDisplay()
        {
            InitializeComponent();
        }

        private void ChooseDisplay_Load(object sender, EventArgs e)
        {            
            ISession mySession = NHAccess.OpenSession();

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<Song>();
                IList<Song> list = criteria.List<Song>();
                foreach (Song item in list)
                {
                    Artist songArtist = mySession.Get<Artist>(item.ArtistID);
                    Album songAlbum = mySession.Get<Album>(item.AlbumID);
                    String[] row = new string[3];
                    row[0] = item.Title;
                    row[1] = songArtist.Name;
                    row[2] = songAlbum.Title;
                    ListViewItem newItm = new ListViewItem(row);
                    songs_list_view.Items.Add(newItm);
                }

                mySession.Transaction.Commit();
            }

            
        }
    }
}
