using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Note
    {
        public string id { get; set; }
        public double valeur { get; set; }
        public Matiere matiere { get; set; }

        public Note()
        {
            id = IdGenerator.Create(this);
        }
    }
}
