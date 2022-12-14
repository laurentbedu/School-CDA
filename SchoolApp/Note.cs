using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Note
    {
        // Attributs :
        private string id       = "Id non défini";
        private double valeur   = -1;
        private Eleve eleve;
        private Matiere matiere;

        // Propriétés :
        public string Id        {   get { return id;      }   set { id = value;         }   }
        public double Valeur    {   get { return valeur;  }   set { valeur = value;     }   }
        public Eleve Eleve      {   get { return eleve;   }   set { eleve = value;      }   }
        public Matiere Matiere  {   get { return matiere; }   set { matiere = value;    }   }

        // Constructeurs :
        public Note(Eleve eleve, Matiere matiere, int valeur)
        {
            this.matiere    = matiere;
            this.eleve      = eleve;
            this.valeur     = valeur;
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
            return "Note= " + valeur + "/20" + "(" + matiere + ")";
        }
    }
}
