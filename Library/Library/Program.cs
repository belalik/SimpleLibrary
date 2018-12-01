using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our library");

            Library aegeanLibrary = new Library();
            
            // Ας φτάξουμε μερικούς χρήστες

            User user1 = new User("Thomas", "thomas@something.com");
            User user2 = new User("Babis", "babis@aegean.gr");
            User user3 = new User("Maria", "maria@something.com");
            User user4 = new User("Mitsos", "mitsos@something.com");

            // Ας προσθέσουμε αυτούς τους χρήστες στην βιβλιοθήκη μέσω της αντίστοιχης μεθόδου. 

            aegeanLibrary.AddUser(user1);
            aegeanLibrary.AddUser(user2);
            aegeanLibrary.AddUser(user3);
            aegeanLibrary.AddUser(user4);


            // Ας φτιάξουμε μερικά Items (Books)

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("War and Peace", "Leo Tolstoy");
            Book book3 = new Book("Tale of two Cities", "Charles Dickens");
            Book book4 = new Book("The Gambler", "Fyodor Dostoevsky");
            Book book5 = new Book("Crime and Punishment", "Fyodor Dostoevsky");
            Book book6 = new Book("Don Quixote", "Miguel de Cervantes");
            Book book7 = new Book("C# for Programmers", "Deitel & Deitel");
            Book book8 = new Book("The Art of Computer Programming", "Donald Knuth");

            aegeanLibrary.AddItem(book1);
            aegeanLibrary.AddItem(book2);
            aegeanLibrary.AddItem(book3);
            aegeanLibrary.AddItem(book4);
            aegeanLibrary.AddItem(book5);
            aegeanLibrary.AddItem(book6);
            aegeanLibrary.AddItem(book7);
            aegeanLibrary.AddItem(book8);


            // Let's create some Items (Videos)

            Video video1 = new Video("Queen - Live 8", 24);
            Video video2 = new Video("Pink Floyd: Live at Pompeii", 64);
            Video video3 = new Video("Johnny Cash Live at San Quentin", 60);
            Video video4 = new Video("Aretha Live at Fillmore West", 90);
            Video video5 = new Video("The Godfather", 170);
            Video video6 = new Video("American Beauty", 122);

            aegeanLibrary.AddItem(video1);
            aegeanLibrary.AddItem(video2);
            aegeanLibrary.AddItem(video3);
            aegeanLibrary.AddItem(video4);
            aegeanLibrary.AddItem(video5);
            aegeanLibrary.AddItem(video6);

            // Let's create some Journals

            Journal journal1 = new Journal("Cyclades Journal", "Serious Mag");
            Journal journal2 = new Journal("Review of Psychology", "Harvard University");
            Journal journal3 = new Journal("Review of Sociology", "Harvard University");
            Journal journal4 = new Journal("Trends in Design", "DPSD");
            Journal journal5 = new Journal("Cultural Heritage", "DPSD");
            Journal journal6 = new Journal("Interactive Systems", "DPSD");

            aegeanLibrary.AddItem(journal1);
            aegeanLibrary.AddItem(journal2);
            aegeanLibrary.AddItem(journal3);
            aegeanLibrary.AddItem(journal4);
            aegeanLibrary.AddItem(journal5);
            aegeanLibrary.AddItem(journal6);




        }

    }
}
