using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Eleve : Personne
    {
        public int anciennete = 0;
        public int id_eleve;

        List<Note> notes = new List<Note>();

        public Eleve(string nom, string prenom) {
            this.nom = nom;
            this.prenom = prenom;
        }
        public void ajouterNote(Note note)
        {
            this.notes.Add(note);
        }
    }
}
