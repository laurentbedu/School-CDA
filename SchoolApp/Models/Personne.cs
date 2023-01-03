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

        public Personne() 
        {

            id = IdGenerator.Create(this);

        }

    }
}
