using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections;
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

            this.songs_list_view.ListViewItemSorter = new ListViewTitleComparer();
            
        }

        private void title_button_Click(object sender, EventArgs e)
        {
            this.songs_list_view.ListViewItemSorter = new ListViewTitleComparer();
        }

        private void Artist_Click(object sender, EventArgs e)
        {
            this.songs_list_view.ListViewItemSorter = new ListViewArtistComparer();
        }

        private void album_button_Click(object sender, EventArgs e)
        {
            this.songs_list_view.ListViewItemSorter = new ListViewAlbumComparer();
        }


    }

    class ListViewTitleComparer : IComparer
    {
        public ListViewTitleComparer()
        {

        }

        // This function actually does the comparison     
        public int Compare(object x, object y)
        {
            ListViewItem FirstItem = (ListViewItem)x;
            ListViewItem SecondItem = (ListViewItem)y;

            return String.Compare(FirstItem.SubItems[0].Text + FirstItem.SubItems[1].Text + FirstItem.SubItems[2].Text,
                                  SecondItem.SubItems[0].Text + SecondItem.SubItems[1].Text + SecondItem.SubItems[2].Text);
        }
    }

    class ListViewArtistComparer : IComparer
    {
        public ListViewArtistComparer()
        {

        }

        // This function actually does the comparison     
        public int Compare(object x, object y)
        {
            ListViewItem FirstItem = (ListViewItem)x;
            ListViewItem SecondItem = (ListViewItem)y;

            return String.Compare(FirstItem.SubItems[1].Text + FirstItem.SubItems[0].Text + FirstItem.SubItems[2].Text,
                                  SecondItem.SubItems[1].Text + SecondItem.SubItems[0].Text + SecondItem.SubItems[2].Text);
        }
    }

    class ListViewAlbumComparer : IComparer
    {
        public ListViewAlbumComparer()
        {

        }

        // This function actually does the comparison     
        public int Compare(object x, object y)
        {
            ListViewItem FirstItem = (ListViewItem)x;
            ListViewItem SecondItem = (ListViewItem)y;

            return String.Compare(FirstItem.SubItems[2].Text + FirstItem.SubItems[1].Text + FirstItem.SubItems[0].Text,
                                  SecondItem.SubItems[2].Text + SecondItem.SubItems[1].Text + SecondItem.SubItems[0].Text);
        }
    }
}
