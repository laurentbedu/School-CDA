using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Note : Model, INotifyPropertyChanged
    {
        // Attributs :
        private Eleve? eleve;

        // Propriétés :
        public double? Valeur { get; set; }
        [JsonIgnore] public Matiere? Matiere { get; set; }
        [JsonIgnore] public Eleve? Eleve
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

        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                
            }

            remove
            {
                
            }
        }
        
    }
}
