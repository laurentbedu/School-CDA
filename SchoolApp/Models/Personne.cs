using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal class Personne : Model
    {
        public string nom { get; set; }
        public string prenom { get; set; }

        public void AddNom(string nom)
        {
            nom = nom.ToLower();
        }
        public void AddPrenom(string prenom)
        {
            prenom = prenom.ToLower();
        }
    }
}
