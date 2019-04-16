using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceGroupe
    {
        /// <summary>
        /// Permet l'ajout d'un Groupe à la DB
        /// </summary>
        /// <param name="c">Un objet de type Groupe</param>
        /// <returns>Retourne True si l'ajout est ok, sinon False </returns>
        public bool Add(Groupe c)
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
        /// Permet la MAJ d'un Groupe dans la DB
        /// </summary>
        /// <param name="c">Un objet de type Groupe</param>
        /// <returns>Retourne True si la MAJ est ok, sinon False </returns>
        public bool Update(Groupe c)
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
        /// Permet la suppression d'un Groupe de la DB grace à son identifiant
        /// </summary>
        /// <param name="c">Un objet de type type Groupe</param>
        /// <returns>Retourn True si la suppression est ok, sinon False </returns>
        public bool Delete(Groupe c)
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
        /// Permet la suppression d'un Groupe de la DB grace à son identifiant
        /// </summary>
        /// <param name="c">Un objet de type type Groupe</param>
        /// <returns>Retourn True si la suppression est ok, sinon False </returns>
        public Groupe FindByName(string nom)
        {
            try
            {
                return new Groupe();
            }
            catch
            {
                return null;
            }
        }
    }
}
