using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Matiere
    {
        // Attributs :
        private string id = "Id non défini";
        private string nom = "Nom non défini";


        // Propriétés :
        public string Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }

        // Constructeurs :
        public Matiere(string nomMatiere)
        {
            nom = nomMatiere;
            id = generateId();
        }

        // Methodes :
        public string generateId()
        {
            Random rnd = new Random();
            return DateTime.Now.ToString("yyMMddHHmmssff") + "-" + rnd.Next(1, 999);
        }

        // ToString Override
        public override string ToString()
        {
            return "Matière: " + nom;
        }
    }
}
