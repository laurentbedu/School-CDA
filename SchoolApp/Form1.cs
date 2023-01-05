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

            cbBoxNiveau.DataSource = niveauList;

           
        }

        private void boxNom_TextChanged(object sender, EventArgs e)
        {
            
        }
        Professeur? professeur;
        private void button1_Click(object sender, EventArgs e)
        {
             professeur = new Professeur()
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
        Eleve eleve;
        private void button2_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()

            {
                Nom = boxNomEleve.Text,
                Prenom = boxPrenomEleve.Text,
                Anciennete = (int)numAnciennete.Value,
                
            };
            MessageBox.Show(eleve + "");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Classe? classe;
        
        private void button3_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                LabelClasse = boxLabelClasse.Text,
                
                Niveau = cbBoxNiveau.SelectedItem as Niveau,
            };
            MessageBox.Show(classe + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(classe);
            MessageBox.Show(professeur + "\n" + professeur.Classe?.ToString(true));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(professeur);
            MessageBox.Show(classe + "\n" + classe.Professeur?.ToString(true));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            classe.RemoveEleve(eleve);
            MessageBox.Show(classe + "\n" + classe.Eleve?.ToString(true));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            classe.AddEleve(eleve);
            listBox1.Items.Add(eleve);
            MessageBox.Show(classe + "\n" + classe.Eleve?.ToString(true));

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
         //   foreach (var item in classe.EleveList) { cbListeEleve.Items.Add(item.ToString()); }
            
        }

        private void boxLabelClasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxNomEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Eleve>();
            List<Eleve> listEleve = jsonDataManager.DataList;
        }
    }
}
