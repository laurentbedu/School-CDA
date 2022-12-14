using SchoolApp.Attributes;
using SchoolApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {
        [IsNotInToStringAttribute]
        public string Login { get; set; }
        [IsNotInToStringAttribute]
        public string Password { get; set; }



        [IsNotInToStringAttribute]
        public Classe? Classe { get; private set; }
        public void AddClasse(Classe classe)
        {
            if (Classe != classe)
            {
                Classe = classe;
                if (classe.Professeur != this)
                {
                    classe.AddProfesseur(this);
                }
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.RemoveProfesseur(this);
                }
            }
        }


        
    }
}
