using SchoolApp.Models;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Data.SQLite;
using System.Linq.Expressions;

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
           
                      
           

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bddpath = "C:\\Users\\xseb\\source\\repos\\bdd.sqlite";
            if (!File.Exists(bddpath)) CreateBDD();

            void CreateBDD()
            {
                SQLiteConnection.CreateFile(bddpath);
                SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\xseb\\source\\repos\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "create table model (nom varchar(20), prenom varchar(20))";
                
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personne personne = new Personne();

            string N = BoxNom2.Text;

            string P = BoxPrenom2.Text;

            
                AddData(N,P);
                MessageBox.Show("OK");
            
            

            void AddData(string N, string P)
            {
                SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\xseb\\source\\repos\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "INSERT INTO model(nom, prenom) VALUES ('" + N + "','" + P + "')";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();
                
            }
        }
    }
}