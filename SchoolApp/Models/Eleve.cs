using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Eleve : Personne
    {
        public int anciennete { get; set; }
        public Classe classe { get; set; }

        List<Note> notes = new List<Note>();

        public void addNote(Note note)
        {
            notes.Add(note);
        }
        public void removeNote(Note note)
        {
            notes.Remove(note);
        }
        public override string ToString()
        {
            return nom + " " + prenom + " "+ anciennete+"ans";
        }
    }
}
