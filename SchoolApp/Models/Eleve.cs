using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Eleve : Personne
    {
        [JsonIgnore]
        public int anciennete { get; set; }
        [JsonPropertyName("classe_id")]
        private Classe? classe;
        public Classe? Classe
        {
            get => classe;
            set
            {
                if (classe != value)
                {
                    classe = value;
                }
            }
        }

        List<Note> notes = new();      

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
            return Nom + " " + Prenom;
        }
    }
}
