using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Niveau : Model
    {
        // Propriétés :
        [JsonPropertyName("niveau_id")] public string Label { get; set; }
        [NePasIntegrerDansToString][JsonIgnore] public List<Matiere> ListeMatieres { get; private set; } = new List<Matiere>();

        // Methodes :
        public void ajouterMatiere(params Matiere[] matieres)
        {
            ListeMatieres.AddRange(matieres);
            foreach (Matiere matiere in matieres)
            {
                if (!matiere.ListeNiveaux.Contains(this))
                {
                    matiere.ajouterNiveau(this);
                }
            }
        }
        public void retirerMatiere(params Matiere[] matieres)
        {
            ListeMatieres.RemoveAll(e => matieres.Contains(e));
            foreach (Matiere matiere in matieres)
            {
                if (matiere.ListeNiveaux.Contains(this))
                {
                    matiere.retirerNiveau(this);
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
