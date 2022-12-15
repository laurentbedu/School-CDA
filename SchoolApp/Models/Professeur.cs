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
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool? IsAdmin { get; }

        public enum classe
        {
            CP, CE1, CE2, CM1, CM2
        }
       
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
