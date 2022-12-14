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
        public Classe classe;

        List<Note> notes = new List<Note>();

        public Eleve(string nom, string prenom, Classe classe) {
            this.nom = nom;
            this.prenom = prenom;
            this.classe = classe;
        }
        public void ajouterNote(Note note)
        {
            this.notes.Add(note);
        }
        public override string ToString()
        {
            return "Eleve : "+nom+" "+prenom+" - Classe : "+classe;
        }
    }
}
