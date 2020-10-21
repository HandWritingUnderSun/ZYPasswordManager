using NHibernate;
using System;
using System.Collections.Generic;

namespace ZYPasswordManager
{
    public class PingTaiRepository
    {
        /// <summary>
        /// 根据获取人员信息
        /// </summary>
        /// <param name="A00"></param>
        /// <returns></returns>
        public PingTai GetPingTaiInfo(Guid rid)
        {
            using (ISession session = SessionManager.GetSession())
            {
                    return session.Get<PingTai>(rid);
            }
        }


        public IList<PingTai> GetPingTaiInfos()
        {
            using (ISession session = SessionManager.GetSession())
            {
                var PingTais = session
                    .CreateCriteria(typeof(PingTai))
                    .List<PingTai>();
                return PingTais;
            }
        }


        public void Add(PingTai pingTai)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(pingTai);
                    transaction.Commit();
                }
            }
        }
    }
}
