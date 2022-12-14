using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Matiere
    {
        public string id { get; set; }
        public string label { get; set; }

        public Matiere()
        {
            id = IdGenerator.Create(this);
        }
    }
}
