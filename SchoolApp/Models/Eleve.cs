using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Eleve : Personne
    {
        // Attributs :
        private Classe? classe;
        [JsonPropertyName("classe_id")] public string? classeId { get; set; }
        // Propriétés :    
        [JsonPropertyName("anciennete")] public int? Anciennete { get; set; }
        [JsonIgnore] public List<Note> listeNotes { get; } = new List<Note>();
        [JsonIgnore] public Classe? Classe 
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
        //public List<Note> ListeNotes { get { return listeNotes; } }

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
