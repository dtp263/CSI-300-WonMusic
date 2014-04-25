using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace MusicPlayer
{
    class NHAccess
    {
        private static ISessionFactory SessionFactory;
        
		private static void InitializeFactory()
        {
			var configuration = new Configuration();
			configuration.Configure();
			SessionFactory = configuration.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
			if (SessionFactory == null) InitializeFactory();
			return SessionFactory.OpenSession();
        }
    }
}
