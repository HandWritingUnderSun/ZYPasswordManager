using System;

namespace ZYPasswordManager
{
    public class JBC01
    {
        private string _dmcod;
        private string _dmcpt;

        public JBC01()
        { }
        public JBC01(string dmcod, string dmcpt)
        {
            _dmcod = dmcod;
            _dmcpt = dmcpt;
        }

        public virtual string Dmcod { get => _dmcod; set => _dmcod = value; }
        public virtual string Dmcpt { get => _dmcpt; set => _dmcpt = value; }
    }
}
