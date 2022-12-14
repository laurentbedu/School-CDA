using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Note
    {
        public string id_note;
        public double valeur;
        public Matiere matiere;
        
        public Note(string id_note,double valeur, Matiere matiere)
        {
            this.id_note = id_note;
            this.valeur = valeur;
            this.matiere = matiere;
        }
    }
}
