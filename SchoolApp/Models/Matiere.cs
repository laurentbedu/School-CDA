using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Matiere : ModelBase
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

        public List<Niveau> NiveauList { get; set;} = new List<Niveau>();

        public void AddNiveau(params Niveau[] niveaux)
        {
            NiveauList.AddRange(niveaux);
            foreach (Niveau niveau in niveaux)
            {
                if (!niveau.MatiereList.Contains(this))
                {
                    niveau.AddMatiere(this);
                }
            }
        }

        public void RemoveNiveau(params Niveau[] niveaux)
        {
            NiveauList.RemoveAll(e => niveaux.Contains(e));
            foreach (Niveau niveau in niveaux)
            {
                if (niveau.MatiereList.Contains(this))
                {
                    niveau.RemoveMatiere(this);
                }
            }
        }

        public override string ToString()
        {
            return Label_Matiere;
        }

    }
   
}
