using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace ConsoleEBookLoan
{
    public class Loan
    {
        private string userName;
        private string Id;
        public string UserName { get => userName; set => userName = value; }
        public string ID { get => Id; set => Id = value; }

        public Loan(string userName, string Id)
        {
            UserName = userName;
            ID = Id;   
        }

        public void ReserveEBook(string toBeReserved, string userName, List<EBook> eBooks)
        {
            foreach(EBook eBook in eBooks)
            {
                if(toBeReserved == eBook.ID)
                {
                    if(eBook.IsAvailable)
                    {
                        // Loan newLoan = new Loan(userName, eBook.ID);
                        // loan.Add(newLoan);
                        eBook.IsAvailable = false;
                    }
                    else
                    {
                        Console.WriteLine("eBook tidak tersedia.");
                    }
                }
            }
        }    
    }
}