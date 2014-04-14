using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Domain
{
    class Song
    {
        int songId { get; set; }
        string title { get; set; }
        int lengthSeconds { get; set; }
        int artistId { get; set; }
        int albumId { get; set; }
        int formatId { get; set; }
        int priceUS { get; set; }
        int review { get; set; }
        int bpm { get; set; }
        int bitRate { get; set; }
    }
}
