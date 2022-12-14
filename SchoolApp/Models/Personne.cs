using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal abstract class Personne
    {
        // Attributs :
        private string nom = "Nom non défini";
        private string prenom = "Prénom non défini";
        private string id = "Id non défini";

        // Propriétés :
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Id { get { return id; } set { id = value; } }

        // Constructeurs :
        public Personne(string nomPersonne, string prenomPersonne)
        {
            nom = nomPersonne;
            prenom = prenomPersonne;
            id = generateId();
        }

        // Methodes :
        public string generateId()
        {
            return DateTime.Now.ToString("yyMMddHHmmssff") + "-" + GetHashCode();
        }

        // ToString Override
        public override string ToString()
        {
            return Tools.UniversalToString.ToStringer(this);
        }
    }
}
