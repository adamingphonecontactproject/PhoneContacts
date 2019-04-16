using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Preom { get; set; }
        public string Numero_Mobile { get; set; }
        public string Numero_Fixe { get; set; }
        public string Email { get; set; }

        public List<Contact_Groupe> Contact_Groupes1{ get; set; }
    }
}
