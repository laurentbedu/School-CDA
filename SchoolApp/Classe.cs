using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Classe
    {
        public List<Eleve> ListeEleve;


       public void AjouterEleves(Eleve eleve)
        {
            ListeEleve.Add(eleve);
        }
    }
}
