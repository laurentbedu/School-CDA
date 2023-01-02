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

            string fileName = "C:\\Users\\Nicolas\\Source\\Repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\Matiere.json";
            string jsonString = JsonSerializer.Serialize(matiereList);
            File.WriteAllText(fileName, jsonString);

            niveauList.Find(e => e.label == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.label == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.label == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.label == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.label == "CM2")?.AddMatiere(matiereList.ToArray());

            comboBoxNiveauClasse.DataSource = niveauList;
        }
        
        List<Niveau> niveauList = new List<Niveau>();
        List<Matiere> matiereList = new List<Matiere>();

        //List<Professeur> professeurs = new List<Professeur>();
        Professeur professeur;
        private void buttonCreerProf_Click(object sender, EventArgs e)
        {
            var jsonProf = new DAL.JsonDataManager<Professeur>();
            List<Professeur> professeurs = jsonProf.DataList;
            professeur = new Professeur()
            {
                nom = textBoxNomProf.Text,
                prenom = textBoxPrenomProf.Text,
                login = textBoxLoginProf.Text,
                password = textBoxPasswordProf.Text
            };
            professeur.isAdmin = comboBoxIsAdminProf.Text == "OUI" ? professeur.isAdmin = true : professeur.isAdmin = false;
            // équivalent à :
            /*if (comboBoxIsAdminProf.Text == "OUI")
            {
                professeur.isAdmin = true;
            }
            else
            {
                professeur.isAdmin = false;
            }*/

            professeurs.Add(professeur);
            MessageBox.Show(professeur+"");
            comboBoxProfClasse.DataSource = professeurs.ToArray();
            jsonProf.WriteJsonData(professeurs);
        }

        List<Classe> classes = new List<Classe>();
        Classe classe;
        private void buttonCreerClasse_Click(object sender, EventArgs e)
        {
            var jsonClasse = new DAL.JsonDataManager<Classe>();
            //List<Classe> classes = jsonClasse.DataList;
            classe = new Classe()
            {
                label = textBoxNomClasse.Text,
                //niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            classes.Add(classe);
            MessageBox.Show(classe+"");
            comboBoxClasseProf.DataSource = classes.ToArray();
            comboBoxClasseEleve.DataSource = classes.ToArray();
            jsonClasse.WriteJsonData(classes);
        }

        private void buttonAddProf_Click(object sender, EventArgs e)
        {
            classe.AddProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur+"");
        }

        private void buttonRemoveProf_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(comboBoxProfClasse.SelectedItem as Professeur);
            MessageBox.Show(classe.Professeur + "");
        }

        private void buttonAddClasse_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(comboBoxClasseProf.SelectedItem as Classe); 
            MessageBox.Show(professeur.Classe+"");
        }

        private void buttonRemoveClasse_Click(object sender, EventArgs e)
        {
            professeur.RemoveClasse(comboBoxClasseProf.SelectedItem as Classe);
            MessageBox.Show(professeur.Classe+"");
        }

       //List<Eleve> eleves = new List<Eleve>();
        Eleve eleve;
        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            var jsonEleve = new DAL.JsonDataManager<Eleve>();
            List<Eleve> eleves = jsonEleve.DataList;
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
            jsonEleve.WriteJsonData(eleves);

        }

        private void buttonAddEleveClasse_Click(object sender, EventArgs e)
        {
            eleve.classe = comboBoxClasseEleve.SelectedItem as Classe;
            MessageBox.Show(eleve.classe + "");
        }

    }
}