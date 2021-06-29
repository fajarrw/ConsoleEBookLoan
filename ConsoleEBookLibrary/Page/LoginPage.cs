using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEBookLibrary.Model;

namespace ConsoleEBookLibrary.Page
{
    class LoginPage
    {
        Stack stack;
        List<Member> memberList;
        //MemberList myMemberList;
        public LoginPage(Stack stack, List<Member> memberList)
        {
            this.stack = stack;
            this.memberList = memberList;
            //MemberList myMemberList = new MemberList(memberList);
            Console.Clear();
            Console.WriteLine("Masukkan data berikut!");
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("{0} - {1}",username, password);
            bool isValid = Authenticate(username, password);
            if(isValid)
            {
                //ke MainPage
            }
            else
            {
                stack.Push(new FailedAuthenticationPage(stack, memberList));
            }
        }

        private bool Authenticate(string username, string password)
        {
            foreach(Member member in memberList)
            {
                if(member.userName == username)
                {
                    if(member.password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
