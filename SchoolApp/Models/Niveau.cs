using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Niveau : ModelBase
    {
       
        public string Label_Niveau { get; set; }

        
        public List<Classe> ClasseList { get; set; } = new List<Classe>();

        public void AddClasse(Classe classe)
        {
            if (ClasseList.Contains(classe))
            {
                ClasseList.Add(classe);
            }
            if (classe.Niveau != this)
            {
                classe.Niveau = this;
            }
        }

        public void RemoveClasse(Classe classe)
        {
            if (classe != null && ClasseList.Contains(classe))
            {
                ClasseList.Remove(classe);
                if (classe.Niveau == this)
                {
                    classe.Niveau = null;
                }
            }
        }

        public List<Matiere> MatiereList { get; set; } = new List<Matiere>();

        public void AddMatiere(params Matiere[] matieres)
        {
            MatiereList.AddRange(matieres);
            foreach (Matiere matiere in matieres)
            {
                if (!matiere.NiveauList.Contains(this))
                {
                    matiere.AddNiveau(this);
                }
            }
        }

        public void RemoveMatiere(params Matiere[] matieres)
        {
            MatiereList.RemoveAll(e => matieres.Contains(e));
            foreach (Matiere matiere in matieres)
            {
                if (matiere.NiveauList.Contains(this))
                {
                    matiere.RemoveNiveau(this);
                }
            }
        }

        public override string ToString()
        {
            return Label_Niveau;
        }

    }



   
}
