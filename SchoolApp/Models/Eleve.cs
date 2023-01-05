using SchoolApp.DAL;
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
        public int anciennete { get; set; }
        public string? classe_id { get; set; }
        [JsonIgnore]
        public Classe? Classe
        {
            get
            {
                var jdm = new JsonDataManager<Classe>();
                return jdm.GetById(classe_id);
            }
            set
            {
                // equivalent à :
                //if (value.Id != null)
                //{
                //    niveauId = value.Id;
                //}
                //else
                //{
                //    niveauId = null;
                //}
                classe_id = value?.Id;
            }
        }
        public void AddClasse(Classe classe)
        {
            if (classe.Id != classe_id)
            {
                Classe = classe;
                classe_id = classe.Id;
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (classe.Id == classe_id)
            {
                classe_id = null;
                Classe = null;
            }
        }

        List<Note> notes = new();      

        public void AddNote(Note note)
        {
            notes.Add(note);
        }
        public void RemoveNote(Note note)
        {
            notes.Remove(note);
        }
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
