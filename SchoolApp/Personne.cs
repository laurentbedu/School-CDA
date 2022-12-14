using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal abstract class Personne
    {
        // Attributs :
        private string nom      = "Nom non défini";
        private string prenom   = "Prénom non défini";
        private string id       = "Id non défini";

        // Propriétés :
        public string Nom       {   get { return nom; }       set { nom = value; }        }
        public string Prenom    {   get { return prenom; }    set { prenom = value; }     }
        public string Id        {   get { return id; }        set { id = value; }         }

        // Constructeurs :
        public Personne(string nomPersonne, string prenomPersonne)
        {
            this.nom    = nomPersonne;
            this.prenom = prenomPersonne;
            this.id     = generateId();
        }

        // Methodes :
        public string generateId()
        {
            Random rnd = new Random();
            return DateTime.Now.ToString("yyMMddHHmmssff") +"-"+ rnd.Next(1,999);
        }

        // ToString Override
        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
