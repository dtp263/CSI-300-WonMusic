using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class City
    {
        public virtual int ID { get; set; }
        public virtual string name { get; set; }
        public virtual int postalCode { get; set; }
    }
}
