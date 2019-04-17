using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class ServiceContact
    {
        /// <summary>
        /// Permet l'ajout d'un contact à la DB
        /// </summary>
        /// <param name="c">Un objet de type contact</param>
        /// <returns>Retourne True si l'ajout est ok, sinon False </returns>
        public bool Add(Contact co)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet la MAJ d'un contact dans la DB
        /// </summary>
        /// <param name="c">Un objet de type contact</param>
        /// <returns>Retourne True si la MAJ est ok, sinon False </returns>
        public bool Update(Contact c)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet la suppression d'un contact de la DB grace à son identifiant
        /// </summary>
        /// <param name="c">Un objet de type type contact</param>
        /// <returns>Retourn True si la suppression est ok, sinon False </returns>
        public bool Delete(Contact c)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Permet la suppression d'un contact de la DB grace à son identifiant
        /// </summary>
        /// <param name="c">Un objet de type type contact</param>
        /// <returns>Retourn True si la suppression est ok, sinon False </returns>
        public Contact FindByName(string nom)
        {
            try
            {
                return new Contact();
            }
            catch
            {
                return null;
            }
        }
    }
}
