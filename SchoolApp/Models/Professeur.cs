using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {
        // Propriétés :
        public bool IsAdmin { get; set; }
        [NePasIntegrerDansToStringAttribute] public string Login { get; set; }
        [NePasIntegrerDansToStringAttribute] public string Password { get; set; }
        [NePasIntegrerDansToStringAttribute] public Classe? Classe { get; private set; }

        // Constructeurs :
        public Professeur(string nom, string prenom, string newLogin, string newPassword) : base(nom, prenom)
        {
            Login = newLogin;
            Password = newPassword;
        }

        // Methodes :
        public void ajouterClasse(Classe classe)
        {
            if (Classe != classe)
            {
                Classe = classe;
                if (classe.Professeur != this)
                {
                    classe.ajouterProfesseur(this);
                }
            }
        }
        public void retirerClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.retirerProfesseur(this);
                }
            }
        }
        // ToString Override
    }
}
