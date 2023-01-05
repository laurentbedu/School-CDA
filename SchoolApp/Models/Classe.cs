using SchoolApp.Attributes;
using SchoolApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Classe : Model
    {
        public List<Eleve> EleveList { get; set; } = new List<Eleve>();

        public string IdentifiantClasse { get; set; }

        public string LabelClasse { get; set; }


        public Professeur? Professeur { get; private set; }

        //[DataMember(Name = "niveau_id")]
        ////[JsonPropertyName("niveau_id")]
        //private string? niveauId;

        //[JsonIgnore]

        public Eleve ? Eleve { get; set; }
        public Niveau? Niveau { get; set; }
//        {
//            get
//            {
//                var jdm = new JsonDataManager<Niveau>();
//                return jdm.GetById(niveauId);
//            };
//    set
//            {
//                if (value.Id != null)
//                {
//                    niveauId = value.Id;
//                }
//                else
//{
//    niveauId = null;
//}
//niveauId = value?.Id;
//            };
//        }

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

        
    }
}
