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
	public partial class EditSong : Form
	{
		public EditSong()
		{
			InitializeComponent();
		}

		private void EditBttn_Click(object sender, EventArgs e)
		{
			ISession mySession = NHAccess.OpenSession();

			using (mySession.BeginTransaction())
			{
				Song thisSong = mySession.Get<Song>(1);
				thisSong.Title = TitleFld.Text;
				mySession.Update(thisSong);
				mySession.Transaction.Commit();
			}
			this.Close();
		}
	}
}
