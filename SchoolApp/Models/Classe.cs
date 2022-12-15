using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{

    internal class Classe
    {
        public List<Eleve> EleveList { get; set; } = new List<Eleve>();

        public string IdentifiantClasse { get; set; }

        public string LabelClasse { get; set; }
        public Professeur? Professeur { get; private set; }

        public void AddEleve(Eleve eleve)
        {
            if (!EleveList.Contains(eleve))
            {
                EleveList.Add(eleve);
            }

        }
        public void RemoveEleve(Eleve eleve)
        {
            if (EleveList.Contains(eleve))
            {
                EleveList.Remove(eleve);
            }

        }
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

        public override string ToString()
        {
            string desc = "";
            GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(IsNotInToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");

            return desc;

        }
    }
}
