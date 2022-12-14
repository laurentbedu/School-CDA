using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Professeur : Personne
    {
        public int id_prof;
        public string matiere;
        public string login;
        public string password;

        public Professeur(string nom, string prenom, string matiere)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.matiere = matiere;
        }
        public void creerPassword() {

        }
        public void modifierPassword()
        {

        }
    }
}
