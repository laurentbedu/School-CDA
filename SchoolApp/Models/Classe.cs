using SchoolApp.Attributes;

namespace SchoolApp.Models
{
    internal class Classe : Model
    {
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

        public Niveau? Niveau { get; set; }

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
