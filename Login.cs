using System;
using System.Collections.Generic;

namespace ConsoleEBookLoan
{
    public class Login
    {
        private string userName;
        private string password;
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public bool Authenticate(string userName, string password, List<Member> members)
        {
            foreach(Member member in members)
            {
                if(userName == member.UserName && password == member.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}