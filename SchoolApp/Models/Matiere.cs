using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Matiere : Model
    {
        public string Label { get; set; }

        public List<Niveau> NiveauList { get; private set; } = new List<Niveau>();

        public void AddNiveaux(params Niveau[] niveaux)
        {
            NiveauList.AddRange(niveaux);
            foreach (Niveau niveau in niveaux)
            {
                if (!niveau.MatiereList.Contains(this))
                {
                    niveau.AddMatieres(this);
                }
            }
        }

        public void RemoveNiveaux(params Niveau[] niveaux)
        {
            NiveauList.RemoveAll(e => niveaux.Contains(e));
            foreach (Niveau niveau in niveaux)
            {
                if (niveau.MatiereList.Contains(this))
                {
                    niveau.RemoveMatieres(this);
                }
            }
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
