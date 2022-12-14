using SchoolApp.Attributes;

namespace SchoolApp.Models
{
    internal class Classe
    {
        public Classe()
        {
            Id = Tools.IdGenerator.Create(this);
        }

        public string Id { get; private set; }
        public string? Label { get; set; }

        [IsNotInToStringAttribute]
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

        public override string ToString()
        {
            string desc = "";
            GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(IsNotInToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");

            return desc;
        }
    }
}
