using System;
using System.Collections.Generic;
using ZYPM.Entity;

namespace ZYPM.IDAL
{
    interface IACC01Repository
    {
        void Add(ACC01 a01);
        void Update(ACC01 a01);
        void Remove(ACC01 a01);
        ACC01 GetById(Guid a00);
        ACC01 GetByName(string A0101);
        ICollection<ACC01> GetByCategory(string A0104);
    }
}
