using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;


namespace MusicPlayer
{
    public class Album
    {
        public virtual int ID { get; set; }
        public virtual int ArtistID { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime ReleaseDate { get; set; }

        // This probably doesnt belong in this class but for simplicity's sake it is
        public virtual Album getIfExistsOrCreate(string title, int artistId, DateTime releaseDate, ISession mySession)
        {
            ICriteria criteria = mySession.CreateCriteria<Album>();
            IList<Album> Albums = criteria.List<Album>();
            var album = Albums.FirstOrDefault(c => c.Title == title && c.ArtistID == artistId && c.ReleaseDate == releaseDate);
            return album == null ? new Album { Title = title, ArtistID = artistId, ReleaseDate = releaseDate } : album;
        }

    }
}
