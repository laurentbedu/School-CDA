using System.Runtime.ConstrainedExecution;
using SchoolApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Classe> classes = new List<Classe>();
        List<Professeur> professeurs = new List<Professeur>();
        List<Niveau> niveaux = new List<Niveau>();

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
        }
        Classe classe;
        private void buttonCreerClasse_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                label = textBoxNomClasse.Text,
                niveau = niveaux.Contains(comboBoxNiveauClasse.Text)
            };
            classes.Add(classe);
            MessageBox.Show(classe+"");
        }

        private void buttonAddProf_Click(object sender, EventArgs e)
        {
            classe.AddProfesseur(professeur);
            MessageBox.Show(classe.Professeur+"");
        }

        private void buttonRemoveProf_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(professeur);
            MessageBox.Show(classe.Professeur + "");
        }

        private void buttonAddClasse_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(classe); 
            MessageBox.Show(professeur.Classe+"");
        }

        private void buttonRemoveClasse_Click(object sender, EventArgs e)
        {
            professeur.RemoveClasse(classe);
            MessageBox.Show(professeur.Classe+"");
        }
        Eleve eleve;
        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                nom = textBoxNomEleve.Text,
                prenom = textBoxPrenomEleve.Text,
                anciennete = Convert.ToInt32(numericUpDownAncienneteEleve.Value)
            };
            MessageBox.Show(eleve + "");

        }
    }
}