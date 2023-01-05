using SchoolApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Professeur : Personne
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }

        public string? classe_id { get; set; }
        [JsonIgnore]
        public Classe? Classe
        {
            get
            {
                var jdm = new JsonDataManager<Classe>();
                return jdm.GetById(classe_id);
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
                classe_id = value?.Id;
            }
        }

        public void AddClasse(Classe classe)
        {
            if (classe.Id != classe_id)
            {
                Classe = classe;
                classe_id = classe.Id;

                if (classe.Professeur != this)
                {
                    Classe = classe;
                    classe_id = classe.Id;
                    classe.AddProfesseur(this);
                }
            }
        }
        public void RemoveClasse(Classe classe)
        {
            if (classe.Id == classe_id)
            {
                classe_id = null;
                Classe = null;
                if (classe.professeur_id == this.Id)
                {
                    classe_id = null;
                    Classe = null;
                    classe.RemoveProfesseur(this);
                }
            }
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
