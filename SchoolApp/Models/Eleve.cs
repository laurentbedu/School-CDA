using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Eleve : Personne
    {
        // Attributs :
        private string id = "Id non défini";
        private string anciennete = "Anciennété non définie";
        private Classe? classe;
        private List<Note> listeNotes;

        // Propriétés :
        public string Id { get { return id; } }
        public string Anciennete { get { return anciennete; } set { anciennete = value; } }
        public Classe? Classe { get { return classe; } set { classe = value; } }
        public List<Note> ListeNotes { get { return listeNotes; } }

        // Constructeurs :
        public Eleve(string nom, string prenom, string anciennete) : base(nom, prenom)
        {
            listeNotes = new List<Note>();
            this.anciennete = anciennete;
            id = generateId();
        }
        public Eleve(string nom, string prenom) : base(nom, prenom)
        {
            listeNotes = new List<Note>();
            id = generateId();
        }

        // Methodes :
        public void ajouterNote(Note noteToAdd)
        {
            ListeNotes.Add(noteToAdd);
        }
        public void supprimerNote(Note noteToRemove)
        {
            ListeNotes.Remove(noteToRemove);
        }

        // ToString Override
    }
}
