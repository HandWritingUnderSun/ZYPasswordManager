using NHibernate;
using NHibernate.Mapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZYPasswordManager
{
    class AccountRepository
    {
        public void Add(Account a01)
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

        //public IList GetEntityList()
        //{
        //    IList list;
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        using (ITransaction transaction = session.BeginTransaction())
        //        {
        //            list = session.;
        //        }
        //    }
        //    transaction.Commit();
        //    return list;
        //}
    }
}
