using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Professeur : Personne
    {
        public Classe? classe { get; set; }
        public string login { get; set; }
        public string password { get; set; }


        public void AddClasse(Classe classe)
        {
            if (Classe != classe)
            {
                Classe = classe;
                if (classe.Professeur != this)
                {
                    classe.AddProfesseur(this);
                }
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.RemoveProfesseur(this);
                }
            }
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
