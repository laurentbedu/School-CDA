using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Note : Model
    {
        // Attributs :
        private Eleve? eleve;

        // Propriétés :
        public double? Valeur { get; set; }
        public Matiere? Matiere { get; set; }
        public Eleve? Eleve
        {
            get => eleve;
            set
            {
                if (eleve != value)
                {
                    eleve?.supprimerNote(this);
                    eleve = value;
                    eleve?.ajouterNote(this);
                }
            }
        }
        // Constructeurs :
        public Note()
        {

        }
    }
}
