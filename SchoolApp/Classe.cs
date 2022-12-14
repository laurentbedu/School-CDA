using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp
{
    internal class Classe
    {
        // Attributs :
        private string id   = "Id non défini";
        private string nom  = "Nom non défini";
        private Professeur professeur;
        private List<Eleve> listeEleves;

        // Propriétés :
        public string Id                { get { return id; }                                            }
        public string Nom               { get { return nom; }           set { nom = value; }            }
        public Professeur Professeur    { get { return professeur; }    set { professeur = value; }     }
        public List<Eleve> ListeEleves  { get { return listeEleves; }                                   }

        // Constructeurs :
        public Classe(string nomClasse)
        {
            listeEleves     = new List<Eleve>();
            this.nom        = nomClasse;
            this.id = generateId();
        }

        // Methodes :
        public string generateId()
        {
            Random rnd = new Random();
            return DateTime.Now.ToString("yyMMddHHmmssff") + "-" + rnd.Next(1, 999);
        }

        // ToString Override
        public override string ToString()
        {
            return  "Classe: " +nom+
                    "\nProfesseur: " +professeur+ ")"+
                    "\nListe des eleves: " +ListeEleves+ ")";
        }
    }
}
