using SchoolApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace SchoolApp
{
    public partial class test : Form
    {
        Professeur professeur;
        Eleve eleve;
        Classe classe;
        
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

        private void BtEleve_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                Nom = BoxNom2.Text,
                Prenom = BoxPrenom2.Text,
            };

            MessageBox.Show(eleve + "");
        }

        
        private void ListeMatiere_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                LabelClasse = BoxClasse.Text
            };
            MessageBox.Show(classe + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void BtJson_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.dataList;
        }
    }
}