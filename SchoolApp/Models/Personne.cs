using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal abstract class Personne : Model
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
    }
}
