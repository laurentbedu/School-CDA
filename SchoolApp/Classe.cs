using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Classe
    {
        public int id_classe { get; set; }
        public string label { get; set; }
        public Professeur prof { get; set; }
        enum niveau
        {
            cp,
            ce1,
            ce2,
            cm1,
            cm2
        }
        List<Eleve> listEleves = new List<Eleve>();
        public void AddProfesseur(Professeur prof)
        {
            if (Professeur != prof)
            {
                Professeur = prof;
                if (prof.Classe != this)
                {
                    prof.AddClasse(this);
                }
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (Professeur == prof)
            {
                Professeur = null;
                if (prof.Classe == this)
                {
                    prof.RemoveClasse(this);
                }
            }
        }
        public override string ToString()
        {
            return label;
        }
    }
}
