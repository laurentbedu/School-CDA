using SchoolApp.DAL;
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
        [JsonIgnore] private Eleve? eleve;
        [JsonIgnore] private Matiere? matiere;
        // Propriétés :
        [JsonPropertyName("eleve_id")] public string? eleveId { get; set; }
        [JsonPropertyName("matiere_id")] public string? matiereId { get; set; }
        [JsonPropertyName("value")] public double? Valeur { get; set; }
        [JsonIgnore] public Matiere? Matiere 
        {
            get
            {
                var jdm = new JsonDataManager<Matiere>();
                return jdm.GetById(matiereId);
            }
            set
            {
                matiereId = value?.Id;
            } 
        }
        [JsonIgnore] public Eleve? Eleve
        {
            get
            {
                var jdm = new JsonDataManager<Eleve>();
                return jdm.GetById(eleveId);
            }
            set
            {
                if (eleve != value)
                {
                    eleve?.supprimerNote(this);
                    eleve = value;
                    eleve?.ajouterNote(this);
                    eleveId = value?.Id;
                }
            }
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
        // ToString Override
        public override string ToString()
        {
            return (Convert.ToString(Valeur)) +"/20.";
        }
    }
}
