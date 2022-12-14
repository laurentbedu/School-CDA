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

        // Propriétés :
        public string Id        {   get { return id; }                      }
        public string Login     {   get { return login; }                   }
        public string Password  {   get { return password; }                }
        public Classe? Classe   {   get;                        set;        }

        // Constructeurs :
        public Professeur(string nom, string prenom, string newLogin, string newPassword) : base(nom, prenom)
        {
            this.login      = newLogin;
            this.password   = newPassword;
            id              = generateId();
        }

        // Methodes :
        public void ajouterClasse ( Classe classe)
        {
            if (this.classe !=null)
            {
                Classe = classe;
            }
            else
            {
                MessageBox.Show(Nom + " a déjà une classe.");
            }
        }
        public void supprimerClasse()
        {
            this.classe = null;
        }

        // ToString Override
        public override string ToString()
        {
            return base.ToString() + "login:"+login+"(Prof)";
        }
    }
}
