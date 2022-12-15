using SchoolApp.Models;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professeur professeur1 = new Professeur() { Nom = "Manson", Prenom = "Charles"};
            textBoxProf.Text = professeur1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eleve eleve1 = new Eleve() {Nom = "Petit", Prenom = "Gregory" };
            textBoxEleve.Text = eleve1.ToString();
        }

        private void buttonClasse_Click(object sender, EventArgs e)
        {
            Classe classe1 = new Classe() { Label_Classe = "Voltaire" };
            textBoxClasse.Text = classe1.ToString() ;
        }

        private void buttonNiveau_Click(object sender, EventArgs e)
        {
            Niveau niveau1 = new Niveau() { Label_Niveau = "CP"};
            textBoxNiveau.Text = niveau1.ToString();
        }

        private void buttonMatiere_Click(object sender, EventArgs e)
        {
            Matiere matiere1 = new Matiere() { Label_Matiere = "Français"};
            textBoxMatiere.Text = matiere1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Professeur professeur1 = new Professeur() { Nom = "Manson", Prenom = "Charles" };
            Professeur professeur2 = new Professeur() { Nom = "Ramirez", Prenom = "Richard" };
            Eleve eleve1 = new Eleve() { Nom = "Petit", Prenom = "Gregory" };
            Eleve eleve2 = new Eleve() { Nom = "Sawyer", Prenom = "Tom" };
            Eleve eleve3 = new Eleve() { Nom = "Rouge", Prenom = "Chaperon" };
            Classe classe1 = new Classe() { Label_Classe = "Voltaire" };
            Classe classe2 = new Classe() { Label_Classe = "Montesquieu" };
            Niveau niveau1 = new Niveau() { Label_Niveau = "CP" };
            Niveau niveau2 = new Niveau() { Label_Niveau = "CE1" };
            Matiere matiere1 = new Matiere() { Label_Matiere = "Français" };
            Matiere matiere2 = new Matiere() { Label_Matiere = "Mathématiques" };
            Matiere matiere3 = new Matiere() { Label_Matiere = "Anglais" };

            niveau1.AddClasse(classe1);
            classe1.AddProfesseur(professeur1);
            classe1.AddEleve(eleve1);
            classe1.AddEleve(eleve2);
            classe1.AddEleve(eleve3);
            classe2.AddEleve(eleve1);
            niveau2.AddClasse(classe1);
            professeur2.AddClasse(classe2);
            professeur2.AddClasse(classe1);
            niveau1.AddMatiere(matiere1);
            niveau1.AddMatiere(matiere2, matiere3);
            matiere1.AddNiveau(niveau1,niveau2);





            bool stop = true;


        }
    }
}