using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Artist
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual int CountryId { get; set; }
    }
}
