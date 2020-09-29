using System;

namespace FirstNhibernateDemo
{
    public class Account
    {
        private Guid _id;
        private string _name;
        private string _password;
        private string _url;

        public Account()
        { }

        public Account(Guid id, string name, string password, string url)
        {
            _id = id;
            _name = name;
            _password = password;
            _url = url;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string Url { get => _url; set => _url = value; }
    }
}
