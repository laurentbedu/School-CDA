using SchoolApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Niveau : Model
    {
        public List<Matiere> matiereList { get; private set; } = new();

        public void AddMatiere(params Matiere[] matieres)
        {
            matiereList.AddRange(matieres);
            foreach (Matiere matiere in matieres)
            {
                if (!matiere.niveauList.Contains(this))
                {
                    matiere.AddNiveau(this);
                }
            }
        }
        public void RemovedMatiere(Matiere matiere)
        {
            if (!matiereList.Contains(matiere))
            {
                matiereList.Remove(matiere);
            }
        }

        public override string ToString()
        {
            return label;
        }
    }
}
