using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEBookLibrary.Model
{
    class EBook
    {
        public int id;
        public string title;
        public string author;
        public string category;
        public EBook(int id, string title, string author, string category)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.category = category;
        }
    }
}
