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
        private string id = "Id non défini";
        private string nom = "Nom non défini";
        private string prenom = "Prénom non défini";

        // Propriétés :
        public string Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }

        // Constructeurs :
        public Personne(string nomPersonne, string prenomPersonne)
        {
            nom = nomPersonne;
            prenom = prenomPersonne;
            id = Tools.IdGenerator.generateId(this);
        }

        // Methodes :

        // ToString Override
        public override string ToString()
        {
            return Tools.UniversalToString.ToStringer(this);
        }
    }
}
