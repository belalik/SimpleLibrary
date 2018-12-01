using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /*
     * Ίσως η πιο βασική κλάση της άσκησης, αφού εδώ υλοποιείται το μεγαλύτερο μέρος
     * της 'λογικής'.
     */
    class Library
    {

        //public List<Book> Books { get; set; }

        //public List<Video> Videos { get; set; }

        //public List<Journal> Journals { get; set; }

        public List<User> Users { get; set; }
        public List<Item> Items { get; set; }
        
        public List<Loan> Loans { get; set; }

        /*
         *  Ακολουθεί ο κώδικας του Constructor του Library - με άλλα λόγια, ο κώδικας που θα τρέξει μόλις
         *  δημιουργήσω ένα αντικείμενο της κλάσης Library. 
         */
        public Library()
        {
            // Αρχικοποιώ την λίστα που κρατάει όλα τα Items. 
            Items = new List<Item>();
        }


        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
