using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp.Models
{
    internal class Classe : Model
    {
        public string? Nom { get; set; }
        public Niveau? Niveau { get; set; }

        [NePasIntegrerDansToString] public Professeur? Professeur { get; private set; }
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

        [NePasIntegrerDansToString] public List<Eleve> EleveList { get; } = new List<Eleve>();
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
