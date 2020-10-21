using System;
using System.Collections.Generic;

namespace ZYPasswordManager
{
    public class A01
    {
        private Guid _a00;
        private string _a0101;
        private string _a0104;

        public A01()
        { }

        public A01(Guid a00, string a0101, string a0104)
        {
            _a00 = a00;
            _a0101 = a0101;
            _a0104 = a0104;
        }

        public virtual Guid A00 { get => _a00; set => _a00 = value; }
        public virtual string A0101 { get => _a0101; set => _a0101 = value; }
        public virtual string A0104 { get => _a0104; set => _a0104 = value; }

        public override bool Equals(object obj)
        {
            return obj is A01 a &&
                   _a00.Equals(a._a00) &&
                   _a0101 == a._a0101 &&
                   _a0104 == a._a0104;
        }

        public override int GetHashCode()
        {
            int hashCode = -2038315896;
            hashCode = hashCode * -1521134295 + _a00.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_a0101);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_a0104);
            return hashCode;
        }
    }
}
