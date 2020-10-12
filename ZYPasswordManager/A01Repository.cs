using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace ZYPasswordManager
{
    public class A01Repository
    {
        public List<A01> GetA01InfoList()
        {
            using (ISession session = SessionManager.GetSession())
            {
                ICriteria criteria = session.CreateCriteria<A01>();
                List<A01> lsAtt = criteria.List<A01>().ToList();
                return lsAtt;
            }
        }

        public void Add(A01 a01)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(a01);
                    transaction.Commit();
                }
            }
        }
    }
}
