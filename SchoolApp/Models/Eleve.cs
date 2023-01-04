using SchoolApp.Attributes;
using System.Runtime.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Eleve : Personne
    {
        [DataMember(Name = "anciennete")]
        public int Anciennete { get; set; }

        private Classe? classe;
        public Classe? Classe
        {
            get => classe;
            set
            {
                if (classe != value)
                {
                    classe?.RemoveEleve(this);
                    classe = value;
                    classe?.AddEleve(this);
                }
            }
        }

        [IsNotInToString]
        public List<Note> NoteList { get; } = new List<Note>();

        public void AddNote(Note note)
        {
            if (!NoteList.Contains(note))
            {
                NoteList.Add(note);
            }
            if (note.Eleve != this)
            {
                note.Eleve = this;
            }

        }

        public void RemoveNote(Note note)
        {
            if (note != null && NoteList.Contains(note))
            {
                NoteList.Remove(note);
                if (note.Eleve == this)
                {
                    note.Eleve = null;
                }
            }
        }
    }
}
