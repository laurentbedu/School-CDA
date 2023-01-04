using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Niveau> niveauList = new List<Niveau>()
           {
               new Niveau() { Label = "CP"},
               new Niveau() { Label = "CE1"},
               new Niveau() { Label = "CE2"},
               new Niveau() { Label = "CM1"},
               new Niveau() { Label = "CM2" }
            };

            List<Matiere> matiereList = new List<Matiere>
            {
                new Matiere() { Label = "Mathématique"},
                new Matiere() { Label = "Français"},
                new Matiere() { Label = "Anglais"},
                new Matiere() { Label = "Sciences"},
                new Matiere() { Label = "Histoire"},
                new Matiere() { Label = "Geographie"}

            };
            niveauList.Find(e => e.Label == "CP")?.AddMatieres(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.Label == "CE1")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.Label == "CE2")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.Label == "CM1")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.Label == "CM2")?.AddMatieres(matiereList.ToArray());
        }

        private void boxNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur()
            {
                Nom = boxNom.Text,
                Prenom = boxPrenom.Text,
                Login = boxLogin.Text,
                Password = boxPassword.Text,
            };

            if (checkAdmin.Checked) professeur.IsAdmin = true;
            else { professeur.IsAdmin = false;}

            MessageBox.Show(professeur + "");
        }
    }
}
