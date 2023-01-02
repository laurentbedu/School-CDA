using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Classe : ModelBase
    {
        
        public string Label_Classe { get; set; }


       
        public List<Eleve> EleveList { get; set; } = new List<Eleve>();


        public void AddEleve(Eleve eleve)
        {
            if (!EleveList.Contains(eleve))
            {
                EleveList.Add(eleve);
            }
            if (eleve.Classe != this)
            {
                eleve.Classe = this;
            }
        }

        public void RemoveEleve(Eleve eleve)
        {
            if (eleve != null && EleveList.Contains(eleve))
            {
                EleveList.Remove(eleve);
                if (eleve.Classe == this)
                {
                    eleve.Classe = null;
                }
            }
        }

        private Niveau? niveau;

        public Niveau? Niveau
        {
            get => niveau;
            set
            {
                if (niveau != value)
                {
                    niveau?.RemoveClasse(this);
                    niveau = value;
                    niveau?.AddClasse(this);
                }
            }
        }


        [IsNotInToStringAttribute]
        public Professeur? Professeur { get; private set; }

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

      

    }
}
