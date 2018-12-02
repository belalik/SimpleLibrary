using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * TODO - Πράγματα που μπορούμε να δούμε στο εργαστήριο: 
 * 
 * 1.   Να τυπώνω καλύτερα μηνύματα
 * 2.   Να κάνω override την toString για να τυπώσω τον τύπο κάθε Item
 * 3.   
 * 
 * 
 */
 
namespace Library
{
    /*
     * Ίσως η πιο βασική κλάση της άσκησης, αφού εδώ υλοποιείται το μεγαλύτερο μέρος
     * της 'λογικής'.
     */
class Library
    {

        // Property που καθορίζει μέχρι πόσα Items μπορεί να δανείστεί ένας χρήστης (παίρνει τιμή στον constructor). 
        public int MaxNumberOfLoans { get; set; }

        // Λίστα που θα κρατάει όλους τους χρήστες της βιβλιοθήκης (αντικείμενα της κλάσης User). 
        public List<User> Users { get; set; }

        // Λίστα που θα κρατάει όλα τα Items
        public List<Item> Items { get; set; }
        
        // Λίστα που θα κρατάει όλα τα Loans
        public List<Loan> Loans { get; set; }

        /*
         *  Ακολουθεί ο κώδικας του Constructor του Library - με άλλα λόγια, ο κώδικας που θα τρέξει μόλις
         *  δημιουργήσω ένα αντικείμενο της κλάσης Library.  Δέχεται μια παράμετρο int που καθορίζει τον μέγιστο 
         *  αριθμό από Items που μπορεί να δανειστεί ένας χρήστης.. 
         *  
         *  *** Σημείωση για μένα - Να πούμε στο εργαστήριο για re-usability (πχ το numOfLoans ως παράμετρο, και όχι καρφωτό), 
         *  και για τον κίνδυνο Null Pointers και την προσοχή που χρειάζονται στις λίστες.. Γι 'αυτό τις αρχικοποιώ παρακάτω.. 
         */
        public Library(int maxNumberOfLoans)
        {
            // Αρχικοποιώ την λίστα που κρατάει όλα τα Items. 
            Items = new List<Item>();

            // Αρχικοποιώ την λίστα που κρατάει όλους τους Users,
            Users = new List<User>();

            // Αρχικοποιώ την λίστα που κρατάει όλα Loans.
            Loans = new List<Loan>();

            MaxNumberOfLoans = maxNumberOfLoans;
        }

        /*
         *  Αυτή η μέθοδος ΧΡΗΣΙΜΟΠΟΙΕΙΤΑΙ ΜΟΝΟ ΣΤΗΝ ΕΙΣΑΓΩΓΗ JOURNAL ... Επίτηδες, και απλώς σαν παράδειγμα. 
         *  
         *  Είναι ένας διαφορετικός τρόπος να προσθέσω ένα αντικείμενο στη λίστα
         *  ίσως στα πλαίσια του 'encapsulation' να μπορεί να πει κανείς πως είναι πιο 
         *  σαφές να το κάνω έτσι - δηλαδή η βιβλιοθήκη είναι υπεύθυνη, αυτή "ξέρει" πως να προσθέτει 
         *  αντικείμενα ... Θα μπορούσα πχ να κάνω έναν έλεγχο αν υπάρχει ήδη το αντικείμενο και τότε 
         *  να μην το προσθέτω, αυτός ο έλεγχος θα έπρεπε να γίνεται εδώ.. 
         */
        public void AddItem(Item item)
        {
            Items.Add(item);
        }


        // Αντίστοιχη μέθοδος ΠΟΥ ΔΕΝ ΧΡΗΣΙΜΟΠΟΕΙΤΑΙ - αλλά θα μπορούσε να αναλαμβάνει αυτή την προσθήκη κάθε νέου χρήστη. 
        // Θα ήταν χρήσιμη αν είχα ελέγχους, πχ όνομα χρήστη όχι μεγαλύτερο από 12 χαρακτήρες, ή να μην έχει κενά κλπ κλπ ... 
        public void AddUser(User user)
        {
            Users.Add(user);
        }
        

