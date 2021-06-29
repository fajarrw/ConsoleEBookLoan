using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEBookLibrary.Model
{
    class Member
    {
        public string fullName;
        public string userName;
        public string email;
        public string password;

        public Member(string fullName, string userName, string email, string password)
        {
            this.fullName = fullName;
            this.userName = userName;
            this.email = email;
            this.password = password;
        }
    }
}
