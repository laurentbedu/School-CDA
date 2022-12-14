using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Classe
    {
        public string Id_Classe { get; set; }

        public string Label_Classe { get; set; }


        public List<Eleve> EleveList { get; set; } = new List<Eleve>();


        public void AddEleve(Eleve eleve)
        {
            if (!EleveList.Contains(eleve))
            {
                EleveList.Add(eleve);
            }
            if (eleve.Classe != this) 
            {
                eleve.Classe = this;
            }
        }

        public void RemoveEleve(Eleve eleve)
        {
            if (eleve != null && EleveList.Contains(eleve))
            {
                EleveList.Remove(eleve);
                if (eleve.Classe == this) 
                {
                    eleve.Classe = null;
                }
            }
        }



        


    }
}
