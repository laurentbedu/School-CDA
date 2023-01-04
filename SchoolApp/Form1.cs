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

            NiveauList = new List<Niveau>
            {
                new Niveau() { Label = "CP", Id = "niveau_1" },
                new Niveau() { Label = "CE1", Id = "niveau_2" },
                new Niveau() { Label = "CE2", Id = "niveau_3" },
                new Niveau() { Label = "CM1", Id = "niveau_4" },
                new Niveau() { Label = "CM2", Id = "niveau_5" }
            };

            
            /*
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\Niveau.json";
            string jsonString = JsonSerializer.Serialize(NiveauList);
            File.WriteAllText(fileName, jsonString);
            */
            

            MatiereList = new List<Matiere> {
                new Matiere() {Label = "Mathématique", Id = "matiere_1"},
                new Matiere() {Label = "Français", Id = "matiere_2"},
                new Matiere() {Label = "Anglais", Id = "matiere_3"},
                new Matiere() {Label = "Sciences", Id = "matiere_4"},
                new Matiere() {Label = "Histoire", Id = "matiere_5"},
                new Matiere() {Label = "Géographie", Id = "matiere_6"}
            };

            /*
            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\Matiere.json";
            string jsonString = JsonSerializer.Serialize(MatiereList);
            File.WriteAllText(fileName, jsonString);
            */

            NiveauList.Find(e => e.Label == "CP")?.AddMatiere(MatiereList[0], MatiereList[1]);
            NiveauList.Find(e => e.Label == "CE1")?.AddMatiere(MatiereList[0], MatiereList[1], MatiereList[2]);
            NiveauList.Find(e => e.Label == "CE2")?.AddMatiere(MatiereList[0], MatiereList[1], MatiereList[2], MatiereList[3]);
            NiveauList.Find(e => e.Label == "CM1")?.AddMatiere(MatiereList[0], MatiereList[1], MatiereList[2], MatiereList[3], MatiereList[4]);
            NiveauList.Find(e => e.Label == "CM2")?.AddMatiere(MatiereList.ToArray());

            comboBoxNiveauClasse.DataSource = NiveauList;

            var jsonClasse = new DAL.JsonDataManager<Classe>();
            List<Classe> classes = jsonClasse.DataList;
            classes = classes.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = classes;
            comboBoxClasseEleve.DataSource = classes;

            var jsonProf = new DAL.JsonDataManager<Professeur>();
            List <Professeur> professeurs = jsonProf.DataList;
            professeurs = professeurs.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = professeurs;

            var jsonEleve = new DAL.JsonDataManager<Eleve>();
            List<Eleve> eleves = jsonEleve.DataList;
            eleves = eleves.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = eleves;
        }

        readonly List<Niveau> NiveauList = new();
        readonly List<Matiere> MatiereList = new();

        List<Professeur> professeurs = new List<Professeur>();
        Professeur professeur;
        private void ButtonCreerProf_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Professeur>();
            professeurs = jsonVar.DataList;
            string lastname = textBoxPrenomProf.Text;
            string _prenom = char.ToUpper(lastname[0]) + lastname[1..].ToLower();

            professeur = new Professeur()
            {
                Nom = textBoxNomProf.Text.ToUpper(),
                Prenom = _prenom,
                Login = textBoxLoginProf.Text,
                Password = textBoxPasswordProf.Text,
                IsAdmin = checkBoxAdminProf.Checked
            };

            professeurs.Add(professeur);
            MessageBox.Show(professeur+"");
            professeurs = professeurs.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = professeurs;
            jsonVar.SaveJsonData(professeurs);
        }

        List<Classe> classes = new List<Classe>();
        Classe classe;
        private void ButtonCreerClasse_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Classe>();
            classes = jsonVar.DataList;

            string nom = textBoxNomClasse.Text;
            string _nom = char.ToUpper(nom[0]) + nom[1..].ToLower();
            classe = new Classe()
            {
                Label = _nom,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            classes.Add(classe);
            MessageBox.Show(classe+"");
            classes = classes.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = classes;
            comboBoxClasseEleve.DataSource = classes;
            jsonVar.SaveJsonData(classes);
        }

        private void ButtonAddProf_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Classe>();
            classes = jsonVar.DataList;
            classe = comboBoxClasseProf.SelectedItem as Classe;
            classe.AddProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur+"");
            jsonVar.SaveJsonData(classes);

        }

        private void ButtonRemoveProf_Click(object sender, EventArgs e)
        {
            classe = comboBoxClasseProf.SelectedItem as Classe;
            classe.RemoveProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur + "");
        }

       List<Eleve> eleves = new List<Eleve>();
        Eleve eleve;
        private void ButtonCreerEleve_Click(object sender, EventArgs e)
        {
            var jsonVar = new DAL.JsonDataManager<Eleve>();
            eleves = jsonVar.DataList;
            string lastname = textBoxPrenomEleve.Text;
            string _prenom = char.ToUpper(lastname[0]) + lastname[1..].ToLower();
            eleve = new Eleve()
            {
                Nom = textBoxNomEleve.Text.ToUpper(),
                Prenom = _prenom,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value)
            };
            eleves.Add(eleve);
            MessageBox.Show(eleve + "");
            eleves = eleves.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = eleves;
            jsonVar.SaveJsonData(eleves);
        }

        private void ButtonAddEleveClasse_Click(object sender, EventArgs e)
        {
            eleve = comboBoxEleveClasse.SelectedItem as Eleve;
            eleve.Classe = comboBoxClasseEleve.SelectedItem as Classe;
            MessageBox.Show(eleve.Classe + "");
        }

        private void ButtonRemoveEleveClasse_Click(object sender, EventArgs e)
        {
            eleve = comboBoxEleveClasse.SelectedItem as Eleve;
            eleve.Classe = null;
            MessageBox.Show(eleve.Classe + "");

        }
    }
}