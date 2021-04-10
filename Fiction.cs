namespace ConsoleEBookLoan
{
    public abstract class Fiction: EBook
    {
        private string authorSignature;
        public string AuthorSignature { get => authorSignature; set => authorSignature = value; }
        public Fiction(string Id, string title, string author, string type, string authorSignature) : base(Id, title, author, type)
        {
            AuthorSignature = authorSignature;
        }
        // public override void ShowEBookInformation()
        // {
        //     throw new NotImplementedException();
        // }
    }
}