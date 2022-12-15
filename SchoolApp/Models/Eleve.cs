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
        private Classe? classe;

        // Propriétés :
        public string? Anciennete { get; set; }
        public List<Note> listeNotes { get; } = new List<Note>();
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
        public List<Note> ListeNotes { get { return listeNotes; } }

        // Constructeurs :
        public Eleve(string nom, string prenom, string anciennete) : base(nom, prenom)
        {
            listeNotes = new List<Note>();
            this.Anciennete = anciennete;
        }
        public Eleve(string nom, string prenom) : base(nom, prenom)
        {
            listeNotes = new List<Note>();
        }

        // Methodes :
        public void ajouterNote(Note noteToAdd)
        {
            if (!listeNotes.Contains(noteToAdd))
            {
                listeNotes.Add(noteToAdd);
            }
            if (noteToAdd.Eleve != this)
            {
                noteToAdd.Eleve = this;
            }
        }
        public void supprimerNote(Note noteToRemove)
        {
            if (noteToRemove != null && listeNotes.Contains(noteToRemove))
            {
                listeNotes.Remove(noteToRemove);
                if (noteToRemove.Eleve == this)
                {
                    noteToRemove.Eleve = null;
                }
            }
        }
        public string ToStringPourSave()
        {
            if (Classe?.Id != null)
            {
                return Nom + " " + Prenom + " " + Anciennete + " " + base.Id + " " + Classe.Id;
            }
            else
            {
                return Nom + " " + Prenom + " " + Anciennete + " " + base.Id + " " + "PasDeClasseId";
            }
        }

    }
}
