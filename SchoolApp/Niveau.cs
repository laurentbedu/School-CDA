using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Niveau
    {
        public string Id_Niveau { get; set; }

        public string Label_Niveau { get; set; }

        public List<Classe> ClasseList { get; set; } = new List<Classe>();

        public void AddClasse(Classe classe)
        {
            ClasseList.Add(classe);
        }

        public void RemoveClasse(Classe classe)
        {
            ClasseList.Remove(classe);
        }

    }

    

    /*public enum Niveau
    {
        CP, CE1, CE2, CM1, CM2
    }*/
}
