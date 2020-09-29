using System;
using System.Collections.Generic;

namespace FirstNhibernateDemo
{
    interface IAccountRepository
    {
        void Add(Account a01);
        void Update(Account a01);
        void Remove(Account a01);
        Account GetById(Guid a00);
        Account GetByName(string A0101);
        ICollection<Account> GetByCategory(string A0104);
    }
}
