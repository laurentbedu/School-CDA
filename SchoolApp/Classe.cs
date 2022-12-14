using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Classe
    {
        public int id_classe;
        public string label;
        public Professeur prof;
        public Niveau niveau;
        List<Eleve> listEleves = new List<Eleve>();

        public override string ToString()
        {
            return label;
        }
    }
}
