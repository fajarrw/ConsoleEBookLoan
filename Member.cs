

using System;
using System.Collections.Generic;

namespace ConsoleEBookLoan
{
    public class Member
    {
        private string fullName;
        private string userName;
        private string password;
        private string emailAddress;

        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }

        public Member(string fullName, string userName, string emailAddress, string password)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            EmailAddress = emailAddress;
        }

        public Member(string userName, string emailAddress, string password)
        {
            UserName = userName;
            Password = password;
            EmailAddress = emailAddress;
        }

        public void ShowMemberInformation()
        {
            Console.WriteLine("{0} {1} {2} {3}", FullName, UserName, Password, EmailAddress);
        }
    }
}