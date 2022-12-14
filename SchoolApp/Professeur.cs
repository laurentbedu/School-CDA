using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolApp
{
    internal class Professeur : Personne
    {
        public Professeur()
        {
            id = ++lastNumber + "";
        }

        public string Login { get; set; }

        public string Password { get; set; }

        private static int lastNumber = 0;

        public string id;
        public string Id
        {
            get
            {
                return "P" + id.PadLeft(9, '0');
            }
        }

        public override string ToString()
        {
            return Id + " " + Nom + " " +Prenom;
        }

    }
}
