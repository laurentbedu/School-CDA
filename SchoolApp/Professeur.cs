using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class Professeur : Personne
    {
        public int id_prof { get; set; }
        public Classe classe { get; set; }
        public string login { get; set; }
        public string password { get; set; }



        public void addClasse(Classe classe)
        {
            if (!Professeur.Contains(classe))
            {
                Professeur.Add(classe);
            }
        }
        public void removeClasse(Classe classe) 
        {
            if (!Professeur.Contains(classe))
            {
                Professeur.Remove(classe);
            }
        }
        public void creerPassword() {

        }
        public void modifierPassword()
        {

        }
        public override string ToString()
        {
            return "Professeur : "+nom+" "+prenom+" - Classe : "+classe;
        }
    }
}
