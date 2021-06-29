using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEBookLibrary.Model;

namespace ConsoleEBookLibrary.Page
{
    class StartPage
    {
        Stack stack;
        List<Member> memberList;
        public StartPage(Stack stack, List<Member> memberList)
        {
            this.stack = stack;
            this.memberList = memberList;
            Console.Clear();
            Console.WriteLine("|----------------------------------------------------------------|");
            Console.WriteLine("|  Selamat datang di aplikasi peminjaman ebook berbasis console  |");
            Console.WriteLine("|----------------------------------------------------------------|");
            Console.WriteLine("Sudah punya akun?");
            Console.WriteLine("1. Sudah");
            Console.WriteLine("2. Belum, saya ingin membuat akun");
            Console.WriteLine("Masukan: ");
            int selected = Convert.ToInt32(Console.ReadLine());
            switch(selected)
            {
                case 1:
                    stack.Push(new LoginPage(stack, memberList));
                    break;
                case 2:
                   stack.Push(new RegisterPage());
                    break;
                default:
                   break;

            }
        }
    }
}
