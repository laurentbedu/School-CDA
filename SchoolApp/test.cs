using SchoolApp.Models;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Data.SQLite;
using System.Linq.Expressions;
using System;

namespace SchoolApp
{
    public partial class test : Form
    {
        Professeur professeur;
        Eleve eleve;
        Classe classe;
        int compteur = 0;
        private string admin;

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

            professeur.IsAdmin = AdminBox.Checked ? true : false;

            MessageBox.Show(professeur + "");

            string bddpath2 = "C:\\Users\\xseb\\source\\repos\\bddProf.sqlite";

            if (!File.Exists(bddpath2)) CreateBDD();

            void CreateBDD()
            {
                SQLiteConnection.CreateFile(bddpath2);

                SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\xseb\\source\\repos\\bddProf.sqlite;Version=3;");
                con.Open();

                string sql = "create table professeur (nom varchar(20), prenom varchar(20), login varchar(20), password varchar(20), admin varchar(20))";

                SQLiteCommand command = new SQLiteCommand(sql, con);

                command.ExecuteNonQuery();
                con.Close();
            }

            if (professeur.IsAdmin == true)
            {  admin = "Admin"; }
            else
            {
                admin = "Non Admin";
            }
            string N = BoxNom.Text;

            string P = BoxPrenom.Text;

            string login = BoxLogin.Text;

            string password = BoxPassword.Text;


            AddDataProf(N, P, login, password, admin);
            MessageBox.Show("OK");


            void AddDataProf(string N, string P, string login, string password, string admin)
            {
                SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\xseb\\source\\repos\\bddProf.sqlite;Version=3;");
                con.Open();

                string sql = "INSERT INTO professeur(nom, prenom, login, password, admin) VALUES ('" + N + "','" + P + "','" + login + "','" + password + "','" + admin + "')";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();

            }
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
           
            string N = BoxNom2.Text;

            string P = BoxPrenom2.Text;

            compteur += 1;

                AddDataEleve(N,P);
                MessageBox.Show("OK");
            
            

            void AddDataEleve(string N, string P)
            {
                SQLiteConnection con = new SQLiteConnection("Data Source =C:\\Users\\xseb\\source\\repos\\bdd.sqlite;Version=3;");
                con.Open();

                string sql = "INSERT INTO model(nom, prenom) VALUES ('" + N + "','" + P + "')";
                SQLiteCommand command = new SQLiteCommand(sql, con);
                command.ExecuteNonQuery();
                con.Close();
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void AdminBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}