using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Eleve : Personne
    {
        public Eleve()
        {
            Identifiant = ++id;
        }
        public int id = 0;
        public List<int> NotesEleve = new List<int>();

        public int Identifiant { get; set; }

        public void AjouterNotes(int note)
        {
            NotesEleve.Add(note);
        }

        public override string ToString()
        {
            return NotesEleve.Count.ToString();
        }
    }
}
