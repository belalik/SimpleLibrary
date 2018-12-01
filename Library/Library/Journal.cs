using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Journal : Item
    {
        // Property Publisher - συγκεκριμένο μόνο για αντικείμενα τύπου Journal. 
        public string Publisher { get; set; }

        // Με κάθε δημιουργία αντικειμένου Journal - καλώ τον base constructor (του Item)
        // δίνοντας το title σαν παράμετρο (αφού μόνο αυτήν την παράμετρο περιμένει ο 
        // constructor του Item).  Αφου κληθεί ο base constructor, προχωρώ στην πιο συγκεκριμένη
        // ενέργεια που αφορά το κάθε νέο Journal - συγκεκριμένα, δίνω τιμή στην Property Publisher. 
        public Journal(string title, string publisher)
            : base(title)
        {
            Publisher = publisher;
        }
        
    }
}
