using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.View
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();

            niveauList = new List<Niveau>
            {
                new Niveau() { Label_Niveau = "CP" },
                new Niveau() { Label_Niveau = "CE1"},
                new Niveau() { Label_Niveau = "CE2"},
                new Niveau() { Label_Niveau = "CM1"},
                new Niveau() { Label_Niveau = "CM2"}
            };
            matiereList = new List<Matiere> {
                new Matiere() {Label_Matiere = "Mathématique"},
                new Matiere() {Label_Matiere = "Français"},
                new Matiere() {Label_Matiere = "Anglais"},
                new Matiere() {Label_Matiere = "Sciences"},
                new Matiere() {Label_Matiere = "Histoire"},
                new Matiere() {Label_Matiere = "Géographie"}
            };
            niveauList.Find(e => e.Label_Niveau == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.Label_Niveau == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.Label_Niveau == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.Label_Niveau == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.Label_Niveau == "CM2")?.AddMatiere(matiereList.ToArray());

            comboBoxNiveauClasse.DataSource = niveauList;

        }

        List<Matiere> matiereList;

        Professeur? professeur;
        private void button1_Click(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                Nom = textBoxNomProf.Text,
                Prenom = textBoxPrenomProf.Text,
                Login = textBoxLogProf.Text,
                Password = textBoxPassProf.Text,
            };
            MessageBox.Show(professeur + "");
        }

        Eleve? eleve;
        private void buttonAddEl_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                Nom = textBoxNomEl.Text,
                Prenom = textBoxPrenomEl.Text,
            };
            MessageBox.Show(eleve + "");
        }        
        

        Classe? classe;
        List<Niveau> niveauList;
        private void button2_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                Label_Classe = textBoxNomClasse.Text,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            MessageBox.Show(classe + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.DataList;
            

            foreach (var item in list) { comboBox1.Items.Add(item.ToString()); }

            foreach (var item in list) { textBox1.Text += item.ToString() + " "; }

            foreach (var item in list) { listBox1.Items.Add(item.ToString()); }



            /*List<Niveau> ListeNiveau = new List<Niveau>();
            Niveau niveau1 = new Niveau() { Label_Niveau = "CP"};
            Niveau niveau2 = new Niveau() { Label_Niveau = "CE1" };
            Niveau niveau3 = new Niveau() { Label_Niveau = "CE2" };

            ListeNiveau.Add(niveau1);
            ListeNiveau.Add(niveau2);
            ListeNiveau.Add(niveau3);

            string jsonString = JsonSerializer.Serialize<List<Niveau>>(ListeNiveau)!;
            MessageBox.Show(jsonString);
            */


            bool stop = true;
        }
    }
}
