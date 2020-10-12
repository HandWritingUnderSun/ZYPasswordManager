using NHibernate;
using System;

namespace ZYPasswordManager
{
    public class A01Repository
    {
        public A01 GetA01Info(Guid A00)
        {
            using (ISession session = SessionManager.GetSession())
            {
                    return session.Get<A01>(A00);
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
