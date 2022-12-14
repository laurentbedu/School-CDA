using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Tools;

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
