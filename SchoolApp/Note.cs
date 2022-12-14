using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Note
    {
        public string Id_Note { get; set; }

        public double Valeur { get; set; }

        private Eleve? eleve;

        public Eleve? Eleve
        {
            get => eleve;
            set
            { 
                if (eleve!= value)
                {
                    eleve?.RemoveNote(this);
                    eleve = value;
                    eleve?.AddNote(this);
                }
            
            }
        }

        private Matiere? matiere;

        public Matiere? Matiere
        {
            get => matiere;
            set
            {
                if (matiere != value)
                {
                    matiere?.RemoveNote(this);
                    matiere = value;
                    matiere?.AddNote(this);
                }

            }
        }






    }
}
