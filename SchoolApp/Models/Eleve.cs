using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Eleve : Personne
    {
        
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
