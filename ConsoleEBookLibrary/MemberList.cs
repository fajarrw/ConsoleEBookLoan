using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleEBookLibrary.Model;

namespace ConsoleEBookLibrary
{
    class MemberList
    {
        public List<Member> list; 

        public MemberList(List<Member> memberList)
        {
            list = memberList;
        }

        public List<Member> GetList()
        {
            return list;
        }
    }
}
