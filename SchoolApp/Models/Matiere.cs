﻿using SchoolApp.Attributes;
using System.Runtime.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Matiere : Model
    {
        [DataMember(Name = "label")]
        public string Label { get; set; }

        [IsNotInToString]
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
