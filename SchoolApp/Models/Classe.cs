using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp.Models
{
    internal class Classe
    {
        // Attributs :
        private string id = "Id non défini";
        private string nom = "Nom non défini";
        private Professeur? professeur;
        private List<Eleve> listeEleves;

        // Propriétés :
        public string Id { get { return id; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public Professeur? Professeur { get { return professeur; } set { professeur = value; } }
        public List<Eleve> ListeEleves { get { return listeEleves; } }

        // Constructeurs :
        public Classe(string nomClasse)
        {
            listeEleves = new List<Eleve>();
            nom = nomClasse;
            id = Tools.IdGenerator.generateId(this);
        }

        // Methodes :
        public void ajouterProfesseur(Professeur professeur)
        {
            if (Professeur != professeur)
            {
                Professeur = professeur;
                if (professeur.Classe != this)
                {
                    professeur.retirerClasse(this);
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

        // ToString Override
        public override string ToString()
        {
            return Tools.UniversalToString.ToStringer(this);
        }
    }
}
