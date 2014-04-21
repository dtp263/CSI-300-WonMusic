using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int LengthSeconds { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual int AlbumId { get; set; }
        public virtual int FormatId { get; set; }
        public virtual float PriceUS { get; set; }
        public virtual float Rating { get; set; }
        public virtual int BPM { get; set; }
        public virtual int BitRate { get; set; }
    }
}
