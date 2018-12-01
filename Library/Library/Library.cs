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

        public List<Item> Items { get; set; }
        
        public List<Loan> Loans { get; set; }


    }
}
