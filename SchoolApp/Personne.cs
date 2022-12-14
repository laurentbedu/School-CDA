using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int id_personne { get; set; }

        public void AddNom(string nom)
        {
            nom = nom.ToLower();
        }
        public void AddPrenom(string prenom)
        {
            prenom= prenom.ToLower();
        }
    }
}