        /*
         *  Μέθοδος LoanItem που είναι υπεύθυνη να κάνει τον δανεισμό.  Δέχεται τρεις παραμέτρους - 
         *  ένα αντικείμενο της κλάσης User (τον χρήστη που θα δανειστεί), ένα αντικείμενο Item 
         *  (το Item που θα δανειστεί) και ένα αντικείμενο DateTime στο οποίο φυλάσσεται η ημερομηνία δανεισμού. 
         */
        public void LoanItem(User user, Item item, DateTime date)
        {
            

            // Αν το Item είναι δανεισμένο, τότε εμφάνισε αντίστοιχο μήνυμα. 
            if (item.OnLoan)
            {
                Console.WriteLine("FROM METHOD LoanItem ---  I am sorry mr. " + user.Name + " but " + item.Title + " (ID=" + item.ItemID + ") is currently on loan");
            }
            else
            {
                // Αν ο χρήστης έχει ήδη φτάσει τον μέγιστο αριθμό από Loans, δεν μπορεί να δανειστεί. 
                if (user.NumberOfItemsLoaned >= MaxNumberOfLoans)
                {
                    Console.WriteLine("FROM METHOD LoanItem ---  Sorry " + user.Name + " but you already have " + MaxNumberOfLoans + " loans");
                }
                else
                {
                    Console.WriteLine("FROM METHOD LoanItem ---  OK - user " + user.Name+" loaned "+item.Title+" on "+date.ToShortDateString());
                    
                    // πολύ σημαντικό - χρησιμοποιώ το Property OnLoan του Item για να αλλάξω την τιμή και να την κάνω 'true' 
                    // εφόσον πλέον το αντικείμενο είναι δανεισμένο. 
                    item.OnLoan = true;

                    // Χρησιμοποιώ το Property NumberOfItemsLoaned της κλάσης User - κρατάει τον αριθμό των Loans του χρήστη. 
                    user.NumberOfItemsLoaned++;

                    // Εφόσον έχω φτάσει μέχρι εδώ, το Loan είναι επιτυχές - και το περνάω πλέον στην Λίστα Loans που κρατάει όλους τους 'δανεισμούς'. 
                    Loans.Add(new Loan(date, item, user));
                }

            }
        }

        /*
         * Μέθοδος που επιστρέφει ένα αντικείμενο στην βιβλιοθήκη. 
         * 
         * Παίρνει σαν παραμέτρους έναν χρήστη και ένα Item.  Είναι λίγο δύσκολη - γιατί πρέπει πρώτα να ψάξει αν όντως
         * υπάρχει τέτοιο Loan (αν δηλαδή όντως ο συγκεκριμένος χρήστης έχει δανειστεί το συγκεκριμένο Item). 
         * 
         * Η συγκεκριμένη μέθοδος είναι λίγο προχωρημένη.  Θα την συζητήσουμε στο εργαστήριο. 
         */
        public void Return(User user, Item item)

        {
            // Αυτή είναι η μέθοδος Find που μπορεί να χρησιμοποιηθεί λίστα, και επιστρέφει το πρώτο αντικείμενο από την λίστα
            // που ικανοποιεί μια δεδομένη συνθήκη.  Στην προκειμένη περίπτωση, θα ψάξει την λίστα Loans και θα γυρίσει το πρώτο
            // Loan για το οποίο το ItemLoaned.ItemID θα είναι ίσο με το item.ItemID, με άλλα λόγια θα τσεκάρει αν όντως έχει 
            // περαστεί αυτό το Item στη λίστα Loans. 
            Loan theLoan = Loans.Find(x => x.ItemLoaned.ItemID == item.ItemID);


            // Αν το theLoan που γύρισε από πάνω η Find είναι null (δηλαδή κενό) - τότε δεν βρέθηκε Loan για αυτό το αντικείμενο. 
            if (theLoan == null)
            {
                Console.WriteLine("FROM METHOD Return ---  There is no loan for Item: " + item.Title + " ID="+item.ItemID);
            }
            // Αλλιώς, μπαίνω στο else - που σημαίνει πως όντως υπήρξε δανεισμός αυτού του Item. 
            // Τώρα τσεκάρω αν έχει δανείστεί αυτό το Item ο χρήστης που προσπαθεί να το επιστρέψει. 
            else
            {
                // αν ο χρήστης που προσπαθεί να το επιστρέψει είναι όντως αυτός που το δανείστηκε, τότε υλοποίησε το Return. 
                if (user.UserID == theLoan.UserLoaning.UserID)
                {
                    Console.WriteLine("FROM METHOD Return ---  OK - Item: " + item.Title + " with ID=" + theLoan.ItemLoaned.ItemID + " is returned to the library by "+user.Name);
                    theLoan.ItemLoaned.OnLoan = false;
                    Loans.Remove(theLoan);
                    user.NumberOfItemsLoaned--;
                }
                // Αλλιώς μην κάνεις επιστροφή αντικειμένου, και γράψε ένα μήνυμα λάθους. 
                else
                {
                    Console.WriteLine("FROM METHOD Return ---  Item: " + item.Title + " is loaned by " + theLoan.UserLoaning.Name + " and cannot be returned by " + user.Name);
                }

            }
        }

