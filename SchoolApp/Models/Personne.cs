using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal class Personne
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string id { get; set; }

        public Personne()
        {
            id = IdGenerator.Create(this);
        }

        public void AddNom(string nom)
        {
            nom = nom.ToLower();
        }
        public void AddPrenom(string prenom)
        {
            prenom = prenom.ToLower();
        }
        public override string ToString()
        {
            return id+" "+nom+" "+prenom;
        }
    }
}
