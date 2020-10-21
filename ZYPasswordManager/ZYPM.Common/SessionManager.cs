using NHibernate;
using NHibernate.Cfg;

namespace ZYPasswordManager
{
    public class SessionManager
    {
        private static Configuration _cfg = new Configuration().AddAssembly("ZYPasswordManager");

        private static ISessionFactory _sessionFactory = _cfg.BuildSessionFactory();
        private SessionManager()
        {

        }

        public static ISession GetSession()
        {

            return _sessionFactory.OpenSession();
        }

        public static IStatelessSession GetStateLessSession()
        {
            return _sessionFactory.OpenStatelessSession();
        }
    }
}
