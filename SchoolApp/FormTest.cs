using GestionNotes;
using SchoolApp.Models;

namespace SchoolApp
{
    public partial class FormTest : Form
    {
        List<Eleve>         listeEleves         = new List<Eleve>();
        List<Professeur>    listeProfesseurs    = new List<Professeur>();
        List<Matiere>       listeMatiere        = new List<Matiere>();

        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Eleve newEleve = new Eleve("all", "max","2ans");
            MessageBox.Show(newEleve.ToString());

        }   // btn add eleve

        private void button2_Click(object sender, EventArgs e)
        {
            Professeur newProf = new Professeur("Bedu", "Laurent", "b.laurent", "toto");
            MessageBox.Show(newProf.ToString());
        }   // btn add prof

        private void button3_Click(object sender, EventArgs e)
        {
            Classe newClasse = new Classe("Alpha");
            MessageBox.Show(newClasse.ToString());
        }   //btn add classe

        private void button4_Click(object sender, EventArgs e)
        {
            FormGestion newFormGestion = new FormGestion(listeEleves, listeProfesseurs, listeMatiere);
            newFormGestion.Show();
            this.Hide();
        }
    }
}