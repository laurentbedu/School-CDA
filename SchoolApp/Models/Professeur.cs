using SchoolApp.Attributes;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {
        public string? Login { get; set; }
        public string? Password { get; set; }

        public bool? IsAdmin { get; }


        [IsNotInToString]
        public Classe? Classe { get; private set; }
        public void AddClasse(Classe classe)
        {
            if (Classe != classe)
            {
                Classe = classe;
                if (classe.Professeur != this)
                {
                    classe.AddProfesseur(this);
                }
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (Classe == classe)
            {
                Classe = null;
                if (classe.Professeur == this)
                {
                    classe.RemoveProfesseur(this);
                }
            }
        }
    }
}