        /*
         *  Ακολουθούν μερικές υλοποιήσεις μιας μεθόδου που τυπώνει όλα τα Items. 
         *  
         *  Αρχίζω από μια πολύ απλή, και σιγά-σιγά γίνεται λίγο πιο πολύπλοκη. 
         */

        // Η πιο απλή version - κάνει ένα απλό foreach σε όλη τη λίστα Items και τυπώνει ID και title
        public void ShowAllItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OUTPUT FROM ShowAllItems number 1");
            Console.ResetColor();
            foreach (Item i in Items)
            {
                Console.WriteLine("ID: "+i.ItemID+" --- "+i.Title);
            }
            
        }

        // Απλή παραλλαγή - τσεκάρει το onLoan και αλλάζει το μήνυμα εκτύπωσης
        public void ShowAllItems2()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("OUTPUT FROM ShowAllItems number 2");
            Console.ResetColor();
            foreach (Item i in Items)
            {
                if (i.OnLoan)
                {
                    Console.WriteLine("ID: " + i.ItemID + " --- " + i.Title + " --- ON LOAN");
                }
                else {
                    Console.WriteLine("ID: " + i.ItemID + " --- " + i.Title + " --- AVAILABLE");
                }
                
            }
        }

        // Ολόιδια με την ShowAllItems2 - αλλά .. 
        /*
        *  Χρησιμοποιώ το conditional operator '?:' - λέγεται και ternary operator. 
        *  Έχει τη γενική μορφή: ' condition ? consequence : alternative '
        *  
        *  που σημαίνει 'Αν (condition==TRUE) κάνε το consequence, αλλιώς κάνε το alternative. 
        *  
        *  Ουσιαστικά το χρησιμοποιώ έτσι ώστε να γράψω τη λέξη 'On LOAN' αν είναι δανεισμένο σε κάποιον 
        *  (αν δηλαδή η OnLoan ιδιότητα είναι TRUE) αλλιώς να γράψω τη λέξη 'AVAILABLE' αν η OnLoan ιδιότητα είναι FALSE. 
        *  
        *  το είχαμε κάνει στο ΤΜΠ .. Ψάξτε για 'ternary operator' στην C# αλλά και γενικότερα, και θα βρείτε πολλά παραδείγματα. 
        */
        public void ShowAllItems3()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("OUTPUT FROM ShowAllItems number 3");
            Console.ResetColor();
            foreach (Item i in Items)
            {
                Console.WriteLine("ID: "+i.ItemID+" --- "+i.Title+ " --- "+ (i.OnLoan ? "On LOAN" : "AVAILABLE"));   
            }
        }

        /*
         * Εδώ κάνω κάτι λίγο πιο προχωρημένο. 
         * 
         * Χρησιμοποιώ μια μέθοδο που από τη συνολική λίστα των Items, θα μου γυρίσει μια υπο-λίστα με μόνο τα Books, 
         * τα Videos και τα Journals.  Έτσι μπορώ να τυπώσω και πιο συγκεκριμένα στοιχεία του κάθε αντικειμένου, 
         * (το author για τα βιβλία, το Duration για τα Video και το Publisher για τα Journal). 
         * 
         * Αυτό θα μπορούσε να γίνει με πολλούς άλλους τρόπους (πχ αν μιλήσουμε για casting στο εργαστήριο) - 
         * βάζω αυτόν απλά για να δείτε πως υπάρχουν πάρα πολλές έτοιμες μέθοδοι στην C# που μας διευκολύνουν, 
         * αρκεί να ξέρουμε πως να τις χρησιμοποιήσουμε ... 
         * 
         * Επίσης, χρησιμοποιώ το '\' για να τυπώσω '"' ... αυτό λέγεται 'escape character' ... Θα το δούμε στο εργαστήριο ... 
         */
        public void ShowAllItems4()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OUTPUT FROM ShowAllItems number 4");
            Console.ResetColor();
            List<Book> books = Items.OfType<Book>().ToList();

            List<Video> videos = Items.OfType<Video>().ToList();

            List<Journal> journals = Items.OfType<Journal>().ToList();

            foreach (Book b in books)
            {
                Console.WriteLine("BOOK - ID: [" + b.ItemID + "], \"" + b.Title + "\"" + " by " + b.Author + " --- " + (b.OnLoan ? "On LOAN" : "AVAILABLE"));
            }
            foreach (Video v in videos)
            {
                Console.WriteLine("VIDEO - ID: [" + v.ItemID + "], \"" + v.Title + "\"" +
                            " with a duration of:  " + v.Duration + " min --- " +
                            (v.OnLoan ? "On LOAN " : "AVAILABLE"));
            }
            foreach (Journal j in journals)
            {
                Console.WriteLine("JOURNAL - ID: [" + j.ItemID + "], \"" + j.Title + "\"" + " published by:  " + j.Publisher + " --- " + (j.OnLoan ? "On LOAN" : "AVAILABLE"));
            }
        }

        // Μέθοδος που θα τυπώσει όλα τα loans που έχουν καθυστερήσει, και το πρόστιμο για το κάθε ένα. 
        // Χρησιμοποιεί μια private μέθοδο PrettyPrint που αναλαμβάνει το τύπωμα.. 

        // ΓΕΝΙΚΩΣ ΠΡΟΣΠΑΘΩ ΝΑ ΑΚΟΛΟΥΘΩ ΕΝΑ ΑΞΙΩΜΑ - ΚΑΘΕ ΜΕΘΟΔΟΣ ΠΡΕΠΕΙ ΝΑ ΚΑΝΕΙ ΕΝΑ ΚΑΙ ΜΟΝΟ, ΣΑΦΕΣ, ΠΡΑΓΜΑ. 
        // ΑΠΟΦΕΥΓΩ ΟΣΟ ΜΠΟΡΩ ΟΙ ΜΕΘΟΔΟΙ ΜΟΥ ΝΑ ΚΑΝΟΥΝ ΠΑΡΑΠΑΝΩ ΠΡΑΓΜΑΤΑ - ΓΙΑΤΙ ΓΙΝΟΝΤΑΙ ΠΙΟ ΠΟΛΥΠΛΟΚΕΣ ΚΑΙ ΣΥΝΕΠΩΣ
        // ΠΙΟ ΔΥΣΚΟΛΕΣ ΣΕ ΕΝΤΟΠΙΣΜΟ ΛΑΘΩΝ ΚΑΙ ΣΥΝΤΗΡΗΣΗ.
        public void ShowOverdueLoans()
        {
            Console.WriteLine();
            Console.WriteLine("*** PRINTING LATE LOANS ***");
            
            
            foreach (Loan loan in Loans)
            {
                    
                // Υπολογίζω πόσες μέρες έχουν περάσει από σήμερα (DateTime.Now) μέχρι την ημερομηνία δανεισμού.  Γυρνάει ένα int - πχ 5 μέρες καθυστέρηση. 
                // ΑΥΤΟ ΧΡΕΙΑΖΕΤΑΙ ΕΞΗΓΗΣΗ ΣΤΟ ΕΡΓΑΣΤΗΡΙΟ - ΣΗΜΕΙΩΣΗ ΓΙΑ ΜΕΝΑ: το cast truncates, to Convert.ToInt θα έκανε στρογγυλοποίηση (round). 
                int days = (int)(DateTime.Now - loan.DateLoaned).TotalDays;

                // Αν το Item είναι βιβλιο (Book) τότε η καθυστέρηση μετράει από 28 μέρες και πάνω
                if (loan.ItemLoaned.GetType() == typeof(Book))
                {
                    if (days > 28)
                    {
                        // Κάλεσε την μέθοδο PrettyPrintLateLoan - αυτή είναι υπεύθυνη να τυπώσει το μήνυμα ... 
                        PrettyPrintLateLoan(loan, days - 28);
                    }

                }

                // Αν το Item είναι Journal τότε η καθυστέρηση μετράει από 14 μέρες και πάνω
                if (loan.ItemLoaned.GetType() == typeof(Journal))
                {
                    if (days > 14)
                    {
                        PrettyPrintLateLoan(loan, days - 14);
                    }

                }

                // Αν το Item είναι Video τότε η καθυστέρηση μετράει από 7 μέρες και πάνω
                if (loan.ItemLoaned.GetType() == typeof(Video))
                {
                    if (days > 7)
                    {
                        PrettyPrintLateLoan(loan, days - 7);

                    }

                }
                
            }
                
            
        }

        /*
         * Μέθοδος που τυπώνει το μήνυμα για τα αργοπορημένα Loans.  
         * 
         * Με την σειρά της, καλεί την εσωτερική (private) μέθοδο CalculateFine ..  Όπως εξήγησα και στα σχόλια της μεθόδου
         * ShowOverdueLoans, προσπαθώ Η ΚΑΘΕ ΜΕΘΟΔΟΣ ΝΑ ΚΑΝΕΙ ΕΝΑ ΚΑΙ ΜΟΝΟ ΠΡΑΓΜΑ, όσο μπορώ πιο σαφές.  Έτσι το πρόγραμμά μου 
         * έχει μικρές και κατανοητές μεθόδους που μπορούν να συντηρηθούν πιο εύκολα.  Αν όλα τα έκανα σε μια μέθοδο, θα ήταν 
         * πιο μεγάλη και πιο πολύπλοκη. 
         */
        private void PrettyPrintLateLoan(Loan l, int days)
        {
            // απλώς μια κενή γραμμή για αισθητικούς λόγους..
            Console.WriteLine(); 

            Console.WriteLine(l.ItemLoaned.Title + " ID="+l.ItemLoaned.ItemID+" borrowed by "+l.UserLoaning.Name+" on "+l.DateLoaned.ToShortDateString());
            Console.ForegroundColor = ConsoleColor.Red;

            // εδώ καλεί την CalculateFine, περνώντας το loan σαν παράμετρο
            Console.WriteLine("is "+days+ " days late, and the fine today ("+DateTime.Now.ToShortDateString()+") is "+CalculateFine(l)+ " euros."  );
            Console.ResetColor();
            

        }

        /*
         *  Εσωτερική (private) μέθοδος που παίρνει το loan, υπολογίζει το πρόστιμο, και το γυρνάει σε τιμή int.  Δεν κάνει τίποτα άλλο .. 
         *  
         *  Σύμφωνα με την εκφώνηση, τα Books θεωρούνται late μετά από 4 εβδομάδες (28 μέρες) και το πρόστιμο είναι 1 ευρώ την κάθε μέρα. 
         *  Τα Journals θεωρούνται late μετά από δυο εβδομάδες (14 μέρες) και το πρόστιμο είναι 3 ευρώ την ημέρα. 
         *  Τα Videos θεωρούνται late μετά από μια εβδομάδα, και το πρόστιμο είναι 5 ευρώ την ημέρα. 
         *  
         */
        private int CalculateFine(Loan late)
        {
            
            int days = (int)(DateTime.Now - late.DateLoaned).TotalDays;

            if (late.ItemLoaned.GetType() == typeof(Book))
            {
                return (days - 28);
            }
            else if (late.ItemLoaned.GetType() == typeof(Journal))
            {
                return (days - 14) * 3;
            }
            else
            {
                return (days - 7) * 5;
            }

        }

    }
}


