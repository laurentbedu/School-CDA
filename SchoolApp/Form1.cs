using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using System.Windows.Forms;
using SchoolApp.DAL;
using SchoolApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            niveauList = new List<Niveau>
            {
                new Niveau() { label = "CP", id = "niveau_1" },
                new Niveau() { label = "CE1", id = "niveau_2" },
                new Niveau() { label = "CE2", id = "niveau_3" },
                new Niveau() { label = "CM1", id = "niveau_4" },
                new Niveau() { label = "CM2", id = "niveau_5" }
            };

            matiereList = new List<Matiere> {
                new Matiere() {label = "Mathématique", id = "matiere_1"},
                new Matiere() {label = "Français", id = "matiere_2"},
                new Matiere() {label = "Anglais", id = "matiere_3"},
                new Matiere() {label = "Sciences", id = "matiere_4"},
                new Matiere() {label = "Histoire", id = "matiere_5"},
                new Matiere() {label = "Géographie", id = "matiere_6"}
            };

            /*
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\Matiere.json";
            string jsonString = JsonSerializer.Serialize(matiereList);
            File.WriteAllText(fileName, jsonString);
            */

            niveauList.Find(e => e.label == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.label == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.label == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.label == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.label == "CM2")?.AddMatiere(matiereList.ToArray());

            comboBoxNiveauClasse.DataSource = niveauList;

            var jsonClasse = new DAL.JsonDataManager<Classe>();
            List<Classe> classes = jsonClasse.DataList;
            comboBoxClasseProf.DataSource = classes.ToArray();
            comboBoxClasseEleve.DataSource = classes.ToArray();

            var jsonProf = new DAL.JsonDataManager<Professeur>();
            List <Professeur> professeurs = jsonProf.DataList;
            comboBoxProfClasse.DataSource = professeurs.ToArray();

            var jsonEleve = new DAL.JsonDataManager<Eleve>();
            List<Eleve> eleves = jsonEleve.DataList;
            comboBoxEleveClasse.DataSource = eleves.ToArray();
        }

        readonly List<Niveau> niveauList = new();
        readonly List<Matiere> matiereList = new();

        //List<Professeur> professeurs = new List<Professeur>();
        Professeur professeur;
        private void ButtonCreerProf_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Professeur>();
            List<Professeur> professeurs = jsonVar.DataList;
            professeur = new Professeur()
            {
                nom = textBoxNomProf.Text,
                prenom = textBoxPrenomProf.Text,
                Login = textBoxLoginProf.Text,
                password = textBoxPasswordProf.Text,
                isAdmin = checkBoxAdminProf.Checked
            };

            professeurs.Add(professeur);
            MessageBox.Show(professeur+"");
            comboBoxProfClasse.DataSource = professeurs.ToArray();
            jsonVar.WriteJsonData(professeurs);
        }

        //List<Classe> classes = new List<Classe>();
        Classe classe;
        private void ButtonCreerClasse_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Classe>();
            List<Classe> classes = jsonVar.DataList;
            classe = new Classe()
            {
                label = comboBoxNiveauClasse.SelectedItem + " - " + textBoxNomClasse.Text,
                //niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            classes.Add(classe);
            MessageBox.Show(classe+"");
            comboBoxClasseProf.DataSource = classes.ToArray();
            comboBoxClasseEleve.DataSource = classes.ToArray();
            jsonVar.WriteJsonData(classes);
        }

        private void ButtonAddProf_Click(object sender, EventArgs e)
        {
            classe = comboBoxClasseProf.SelectedItem as Classe;
            classe.AddProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur+"");
        }

        private void ButtonRemoveProf_Click(object sender, EventArgs e)
        {
            classe = comboBoxClasseProf.SelectedItem as Classe;
            classe.RemoveProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur + "");
        }

       //List<Eleve> eleves = new List<Eleve>();
        Eleve eleve;
        private void ButtonCreerEleve_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Eleve>();
            List<Eleve> eleves = jsonVar.DataList;
            eleve = new Eleve()
            {
                nom = textBoxNomEleve.Text,
                prenom = textBoxPrenomEleve.Text,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value),
                classe = comboBoxClasseEleve.SelectedItem as Classe
            };
            eleves.Add(eleve);
            MessageBox.Show(eleve + "");
            comboBoxEleveClasse.DataSource = eleves.ToArray();
            jsonVar.WriteJsonData(eleves);

        }

        private void ButtonAddEleveClasse_Click(object sender, EventArgs e)
        {
            eleve = comboBoxEleveClasse.SelectedItem as Eleve;
            eleve.classe = comboBoxClasseEleve.SelectedItem as Classe;
            MessageBox.Show(eleve.classe + "");
        }

        private void ButtonRemoveEleveClasse_Click(object sender, EventArgs e)
        {
            eleve = comboBoxEleveClasse.SelectedItem as Eleve;
            eleve.classe = null;
            MessageBox.Show(eleve.classe + "");

        }
    }
}