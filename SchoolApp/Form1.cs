using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
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

            /*
            matiereList = new List<Matiere> {
                new Matiere() {Label = "Mathématique", Id = "matiere_1"},
                new Matiere() {Label = "Français", Id = "matiere_2"},
                new Matiere() {Label = "Anglais", Id = "matiere_3"},
                new Matiere() {Label = "Sciences", Id = "matiere_4"},
                new Matiere() {Label = "Histoire", Id = "matiere_5"},
                new Matiere() {Label = "Géographie", Id = "matiere_6"}
            };

            niveauList.Find(e => e.Label == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.Label == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.Label == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.Label == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.Label == "CM2")?.AddMatiere(matiereList.ToArray());
            */

            NiveauList = niveauJdm.DataList;
            NiveauList = NiveauList.OrderBy(e => e.Id).ToList();
            comboBoxNiveauClasse.DataSource = NiveauList;

            ClasseList = classeJdM.DataList;
            ClasseList = ClasseList.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = ClasseList;
            comboBoxClasseEleve.DataSource = ClasseList;

            ProfesseurList = professeurJdM.DataList;
            ProfesseurList = ProfesseurList.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = ProfesseurList;

            EleveList = eleveJdm.DataList;
            EleveList = EleveList.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = EleveList;
        }


        List<Niveau> NiveauList = new();
        List<Matiere> MatiereList = new();
        List<Professeur> ProfesseurList = new();
        List<Eleve> EleveList = new();
        List<Classe> ClasseList = new();

        DAL.JsonDataManager<Classe> classeJdM = new DAL.JsonDataManager<Classe>();
        DAL.JsonDataManager<Professeur> professeurJdM = new DAL.JsonDataManager<Professeur>();
        DAL.JsonDataManager<Niveau> niveauJdm = new DAL.JsonDataManager<Niveau>();
        DAL.JsonDataManager<Eleve> eleveJdm = new DAL.JsonDataManager<Eleve>();
        DAL.JsonDataManager<Matiere> matiereJdm = new DAL.JsonDataManager<Matiere>();

        Professeur professeur;
        private void ButtonCreerProf_Click(object sender, EventArgs e)
        {
            ProfesseurList = professeurJdM.DataList;
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

            ProfesseurList.Add(professeur);
            ProfesseurList = ProfesseurList.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = ProfesseurList;
            professeurJdM.SaveJsonData();

            var bindingProfesseurList = new BindingList<Professeur>(ProfesseurList);
            var source = new BindingSource(bindingProfesseurList, null);
            dataGridView1.DataSource = source;
        }

        Classe classe;
        private void ButtonCreerClasse_Click(object sender, EventArgs e)
        {
            ClasseList = classeJdM.DataList;

            string nom = textBoxNomClasse.Text;
            string _nom = char.ToUpper(nom[0]) + nom[1..].ToLower();
            classe = new Classe()
            {
                Label = _nom,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            ClasseList.Add(classe);
            ClasseList = ClasseList.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = ClasseList;
            comboBoxClasseEleve.DataSource = ClasseList;
            classeJdM.SaveJsonData();

            var bindingClasseList = new BindingList<Classe>(ClasseList);
            var source = new BindingSource(bindingClasseList, null);
            dataGridView1.DataSource = source;
        }

        private void ButtonAddProf_Click(object sender, EventArgs e)
        {
            Classe cl = comboBoxClasseProf.SelectedItem as Classe;
            Professeur prof = comboBoxProfClasse.SelectedItem as Professeur;
            string classeID = cl.Id;
            string profID = prof.Id;
            var cl1 = classeJdM.GetWhere(item => item.Id == classeID);
            var prof1 = professeurJdM.GetWhere(item => item.Id == profID);
            cl1[0].AddProfesseur(prof1[0]);
            classeJdM.SaveJsonData();
            professeurJdM.SaveJsonData();

            var bindingClasseList = new BindingList<Classe>(ClasseList);
            var source = new BindingSource(bindingClasseList, null);
            dataGridView1.DataSource = source;

        }

        private void ButtonRemoveProf_Click(object sender, EventArgs e)
        {
            Classe cl = comboBoxClasseProf.SelectedItem as Classe;
            if (cl.Professeur != null)
            {
                string classeID = cl.Id;
                professeur = cl.Professeur;
                string profID = professeur.Id;
                var cl1 = classeJdM.GetWhere(item => item.Id == classeID);
                var prof1 = professeurJdM.GetWhere(item => item.Id == profID);
                cl1[0].RemoveProfesseur(prof1[0]);
                classeJdM.SaveJsonData();
                professeurJdM.SaveJsonData();

                var bindingClasseList = new BindingList<Classe>(ClasseList);
                var source = new BindingSource(bindingClasseList, null);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Aucun prof attribué à " + cl);
            }

        }

        private void ButtonCreerEleve_Click(object sender, EventArgs e)
        {
            Eleve eleve;
            var jsonVar = new DAL.JsonDataManager<Eleve>();
            EleveList = eleveJdm.DataList;
            string lastname = textBoxPrenomEleve.Text;
            string _prenom = char.ToUpper(lastname[0]) + lastname[1..].ToLower();
            eleve = new Eleve()
            {
                Nom = textBoxNomEleve.Text.ToUpper(),
                Prenom = _prenom,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value)
            };
            EleveList.Add(eleve);
            EleveList = EleveList.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = EleveList;
            eleveJdm.SaveJsonData();

            var bindingEleveList = new BindingList<Eleve>(EleveList);
            var source = new BindingSource(bindingEleveList, null);
            dataGridView1.DataSource = source;
        }

        private void ButtonAddEleveClasse_Click(object sender, EventArgs e)
        {
            Classe cl = comboBoxClasseEleve.SelectedItem as Classe;
            Eleve ele = comboBoxEleveClasse.SelectedItem as Eleve;
            string classeID = cl.Id;
            string eleID = ele.Id;
            var cl1 = classeJdM.GetWhere(item => item.Id == classeID);
            var ele1 = eleveJdm.GetWhere(item => item.Id == eleID);
            ele1[0].AddClasse(cl1[0]);
            eleveJdm.SaveJsonData();

            var bindingEleveList = new BindingList<Eleve>(EleveList);
            var source = new BindingSource(bindingEleveList, null);
            dataGridView1.DataSource = source;

        }

        private void ButtonRemoveEleveClasse_Click(object sender, EventArgs e)
        {
            Eleve ele = comboBoxEleveClasse.SelectedItem as Eleve;
            if (ele.Classe != null)
            {
                string eleID = ele.Id;
                classe = ele.Classe;
                string clID = classe.Id;
                var ele1 = eleveJdm.GetWhere(item => item.Id == eleID);
                var cl1 = classeJdM.GetWhere(item => item.Id == clID);
                ele1[0].RemoveClasse(cl1[0]);
                eleveJdm.SaveJsonData();

                var bindingEleveList = new BindingList<Eleve>(EleveList);
                var source = new BindingSource(bindingEleveList, null);
                dataGridView1.DataSource = source;
            }
            else
            {
                MessageBox.Show("Aucune classe attribué à " + ele);
            }


        }

        private void buttonVoirNiveaux_Click(object sender, EventArgs e)
        {
            var bindingNiveauList = new BindingList<Niveau>(NiveauList);
            var source = new BindingSource(bindingNiveauList, null);
            dataGridView1.DataSource = source;
        }
        private void buttonVoirClasses_Click(object sender, EventArgs e)
        {
            var bindingClasseList = new BindingList<Classe>(ClasseList);
            var source = new BindingSource(bindingClasseList, null);
            dataGridView1.DataSource = source;
        }

        private void buttonVoirProfs_Click(object sender, EventArgs e)
        {
            var bindingProfesseurList = new BindingList<Professeur>(ProfesseurList);
            var source = new BindingSource(bindingProfesseurList, null);
            dataGridView1.DataSource = source;
        }
        private void buttonVoirEleves_Click(object sender, EventArgs e)
        {
            var bindingEleveList = new BindingList<Eleve>(EleveList);
            var source = new BindingSource(bindingEleveList, null);
            dataGridView1.DataSource = source;
        }

    }
}