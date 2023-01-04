using SchoolApp.Attributes;
using SchoolApp.DAL;
using System.Text.Json.Serialization;


namespace SchoolApp.Models
{
    internal class Classe : Model
    {
        [JsonPropertyName("label")] public string? Label { get; set; }
        [JsonPropertyName("niveau_id")] public string? niveauId { get; set; }
        [JsonIgnore][NePasIntegrerDansToString] public Professeur? Professeur { get; private set; }
        [JsonIgnore][NePasIntegrerDansToString] public List<Eleve> EleveList { get; } = new List<Eleve>();
        [JsonIgnore] public Niveau? Niveau
        {
            get
            {
                var jdm = new JsonDataManager<Niveau>();
                return jdm.GetById(niveauId);
            }
            set
            {
                niveauId = value?.Id;
            }
        }

        ///////////////////////////////////////////////////////////
        public void ajouterProfesseur(Professeur professeur)
        {
            if (Professeur != professeur)
            {
                Professeur = professeur;
                if (professeur.Classe != this)
                {
                    professeur.ajouterClasse(this);
                }
            }
        }
        public void retirerProfesseur(Professeur professeur)
        {
            if (Professeur == professeur)
            {
                Professeur = null;
                if (professeur.Classe == this)
                {
                    professeur.retirerClasse(this);
                }
            }
        }

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
