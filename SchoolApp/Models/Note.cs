namespace SchoolApp.Models
{
    internal class Note
    {
        public double Valeur { get; set; }

        private Eleve? eleve;
        public Eleve? Eleve
        {
            get => eleve;
            set
            {
                if (eleve != value)
                {
                    eleve?.RemoveNote(this);
                    eleve = value;
                    eleve?.AddNote(this);
                }
            }
        }

        public Matiere Matiere { get; set; }
    }
}
