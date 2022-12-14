using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Eleve : Personne
    {
        public string[] niveau = new string[] { "CP", "CE1", "CE2", "CM1", "CM2" };

        public List<int> NotesEleve = new List<int>();

        public int Id { get; set; }

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
