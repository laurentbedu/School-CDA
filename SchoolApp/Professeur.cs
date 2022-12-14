using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Professeur : Personne
    {
        // Attributs :
        private string id       = "Id non défini";
        private string login    = "Login non défini";
        private string password = "Password non défini";
        private Classe? classe;
        private bool isAdmin = false;

        // Propriétés :
        public string Id        {   get { return id; }                      }
        public string Login     {   get { return login; }                   }
        public string Password  {   get { return password; }                }
        public bool IsAdmin     {   get { return isAdmin; }                }
        public Classe? Classe   {   get { return classe;           }           set            {                 classe = value;            }            }
        // Getters Setters :
        // Constructeurs :
        public Professeur(string nom, string prenom, string newLogin, string newPassword) : base(nom, prenom)
        {
            this.login      = newLogin;
            this.password   = newPassword;
            this.id         = generateId();
        }

        // Methodes :
        public void ajouterClasse(Classe classe)
        {
            if ( Classe != classe)
            {
                Classe = classe;
                if (classe.Professeur !=this)
                {
                    classe.ajouterProfesseur(this);
                }
            }
        }
        public void supprimerClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.supprimerProfesseur(this);
                }
            }
        }

        // ToString Override
        public override string ToString()
        {
            return base.ToString() + "login:"+login+"(Prof)";
        }
    }
}
