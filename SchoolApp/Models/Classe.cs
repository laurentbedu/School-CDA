using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SchoolApp.DAL;
using SchoolApp.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp.Models
{
    internal class Classe :Model
    {
        public string Label { get; set; }

        public Classe()
        {
            Id = IdGenerator.Create(this);
        }

        public string? niveau_id { get; set; }
        [JsonIgnore]
        public Niveau? Niveau
        {
            get
            {
                var jdm = new JsonDataManager<Niveau>();
                return jdm.GetById(niveau_id);
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
                niveau_id = value?.Id;
            }
        }

        public string? professeur_id { get; set; }
        [JsonIgnore]
        public Professeur? Professeur
        { 
            get
            {
                var jdm = new JsonDataManager<Professeur>();
                return jdm.GetById(professeur_id);
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
                professeur_id = value?.Id;
            }
        }

        public void AddProfesseur(Professeur professeur)
        {
            if (professeur.Id != professeur_id)
            {
                professeur_id = professeur.Id;

                if (professeur.Classe != this)
                {
                    professeur_id = professeur.Id;
                    professeur.AddClasse(this);
                }
            }
        }

        public void RemoveProfesseur(Professeur professeur)
        {
            if (Professeur == professeur)
            {
                Professeur = null;
                professeur_id = null;

                if (professeur.Classe == this)
                {
                    professeur.RemoveClasse(this);
                }
            }
        }

        public override string ToString()
        {
            var jdm = new JsonDataManager<Niveau>(); 
            return jdm.GetById(niveau_id) + " - "+ Label;
        }
    }
}
