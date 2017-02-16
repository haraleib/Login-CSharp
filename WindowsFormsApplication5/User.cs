using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class User
    {
        private string unused;
        private string username;
        private int password;
        public string name
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public int pwd {
            get { return this.password; }
            set { this.password = value; }
        }

        public User() { }
        public User(string n, int p) {
            this.name = n;
            this.pwd = p;
        }

    }
}
