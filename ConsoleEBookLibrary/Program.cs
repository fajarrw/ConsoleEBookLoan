using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleEBookLibrary.Page;
using ConsoleEBookLibrary.Model;

namespace ConsoleEBookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> memberList = new List<Member>();
            MemberList myMemberList = new MemberList(memberList);
            myMemberList.list.Add(new Member("Fajar Rizky Widodo", "fajarrw", "fajar.r.w@mail.ugm.ac.id", "FAJARrizky"));

            Stack stack = new Stack();
            stack.Push(new StartPage(stack, memberList));

            Console.ReadLine();
        }
    }
}
