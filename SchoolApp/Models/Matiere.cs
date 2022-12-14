using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Matiere
    {
       
        public string Label_Matiere { get; set; }


       
        public List<Note> NoteList { get; set; } = new List<Note>();

        public void AddNote(Note note)
        {
            if (!NoteList.Contains(note))
            {
                NoteList.Add(note);
            }
            if (note.Matiere != this)
            {
                note.Matiere = this;
            }
        }

        public void RemoveNote(Note note)
        {
            if (note != null && NoteList.Contains(note))
            {
                NoteList.Remove(note);
                if (note.Matiere == this)
                {
                    note.Matiere = null;
                }
            }
        }

   


    }


    /*public enum Matiere
    {
        français, mathématiques, anglais, histoire, physique
    }*/
}
