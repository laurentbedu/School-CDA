using SchoolApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Model
    {
        public string id { get; set; }
        public string label { get; set; }

        public Model()
        {
            id = IdGenerator.Create(this);
        }
    }
}
