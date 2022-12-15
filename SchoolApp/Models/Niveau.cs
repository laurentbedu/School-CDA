using SchoolApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Niveau : Model
    {
        public List<Matiere> matiereList;

        public void AddMatiere(params Matiere[] matiere)
        {
            this.matiereList.AddRange(matiere);
        }
    }
}
