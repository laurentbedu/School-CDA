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

        // Propriétés :
        public string Id        {   get { return id; }                      }
        public string Login     {   get { return login; }                   }
        public string Password  {   get { return password; }                }

        // Constructeurs :
        public Professeur(string nom, string prenom, string newLogin, string newPassword) : base(nom, prenom)
        {
            this.login      = newLogin;
            this.password   = newPassword;
            id              = generateId();
        }

        // Methodes :

        // ToString Override
        public override string ToString()
        {
            return base.ToString() + "login:"+login+"(Prof)";
        }
    }
}
