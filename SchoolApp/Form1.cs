using System.Collections.Generic;
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

            niveauList = niveauJdm.DataList;
            niveauList = niveauList.OrderBy(e => e.Id).ToList();
            comboBoxNiveauClasse.DataSource = niveauList;

            classeList = classeJdM.DataList;
            classeList = classeList.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = classeList;
            comboBoxClasseEleve.DataSource = classeList;

            professeurList = professeurJdM.DataList;
            professeurList = professeurList.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = professeurList;

            eleveList = eleveJdm.DataList;
            eleveList = eleveList.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = eleveList;
        }


        List<Niveau> niveauList = new();
        List<Matiere> matiereList = new();
        List<Professeur> professeurList = new();
        List<Eleve> eleveList = new();
        List<Classe> classeList = new();

        DAL.JsonDataManager<Classe> classeJdM = new DAL.JsonDataManager<Classe>();
        DAL.JsonDataManager<Professeur> professeurJdM = new DAL.JsonDataManager<Professeur>();
        DAL.JsonDataManager<Niveau> niveauJdm = new DAL.JsonDataManager<Niveau>();
        DAL.JsonDataManager<Eleve> eleveJdm = new DAL.JsonDataManager<Eleve>();
        DAL.JsonDataManager<Matiere> matiereJdm = new DAL.JsonDataManager<Matiere>();

        Professeur professeur;
        private void ButtonCreerProf_Click(object sender, EventArgs e)
        {
            professeurList = professeurJdM.DataList;
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

            professeurList.Add(professeur);
            MessageBox.Show(professeur+"");
            professeurList = professeurList.OrderBy(e => e.Nom).ToList();
            comboBoxProfClasse.DataSource = professeurList;
            professeurJdM.SaveJsonData();
        }

        Classe classe;
        private void ButtonCreerClasse_Click(object sender, EventArgs e)
        {
            classeList = classeJdM.DataList;

            string nom = textBoxNomClasse.Text;
            string _nom = char.ToUpper(nom[0]) + nom[1..].ToLower();
            classe = new Classe()
            {
                Label = _nom,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            classeList.Add(classe);
            MessageBox.Show(classe+"");
            classeList = classeList.OrderBy(e => e.niveau_id).ToList();
            comboBoxClasseProf.DataSource = classeList;
            comboBoxClasseEleve.DataSource = classeList;
            classeJdM.SaveJsonData();
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

        }

        private void ButtonRemoveProf_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCreerEleve_Click(object sender, EventArgs e)
        {
            Eleve eleve;
            var jsonVar = new DAL.JsonDataManager<Eleve>();
            eleveList = eleveJdm.DataList;
            string lastname = textBoxPrenomEleve.Text;
            string _prenom = char.ToUpper(lastname[0]) + lastname[1..].ToLower();
            eleve = new Eleve()
            {
                Nom = textBoxNomEleve.Text.ToUpper(),
                Prenom = _prenom,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value)
            };
            eleveList.Add(eleve);
            MessageBox.Show(eleve + "");
            eleveList = eleveList.OrderBy(e => e.Nom).ToList();
            comboBoxEleveClasse.DataSource = eleveList;
            eleveJdm.SaveJsonData();
        }

        private void ButtonAddEleveClasse_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveEleveClasse_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Classe>();
            List<Classe> list = jsonDataManager.DataList;
            var classeList = jsonDataManager.GetWhere();
            Classe cl1 = jsonDataManager.GetById("2869c720-ce97-408d-8542-56b94f6ab6b9");
            Niveau niv = cl1.Niveau;

            var niveauDataManager = new DAL.JsonDataManager<Models.Niveau>();
            var nivCE1 = niveauDataManager.GetById("niveau_2");
            cl1.Niveau = nivCE1;
            jsonDataManager.SaveJsonData();
        }
    }
}