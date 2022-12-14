using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Eleve : Personne
    {
        public Eleve()
        {
            id = ++lastNumber + "";
        }

        public int Anciennete { get; set; }

        private static int lastNumber = 0;

        public string id;
        public string Id
        {
            get
            {
                return "E" + id.PadLeft(9, '0');
            }
        }

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

        
        public List<Note> NoteList { get; set; } = new List<Note>();

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


        





        public override string ToString()
        {
            return Id + " " + Nom + " " + Prenom;
        }

    }
}
