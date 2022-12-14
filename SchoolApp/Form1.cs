using SchoolApp.Models;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Professeur professeur;
        private void button1_Click_1(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                Nom = tbProfesseurNom.Text,
                Prenom = tbProfesseurPrenom.Text,
                Login = tbProfesseurLogin.Text,
                Password = TbProfesseurPassword.Text,
            };
            MessageBox.Show(professeur + "");
            bool stop = true;
        }

        Classe classe;
        private void button2_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                Label = tbClasseLabel.Text,
            };
            MessageBox.Show(classe + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(classe);
            MessageBox.Show(professeur + "\n" + professeur.Classe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            professeur.RemoveClasse(classe);
            MessageBox.Show(professeur + "\n" + professeur.Classe);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe.AddProfesseur(professeur);
            MessageBox.Show(classe + "\n" + classe.Professeur);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(professeur);
            MessageBox.Show(classe + "\n" + classe.Professeur);
        }


    }
}