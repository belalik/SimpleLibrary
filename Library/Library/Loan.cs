using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /*
     * Η κλάση Loan ίσως σας φαίνεται λίγο διαφορετική από τις υπόλοιπες.  Στο design μας, προέρχεται από το 
     * ουσιαστικό 'ο δανεισμός' - και περιγράφει / υλοποιεί / 'μεταφέρει' την έννοια ενός δανεισμού 
     * κάποιου αντικειμένου της βιβλιοθήκης από κάποιον χρήστη της βιβλιοθήκης. 
     * 
     * Αν το σκεφτείτε, απαραίτητα χαρακτηριστικά ενός δανεισμού από μια βιβλιοθήκη, είναι:
     *   
     *    - Ποιος χρήστης δανείστηκε
     *    - Ποιο αντικείμενο δανείστηκε
     *    - Πότε το δανείστηκε
     *    
     *    Και θα προσθέσω και ένα μοναδικό LoanID - έτσι ώστε να μπορώ εύκολα να διαχωρίσω τον κάθε 'δανεισμό'. 
     *    
     *    Αυτόν τον σχεδιασμό υλοποιώ στην κλάση Loan. 
     */
    class Loan
    {
        // Χρησιμοποιώ ίδια λογική με το Item - χρησιμοποιώντας μια static μεταβλητή για το ID.  
        // Δες το Item για περισσότερες πληροφορίες. 
        private static int staticLoanID;

        // Property τύπου DateTime που θα κρατάει την ημερομηνία δανεισμού. 
        // Χρησιμοποιώ την έτοιμη κλάση DateTime - μου προσφέρει πολύ σημαντική 
        // βοήθεια - θα δούμε συγκεκριμένα παραδείγματα στο εργαστήριο. 
        public DateTime DateLoaned { get; set; }


        public int LoanID { get; set; }

        // Property τύπου Item - εδώ κρατάω το Item που έχει δανείστεί ο χρήστης.  
        // Προσοχή - κρατάω ΟΛΟ το αντικείμενο Item, όχι μόνο το ItemID ... 
        public Item ItemLoaned { get; set; }

        // Property τύπου User - εδώ κρατάω τον User που έχει 
        public User UserLoaning { get; set; }

        public Loan(DateTime dateloaned, Item itemloaned, User userloaning)
        {

            LoanID = staticLoanID++;  // auto increment value for LoanID.

            DateLoaned = dateloaned;
            ItemLoaned = itemloaned;
            UserLoaning = userloaning;

        }
    }
}
