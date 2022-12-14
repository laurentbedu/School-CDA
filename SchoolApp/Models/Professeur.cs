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
        // Attributs :
        private string login = "Login non défini";
        private string password = "Password non défini";
        private bool isAdmin = false;
        private Classe? classe;

        // Propriétés :

        [NePasIntegrerDansToStringAttribute] public string Login { get { return login; } }
        [NePasIntegrerDansToStringAttribute] public string Password { get { return password; } }
        public bool IsAdmin { get { return isAdmin; } }
        public Classe? Classe { get { return classe; } set { classe = value; } }
        // Getters Setters :
        // Constructeurs :
        public Professeur(string nom, string prenom, string newLogin, string newPassword) : base(nom, prenom)
        {
            login = newLogin;
            password = newPassword;
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
