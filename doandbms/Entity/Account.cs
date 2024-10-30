using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doandbms.Entity
{
    public class Account
    {
        private String _username;
        private String _password;
        private String _email;
        private String _id;
        private String _role;

        public Account() { }
        public Account(string username, string password, string email, string id, string role)
        {
            _username = username;
            _password = password;
            _email = email;
            _id = id;
            _role = role;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }
        public string Id { get => _id; set => _id = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
