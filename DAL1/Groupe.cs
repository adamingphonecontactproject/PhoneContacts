using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    public class Groupe
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public List<Contact_Groupe> Contact_Groupes2 { get; set; }
    }
}
