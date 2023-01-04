﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SchoolApp.Tools;

namespace SchoolApp.Models
{
    internal class Matiere : Model
    {
        public string Label { get; set; }
        [JsonPropertyName("niveau_id")]
        public List<Niveau> niveauList { get; private set; } = new List<Niveau>();

        public void AddNiveau(params Niveau[] niveaux)
        {
            niveauList.AddRange(niveaux);
            foreach (Niveau niveau in niveaux)
            {
                if (!niveau.matiereList.Contains(this))
                {
                    niveau.AddMatiere(this);
                }
            }
        }
            public override string ToString()
        {
            return Label;
        }
    
    }
}
