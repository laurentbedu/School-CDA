using SchoolApp.Attributes;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Niveau : Model
    {
        public string Label { get; set; }

        [IsNotInToString]
        public List<Matiere> MatiereList { get; private set; } = new List<Matiere>();

        public void AddMatieres(params Matiere[] matieres)
        {
            MatiereList.AddRange(matieres);
            foreach (Matiere matiere in matieres)
            {
                if (!matiere.NiveauList.Contains(this))
                {
                    matiere.AddNiveaux(this);
                }
            }
        }

        public void RemoveMatieres(params Matiere[] matieres)
        {
            MatiereList.RemoveAll(e => matieres.Contains(e));
            foreach (Matiere matiere in matieres)
            {
                if (matiere.NiveauList.Contains(this))
                {
                    matiere.RemoveNiveaux(this);
                }
            }
        }

        public override string ToString()
        {
            return Label;
        }
    }
}