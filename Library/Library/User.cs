using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User

    {
        // Χρησιμοποιώ ίδια λογική με το Item - χρησιμοποιώντας μια static μεταβλητή.  
        // Δες το Item για περισσότερες πληροφορίες. 
        private static int staticUserID;

        // Property που κρατάει πόσα αντικείμενα έχει δανειστεί ο χρήστης. 
        // Σε κάθε νέο χρήστη, θα την αρχικοποιώ με την τιμή 0 (μέσα στον constructor). 
        public int NumberOfItemsLoaned { get; set; }

        public string Name { get; set; }

        public int UserID { get; set; }

        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;

            // Η αρχική τιμή για κάθε νέο χρήστη θα είναι μηδέν.
            NumberOfItemsLoaned = 0;
            UserID = staticUserID++;
        }

        
    }
}
