using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book : Item
    {
        // Property Author - συγκεκριμένο μόνο για αντικείμενα τύπου Book. 
        public string Author { get; set; }

        // Με κάθε δημιουργία αντικειμένου Book - καλώ τον base constructor (του Item)
        // δίνοντας το title σαν παράμετρο (αφού μόνο αυτήν την παράμετρο περιμένει ο 
        // constructor του Item).  Αφου κληθεί ο base constructor, προχωρώ στην πιο συγκεκριμένη
        // ενέργεια που αφορά το κάθε νέο Book - συγκεκριμένα, δίνω τιμή στην Property Author. 
        public Book(string title, string author)
            : base(title)
        {

            Author = author;
        }
        
    }
}
