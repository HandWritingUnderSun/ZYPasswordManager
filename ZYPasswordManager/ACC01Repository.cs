﻿using NHibernate;
using System;
using System.Collections.Generic;

namespace ZYPasswordManager
{
    public class ACC01Repository
    {
        /// <summary>
        /// 根据A00获取人员信息
        /// </summary>
        /// <param name="A00"></param>
        /// <returns></returns>
        public ACC01 GetACC01Info(Guid Rid)
        {
            using (ISession session = SessionManager.GetSession())
            {
                return session.Get<ACC01>(Rid);
            }
        }


        public IList<ACC01> GetACC01Infos()
        {
            using (ISession session = SessionManager.GetSession())
            {
                var ACC01s = session
                    .CreateCriteria(typeof(ACC01))
                    .List<ACC01>();
                return ACC01s;
            }
        }


        public void Add(ACC01 ACC01)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(ACC01);
                    transaction.Commit();
                }
            }
        }
    }
}
