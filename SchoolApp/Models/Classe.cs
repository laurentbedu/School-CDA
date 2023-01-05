using SchoolApp.Attributes;
using SchoolApp.DAL;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace SchoolApp.Models
{
    internal class Classe : Model
    {
        [JsonPropertyName("label")] public string? Label { get; set; }
        [JsonPropertyName("niveau_id")] public string? niveauId { get; set; }
        [JsonPropertyName("professeur_id")] public string? professeurId { get; set; }
        [JsonIgnore][NePasIntegrerDansToString] public Professeur? Professeur
        {
            get
            {
                var jdm = new JsonDataManager<Professeur>();
                return jdm.GetById(professeurId);
            }
            set
            {
                niveauId = value?.Id;
            }
        }
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
                //professeurId = professeur.Id;
                if (professeur.Classe != this)
                {
                    professeurId = professeur.Id;
                    professeur.ajouterClasse(this);                    
                }
            }
        }
        public void retirerProfesseur(Professeur professeur)
        {
            if (Professeur == professeur)
            {
                Professeur = null;
                professeurId =null;
                if (professeur.Classe == this)
                {
                    professeur.retirerClasse(this);
                    professeurId = null;
                }
            }
        }

        public void AddEleve(Eleve eleve)
        {
            if (!EleveList.Contains(eleve))
            {
                EleveList.Add(eleve);
                eleve.classeId = this.Id;
            }
            if (eleve.Classe != this)
            {
                eleve.Classe = this;
                eleve.classeId = this.Id;
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
        // ToString Override
        public override string ToString()
        {
            return Label;
        }
    }
}
