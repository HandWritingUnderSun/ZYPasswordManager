using System;
using NHibernate;
using NHibernate.Cfg;

namespace ZYPasswordManager
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            try
            {
                return SessionFactory.OpenSession();
            }
            catch (Exception ex)
            {
                //LogHelper.GetInstance().WriteMessage("打开数据库失败，错误：" + ex.ToString());
                return null;
            }
        }
    }
}
