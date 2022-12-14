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

        Professeur professeur;
        private void buttonAddProf_Click(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                nom = textBoxNomProf.Text,
                prenom = textBoxPrenomProf.Text
            };
            MessageBox.Show(professeur+"");
        }
        Classe classe;
        private void buttonCreerClasse_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                label = textBoxNomClass.Text,
            };
            MessageBox.Show(classe+"");
        }

        private void buttonAddProf_Click_1(object sender, EventArgs e)
        {
            classe.AddProfesseur(professeur);
            //MessageBox.Show(classe+"");
        }

        private void buttonRemoveProf_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(professeur);
            //MessageBox.Show(classe+"");
        }

        private void buttonAddClasse_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(classe); 
            MessageBox.Show(professeur+"");
        }

        private void buttonRemoveClasse_Click(object sender, EventArgs e)
        {
            professeur.RemoveClasse(classe);
            MessageBox.Show(professeur+"");
        }
    }
}