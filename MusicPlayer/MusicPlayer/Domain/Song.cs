using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace MusicPlayer
{
    public class Song
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int LengthSeconds { get; set; }
        public virtual int ArtistID { get; set; }
        public virtual int AlbumID { get; set; }
        public virtual int FormatID { get; set; }
        public virtual float PriceUS { get; set; }
        public virtual int BPM { get; set; }
        public virtual int BitRate { get; set; }

        public virtual Song getIfExistsOrCreate(string title, int lengthSeconds, int artistId, int albumId, int formatId, int bpm, int bitRate, ISession mySession)
        {
            ICriteria criteria = mySession.CreateCriteria<Song>();
            IList<Song> Songs = criteria.List<Song>();
            var song = Songs.FirstOrDefault(c => c.Title==title && c.LengthSeconds==lengthSeconds && c.ArtistID==artistId && c.AlbumID==albumId && c.BPM==bpm);
            return song == null ? new Song { Title=title, LengthSeconds=lengthSeconds, ArtistID=artistId, AlbumID=albumId, FormatID=formatId, BPM=bpm, BitRate=bitRate} : song;
        }
    }
}
