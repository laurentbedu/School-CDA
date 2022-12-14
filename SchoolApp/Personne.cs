using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Personne
    {
        public string nom;
        public string prenom;
        public int id_personne;

        public void AjouterNom(string nom)
        {
            nom = nom.ToLower();
        }
        public void AjouterPrenom(string prenom)
        {
            prenom= prenom.ToLower();
        }
    }
}
