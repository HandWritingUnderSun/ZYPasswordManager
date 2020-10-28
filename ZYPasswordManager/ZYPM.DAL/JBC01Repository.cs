using NHibernate;
using System;
using System.Collections.Generic;
using ZYPM.Entity;
using ZYPM.Common;

namespace ZYPM.DAL
{
    public class JBC01Repository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public JBC01 GetJBC01Info(Guid rid)
        {
            using (ISession session = SessionManager.GetSession())
            {
                    return session.Get<JBC01>(rid);
            }
        }


        public IList<JBC01> GetJBC01Infos()
        {
            using (ISession session = SessionManager.GetSession())
            {
                var JBC01s = session
                    .CreateCriteria(typeof(JBC01))
                    .List<JBC01>();
                return JBC01s;
            }
        }
    }
}
