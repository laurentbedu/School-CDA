using SchoolApp.Attributes;
using SchoolApp.DAL;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Classe : Model
    {
        [DataMember(Name = "label")]
        public string? Label { get; set; }

        [IsNotInToString]
        public Professeur? Professeur { get; private set; }

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

        [DataMember(Name = "niveau_id")]
        //[JsonPropertyName("niveau_id")]
        private string? niveauId;

        [JsonIgnore]
        public Niveau? Niveau
        {
            get
            {
                var jdm = new JsonDataManager<Niveau>();
                return jdm.GetById(niveauId);
            }
            set
            {
                //if (value.Id != null)
                //{
                //    niveauId = value.Id;
                //}
                //else
                //{
                //    niveauId = null;
                //}
                niveauId = value?.Id;
            }
        }

        [IsNotInToString]
        public List<Eleve> EleveList { get; } = new List<Eleve>();

        public void AddEleve(Eleve eleve)
        {
            if (!EleveList.Contains(eleve))
            {
                EleveList.Add(eleve);
            }
            if (eleve.Classe != this)
            {
                eleve.Classe = this;
            }

        }

        public void RemoveEleve(Eleve eleve)
        {
            if (eleve != null && EleveList.Contains(eleve))
            {
                EleveList.Remove(eleve);
                if (eleve.Classe == this)
                {
                    eleve.Classe = null;
                }
            }
        }

    }
}
