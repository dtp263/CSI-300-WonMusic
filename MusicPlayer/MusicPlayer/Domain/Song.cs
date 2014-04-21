using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public virtual int songId { get; set; }
        public virtual string title { get; set; }
        public virtual int lengthSeconds { get; set; }
        public virtual int artistId { get; set; }
        public virtual int albumId { get; set; }
        public virtual int formatId { get; set; }
        public virtual float priceUS { get; set; }
        public virtual float rating { get; set; }
        public virtual int bpm { get; set; }
        public virtual int bitRate { get; set; }
    }
}
