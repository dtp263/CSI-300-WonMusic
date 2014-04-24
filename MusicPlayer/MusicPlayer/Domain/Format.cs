using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace MusicPlayer
{
    public class Format
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Extension { get; set; }

        public virtual Format getIfExistsOrCreate(string name, string extension, ISession mySession)
        {
            ICriteria criteria = mySession.CreateCriteria<Format>();
            IList<Format> Formats = criteria.List<Format>();
            var format = Formats.FirstOrDefault(c => c.Name == name && c.Extension == extension);
            return format == null ? new Format { Name = name, Extension=extension } : format;
        }
    }
}
