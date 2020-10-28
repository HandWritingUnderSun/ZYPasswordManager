using System;

namespace ZYPM.Entity
{
    public class ACC01
    {
        private Guid _rid;
        private string _pingTai;
        private string _pingTai_BuChong;
        private string _logonName;
        private string _password;
        private string _telephone;
        private string _email;
        private string _url;
        private Int32 _isLock;

        public ACC01()
        { }

        public ACC01(Guid rid, string pingTai, string pingTai_BuChong, string logonName, string password, string telephone, string email, string url, int isLock)
        {
            _rid = rid;
            _pingTai = pingTai;
            _pingTai_BuChong = pingTai_BuChong;
            _logonName = logonName;
            _password = password;
            _telephone = telephone;
            _email = email;
            _url = url;
            _isLock = isLock;
        }

        public virtual Guid Rid { get => _rid; set => _rid = value; }
        public virtual string PingTai { get => _pingTai; set => _pingTai = value; }
        public virtual string PingTai_BuChong { get => _pingTai_BuChong; set => _pingTai_BuChong = value; }
        public virtual string LogonName { get => _logonName; set => _logonName = value; }
        public virtual string Password { get => _password; set => _password = value; }
        public virtual string Telephone { get => _telephone; set => _telephone = value; }
        public virtual string Email { get => _email; set => _email = value; }
        public virtual string Url { get => _url; set => _url = value; }
        public virtual int IsLock { get => _isLock; set => _isLock = value; }
    }
}
