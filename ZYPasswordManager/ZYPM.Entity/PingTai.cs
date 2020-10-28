namespace ZYPM.Entity
{
    public class PingTai
    {
        private string _dmcod;
        private string _dmcpt;

        public PingTai()
        { }

        public PingTai(string dmcod, string dmcpt)
        {
            _dmcod = dmcod;
            _dmcpt = dmcpt;
        }

        public virtual string Dmcod { get => _dmcod; set => _dmcod = value; }
        public virtual string Dmcpt { get => _dmcpt; set => _dmcpt = value; }
    }
}
