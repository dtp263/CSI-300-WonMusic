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
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        
        public ChooseDisplay()
        {
            InitializeComponent();
        }

        private void ChooseDisplay_Load(object sender, EventArgs e)
        {
            myConfiguration = new Configuration();
            myConfiguration.AddAssembly(Assembly.GetCallingAssembly());
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<Song>();
                IList<Song> list = criteria.List<Song>();
                foreach (Song item in list)
                {
                    String[] row = new string[3];
                    row[0] = item.Title;
                    row[1] = item.ArtistId.ToString();
                    row[2] = item.AlbumId.ToString();
                    ListViewItem newItm = new ListViewItem(row);
                    songs_list_view.Items.Add(newItm);
                }

                mySession.Transaction.Commit();
            }
        }
    }
}
