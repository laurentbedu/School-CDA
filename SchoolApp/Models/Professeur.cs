using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {
        // Propriétés :
        public bool IsAdmin { get; set; }
        [JsonPropertyName("classe_id")] public string? classeId { get; set; }
        [NePasIntegrerDansToStringAttribute] public string Login { get; set; }
        [NePasIntegrerDansToStringAttribute] public string Password { get; set; }
        [NePasIntegrerDansToStringAttribute][JsonIgnore] public Classe? Classe { get; private set; }

        // Methodes :
        public void ajouterClasse(Classe classe)
        {
            if (Classe != classe)
            {
                Classe = classe;
                classeId = classe.Id;
                if (classe.Professeur != this)
                {
                    classeId = classe.Id;
                    classe.ajouterProfesseur(this);
                }
            }
        }
        public void retirerClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.retirerProfesseur(this);
                    classeId = null;
                }
            }
        }
        // ToString Override
        public override string ToString()
        {
            return base.Nom + " " + base.Prenom;
        }
    }
}
