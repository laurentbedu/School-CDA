using SchoolApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace SchoolApp
{
    public partial class test : Form
    {
        Professeur professeur;
        public test()
        {
            InitializeComponent();
        }

        private void bttest_Click(object sender, EventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btClasse_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtProf_Click(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                Nom = BoxNom.Text,
                Prenom = BoxPrenom.Text,
                Login = BoxLogin.Text,
                Password = BoxPassword.Text,
            };

            MessageBox.Show(professeur + "");
        }

        private void BoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}