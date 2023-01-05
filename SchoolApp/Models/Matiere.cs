using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Matiere : Model
    {
        // Propriétés :
        [JsonPropertyName("label")] public string label { get; set; }
        [NePasIntegrerDansToString][JsonIgnore] public List<Niveau> ListeNiveaux { get; private set; } = new List<Niveau>();

        // Méthodes :
        public void ajouterNiveau(params Niveau[] niveaux)
        {
            ListeNiveaux.AddRange(niveaux);
            foreach (Niveau niveau in niveaux)
            {
                if (!niveau.ListeMatieres.Contains(this))
                {
                    niveau.ajouterMatiere(this);
                }
            }
        }
        public void retirerNiveau(params Niveau[] niveaux)
        {
            ListeNiveaux.RemoveAll(e => niveaux.Contains(e));
            foreach (Niveau niveau in niveaux)
            {
                if (niveau.ListeMatieres.Contains(this))
                {
                    niveau.retirerMatiere(this);
                }
            }
        }






        public override string ToString()
        {
            return label;
        }

    }
}
