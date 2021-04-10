
using System;
using System.Collections.Generic;

namespace ConsoleEBookLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            members.Add(new Member("Fajar Rizky Widodo", "fajarrw", "fajar.r.w@mail.ugm.ac.id", "FAJARrizky"));
            members.Add(new Member("Hervi Nur Rahmadien", "hervinr", "hervi.n.r@mail.ugm.ac.id", "HERVInur"));
            members.Add(new Member("Ardianto Ramadan", "ardiantor", "ardianto.r@mail.ugm.ac.id", "ARDIANTOramadan"));
            
            Member member4 = new Member("andip", "andi.p@mail.ugm.ac.id", "ANDIpradana");
            member4.FullName = "Andi Pradana";

            members.Ad(new Member(member4));
            
            List<EBook> eBooks = new List<EBook>();
            eBooks.Add(new EBook("N001", "Data Science from Scratch", "Joel Grus", "Nonfiksi"));
            eBooks.Add(new EBook("N002", "Learning SQL", "Alan Beaulieu", "Nonfiksi"));
            eBooks.Add(new EBook("F001", "Animal Farm", "George Orwell", "Fiksi"));

            List<Loan> loans = new List<Loan>();
            
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| Selamat datang di aplikasi peminjaman ebook berbasis console |");
            Console.WriteLine("| Developed by Fajar Rizky Widodo                              |");
            Console.WriteLine("----------------------------------------------------------------");
            
            Console.WriteLine("Apakah Anda sudah memiliki akun? (TRUE/FALSE)");
            bool hasAccount = Convert.ToBoolean(Console.ReadLine());

            if(hasAccount)
            {
                Console.WriteLine("Silahkan masukkan username Anda");
                string userName = Console.ReadLine();
                Console.WriteLine("Silahkan masukkan password Anda");
                string password = Console.ReadLine();
                
                Login login = new Login(userName, password);
                
                bool validAuthentication = login.Authenticate(userName, password, members);
                if(validAuthentication)
                {   
                    Console.WriteLine("Ketik 1 untuk menampilkan eBook yang tersedia saja");
                    Console.WriteLine("Ketik 2 untuk menampilkan semua eBook nonfiksi");
                    Console.WriteLine("Ketik 3 untuk menampilkan semua eBook fiksi");
                    Console.WriteLine("Ketik 4 untuk menampilkan semua eBook");
                    Console.WriteLine("Ketik 12 untuk menampilkan eBook nonfiksi yang tersedia");
                    Console.WriteLine("Ketik 13 untuk menampilkan eBook fiksi yang tersedia");

                    int filter = Convert.ToInt32(Console.ReadLine());
                    switch(filter)
                    {
                        case 1:
                            foreach(EBook eBook in eBooks)
                            {
                                if(eBook.IsAvailable == true)
                                {
                                    eBook.ShowEBookInformation();
                                }
                            }
                            break;     
                        case 2:
                            foreach(EBook eBook in eBooks)
                            {
                                if(eBook.Type == "Nonfiksi")
                                {
                                    eBook.ShowEBookInformation();
                                }
                            }
                            break;                                 
                        case 3:
                            foreach(EBook eBook in eBooks)
                            {
                                if(eBook.Type == "Fiksi")
                                {
                                    eBook.ShowEBookInformation();
                                }
                            }
                            break;
                        case 4:
                            foreach(EBook eBook in eBooks)
                            {
                                eBook.ShowEBookInformation();                               
                            }
                            break;                 
                        case 12:
                            foreach(EBook eBook in eBooks)
                            {
                                if(eBook.Type == "Nonfiksi" && eBook.IsAvailable == true)
                                {
                                    eBook.ShowEBookInformation();
                                }
                            }
                            break;                 
                        case 13:
                            foreach(EBook eBook in eBooks)
                            {
                                if(eBook.Type == "Fiksi" && eBook.IsAvailable == true)
                                {
                                    eBook.ShowEBookInformation();
                                }
                            }
                            break;                 
                        default:
                            Console.WriteLine("Unexpected input ({0})", filter);
                            break;
                    }
                    Console.WriteLine("Masukkan kode eBook yang ingin Anda pinjam");
                    string toBeReserved = Console.ReadLine();

                    loans.Add(new Loan (userName, toBeReserved));
                    // loans[0].ReserveEBook(toBeReserved, userName, eBooks);
                }
                else
                {
                    Console.WriteLine("Authentication Failed");
                }
            }
            else
            {
                Console.WriteLine("Untuk bisa menggunakan aplikasi ini, Anda perlu memiliki akun");
                
                Console.WriteLine("Silahkan masukkan nama lengkap Anda");
                string fullName = Console.ReadLine();
                Console.WriteLine("Silahkan masukkan username untuk akun Anda");
                string userName = Console.ReadLine();                
                Console.WriteLine("Silahkan masukkan alamat email Anda");
                string emailAddress = Console.ReadLine();
                Console.WriteLine("Silahkan masukkan password Anda");
                string password = Console.ReadLine();

                Member newMember = new Member(fullName, userName, emailAddress, password);
                members.Add(newMember);
            }
        }
    }
}