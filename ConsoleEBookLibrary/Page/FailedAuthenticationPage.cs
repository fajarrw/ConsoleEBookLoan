using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEBookLibrary.Model;

namespace ConsoleEBookLibrary.Page
{
    class FailedAuthenticationPage
    {
        Stack stack;
        List<Member> memberList;
        public FailedAuthenticationPage(Stack stack, List<Member> memberList)
        {
            this.stack = stack;
            this.memberList = memberList;
            Console.Clear();
            Console.WriteLine("Otentikasi tidak berhasil");
            Console.WriteLine("Ulangi lagi?");
            Console.WriteLine("1. Ya");
            Console.WriteLine("2. Tidak");
            Console.WriteLine("Masukan: ");
            int selected = Convert.ToInt32(Console.ReadLine());

            switch(selected)
            {
                case 1:
                    stack.Pop();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
