using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Item
    {
        /*
         * Static μεταβλητή - είναι κοινή για όλα τα instances της κλάσης.  Με άλλα λόγια, την χρησιμοποιώ έτσι ώστε 
         * σε κάθε Item να δημιουργώ αυτόματα ένα νέο ID και να μην χρειάζεται κάθε φορά να δίνω έναν αριθμό. 
         * 
         * Ξεκινάω με τον αριθμό 1000 και κάθε φορά που δημιουργείται νέο Item, προσθέτω 1 (staticID++).  
         * 
         * Περισσότερα για το keyword static και τι ακριβώς σημαίνει, θα βρείτε εδώ:
         * https://stackoverflow.com/questions/10795502/what-is-the-use-of-static-variable-in-c-when-to-use-it-why-cant-i-declare-th
         * 
         * Άλλά και αν ψάξτε 'static C#' ή 'how static works in C#', θα βρείτε πάρα πολλές σελίδες με κείμενο και παραδείγματα. 
         * 
         */
        private static int staticID = 1000;
        
        /*
         * Constructor της κλάσης Item.  Εκτελείται σε κάθε δημιουργία νέου Item.  Δέχεται μια μόνο 
         * παράμετρο (string title).  Κατόπιν εκτελεί κάποιες απαραίτητες ενέργειες - ορίζει το onLoan σε false
         * και δίνει τιμή στο property ItemID χρησιμοποιώντας την private static μεταβλητή staticID. 
         * 
         * Ο constructor θα καλείται (και συνεπώς θα εκτελείται) και σε κάθε δημιουργία κλάσης που κληρονομεί το Item, 
         * δηλαδή και σε κάθε δημιουργία Book, Video και Journal.
         */
        public Item(string title)
        {
            Title = title;

            // Όταν φτιάχνω (κατασκευάζω) ένα Item, ξεκινάει ως διαθέσιμο για δανεισμό (onLoan = false). 
            OnLoan = false;

            /*
             * Εδώ χρησιμοποιώ το staticID για να δώσω τιμή στο property ItemID. 
             * 
             * Προσοχή - το property ItemID είναι ΞΕΧΩΡΙΣΤΟ για κάθε instance της κλάσης 
             * το κάθε αντικείμενο Item έχει το δικό του ItemID. 
             * 
             * Απλώς χρησιμοποιώ την static μεταβλητή staticID για να 'κρατάω' τον αριθμό
             * που θέλω να δίνω στο ItemID στη δημιουργία κάθε νέου Item.
             */
            ItemID = staticID++;
        }

        /*
         * Ακολουθούν Properties για κάθε Item (τα οποία και κληρονομούνται στα Book, Video και Journal)
         */
        public string Title { get; set; }

        public bool OnLoan { get; set; }

        public int ItemID { get; private set; }


    }
}
