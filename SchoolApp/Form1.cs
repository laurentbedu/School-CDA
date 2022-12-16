using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
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
                new Niveau() { label = "CP" },
                new Niveau() { label = "CE1" },
                new Niveau() { label = "CE2" },
                new Niveau() { label = "CM1" },
                new Niveau() { label = "CM2" }
            };
            matiereList = new List<Matiere> {
                new Matiere() {label = "Mathématique"},
                new Matiere() {label = "Français"},
                new Matiere() {label = "Anglais"},
                new Matiere() {label = "Sciences"},
                new Matiere() {label = "Histoire"},
                new Matiere() {label = "Géographie"}
            };
            niveauList.Find(e => e.label == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.label == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.label == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.label == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.label == "CM2")?.AddMatiere(matiereList.ToArray());

            comboBoxNiveauClasse.DataSource = niveauList;
        }
        List<Classe> classes = new List<Classe>();
        List<Professeur> professeurs = new List<Professeur>();
        List<Niveau> niveauList = new List<Niveau>();
        List<Matiere> matiereList = new List<Matiere>();
        List<Eleve> eleveList = new List<Eleve>();

        Professeur professeur;
        private void buttonCreerProf_Click(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                nom = textBoxNomProf.Text,
                prenom = textBoxPrenomProf.Text,
                login = textBoxLoginProf.Text,
                password = textBoxPasswordProf.Text
            };
            professeurs.Add(professeur);
            MessageBox.Show(professeur+"");
            comboBoxProfClasse.DataSource = professeurs.ToArray();
        }
        Classe classe;
        private void buttonCreerClasse_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                label = textBoxNomClasse.Text,
                niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            classes.Add(classe);
            MessageBox.Show(classe+"");
            comboBoxClasseProf.DataSource = classes.ToArray();
            comboBoxClasseEleve.DataSource = classes.ToArray();
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
        Eleve eleve;
        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                nom = textBoxNomEleve.Text,
                prenom = textBoxPrenomEleve.Text,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value),
                classe = comboBoxClasseEleve.SelectedItem as Classe
            };
            eleveList.Add(eleve);
            MessageBox.Show(eleve + "");
            comboBoxEleveClasse.DataSource = eleveList.ToArray(); ;

        }

        private void buttonAddEleveClasse_Click(object sender, EventArgs e)
        {

        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.DataList;
        }
    }
}