using System;
using System.Collections.Generic;

namespace ConsoleEBookLoan
{
    public class EBook
    {
        private string Id;
        private string title;
        private string author;
        private string type;
        private bool isAvailable;
        
        public string ID { get => Id; set => Id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Type { get => type; set => type = value; }
        public bool IsAvailable { get  => isAvailable; set => isAvailable = value; }

        public EBook(string Id, string title, string author, string type)
        {
            ID = Id; 
            Title = title;
            Author = author;
            Type = type;
            isAvailable = true;
        }

        public void ShowEBookInformation()
        {
            Console.WriteLine("Kode     : " + ID);
            Console.WriteLine("Judul    : " + Title);
            Console.WriteLine("Penulis  : " + Author);
            Console.WriteLine("Tipe     : " + Type);
            Console.WriteLine("Tersedia : " + IsAvailable + "\n");
        }
    }
}