using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {

        public Classe? Classe { get; set; }
        public string? Login { get; set; }
        public string? password { get; set; }

        public bool isAdmin { get; set; }


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

        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
