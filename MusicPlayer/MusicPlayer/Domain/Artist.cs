using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;


namespace MusicPlayer
{
    public class Artist
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }

        // This probably doesnt belong in this class but for simplicity's sake it is
        public virtual Artist getIfExistsOrCreate(string name, ISession mySession)
        {
            ICriteria criteria = mySession.CreateCriteria<Artist>();
            IList<Artist> Artists = criteria.List<Artist>();
            var artist = Artists.FirstOrDefault(c => c.Name == name);
            return artist == null ? new Artist { Name = name } : artist;
        }
    }
}
