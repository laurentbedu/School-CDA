using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal class Classe
    {
        public string id { get; set; }
        public string label { get; set; }
        enum niveau
        {
            cp,
            ce1,
            ce2,
            cm1,
            cm2
        }
        List<Eleve> listEleves = new List<Eleve>();
        public Professeur? Professeur { get; set; }

        public Classe()
        {
            id = IdGenerator.Create(this);
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
            return "Classe : "+ label +" "+ Professeur;
        }
    }
}
