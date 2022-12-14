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
        public Classe classe;
        public string login;
        public string password;

        public Professeur(string nom, string prenom, Classe classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.classe = classe;
        }

        public void addClasse(Classe classe)
        {

        }
        public void removeClasse(Classe classe) 
        { 
        
        }
        public void creerPassword() {

        }
        public void modifierPassword()
        {

        }
        public override string ToString()
        {
            return "Professeur : "+nom+" "+prenom+" - Classe : "+classe;
        }
    }
}
