using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Niveau
    {
       
        public string Label_Niveau { get; set; }

        
        public List<Classe> ClasseList { get; set; } = new List<Classe>();

        public void AddClasse(Classe classe)
        {
            if (ClasseList.Contains(classe))
            {
                ClasseList.Add(classe);
            }
            if (classe.Niveau != this)
            {
                classe.Niveau = this;
            }
        }

        public void RemoveClasse(Classe classe)
        {
            if (classe != null && ClasseList.Contains(classe))
            {
                ClasseList.Remove(classe);
                if (classe.Niveau == this)
                {
                    classe.Niveau = null;
                }
            }
        }



   


    }



    /*public enum Niveau
    {
        CP, CE1, CE2, CM1, CM2
    }*/
}
