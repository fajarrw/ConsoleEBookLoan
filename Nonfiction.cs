using System;
namespace ConsoleEBookLoan
{
    public abstract class Nonfiction: EBook
    {
        private string authorSignature;
        public string AuthorSignature { get => authorSignature; set => authorSignature = value; }
        public Nonfiction(string Id, string title, string author, string type, string authorSignature) : base(Id, title, author, type)
        {
            AuthorSignature = authorSignature;
        }
        // public override void ShowEBookInformation()
        // {
        //     throw new NotImplementedException();
        // }
    }
}