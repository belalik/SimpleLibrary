using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    
    class Video : Item
    {
        // Property Duration - συγκεκριμένο μόνο για αντικείμενα τύπου Video. 
        public int Duration { get; set; }

        // Με κάθε δημιουργία αντικειμένου Video - καλώ τον base constructor (του Item)
        // δίνοντας το title σαν παράμετρο (αφού μόνο αυτήν την παράμετρο περιμένει ο 
        // constructor του Item).  Αφου κληθεί ο base constructor, προχωρώ στην πιο συγκεκριμένη
        // ενέργεια που αφορά το κάθε νέο Video - συγκεκριμένα, δίνω τιμή στην Property Duration. 

        public Video(string title, int duration)
            : base(title)
        {

            Duration = duration;
        }
        
    }
}
