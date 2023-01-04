using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal abstract class Personne : Model
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne() 
        {

            Id = IdGenerator.Create(this);

        }

    }
}
