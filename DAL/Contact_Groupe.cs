using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contact_Groupe
    {
        public string ContactId { get; set; }
        public string GroupeId { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<Groupe> Groupes { get; set; }
    }
}
