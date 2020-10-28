using NHibernate;
using System;
using System.Collections.Generic;
using ZYPM.Entity;
using ZYPM.IDAL;
using ZYPM.Common;

namespace ZYPM.DAL
{
    public class A01Repository
    {
        /// <summary>
        /// 根据A00获取人员信息
        /// </summary>
        /// <param name="A00"></param>
        /// <returns></returns>
        public A01 GetA01Info(Guid A00)
        {
            using (ISession session = SessionManager.GetSession())
            {
                    return session.Get<A01>(A00);
            }
        }


        public IList<A01> GetA01Infos()
        {
            using (ISession session = SessionManager.GetSession())
            {
                var A01s = session
                    .CreateCriteria(typeof(A01))
                    .List<A01>();
                return A01s;
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
