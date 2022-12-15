using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal class Classe :Model
    {
        public Niveau niveau { get; set; }
        public List<Eleve> listEleves = new List<Eleve>();
        public Professeur? Professeur { get; set; }


        public void AddProfesseur(Professeur professeur)
        {
            if (Professeur != professeur)
            {
                Professeur = professeur;
                if (professeur.Classe != this)
                {
                    professeur.AddClasse(this);
                }
            }
        }

        public void RemoveProfesseur(Professeur professeur)
        {
            if (Professeur == professeur)
            {
                Professeur = null;
                if (professeur.Classe == this)
                {
                    professeur.RemoveClasse(this);
                }
            }
        }
        public void AddEleve(Eleve eleve)
        {
            if (!listEleves.Contains(eleve))
            {
                listEleves.Add(eleve);
            }
        }

        public void RemoveEleve(Eleve eleve)
        {
            if (listEleves.Contains(eleve))
            {
                listEleves.Remove(eleve);
            }
        }

        public override string ToString()
        {
            return "Classe : "+ label;
        }
    }
}
