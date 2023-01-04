using SchoolApp.DAL;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.View
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();

            niveauList = new List<Niveau>
            {
                new Niveau() { Label_Niveau = "CP" },
                new Niveau() { Label_Niveau = "CE1"},
                new Niveau() { Label_Niveau = "CE2"},
                new Niveau() { Label_Niveau = "CM1"},
                new Niveau() { Label_Niveau = "CM2"}
            };
            matiereList = new List<Matiere> {
                new Matiere() {Label_Matiere = "Mathématique"},
                new Matiere() {Label_Matiere = "Français"},
                new Matiere() {Label_Matiere = "Anglais"},
                new Matiere() {Label_Matiere = "Sciences"},
                new Matiere() {Label_Matiere = "Histoire"},
                new Matiere() {Label_Matiere = "Géographie"}
            };
            niveauList.Find(e => e.Label_Niveau == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.Label_Niveau == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.Label_Niveau == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.Label_Niveau == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.Label_Niveau == "CM2")?.AddMatiere(matiereList.ToArray());

            comboBoxNiveauClasse.DataSource = niveauList;

        }

        List<Matiere> matiereList;

        

        Professeur? professeur;
        private void button1_Click(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                Nom = textBoxNomProf.Text,
                Prenom = textBoxPrenomProf.Text,
                Login = textBoxLogProf.Text,
                Password = textBoxPassProf.Text,
            };
            MessageBox.Show(professeur + "");

            var jsonDataManager = new DAL.JsonDataManager<Models.Professeur>();
            List<Professeur> list = jsonDataManager.DataList;
                        
            list.Add(professeur);
                        
            jsonDataManager.SaveJsonData(list);

            ListViewItem ligne = new ListViewItem();
            ligne.Text = textBoxNomProf.Text;
            ligne.SubItems.Add(textBoxPrenomProf.Text);

            listView1.Items.Add(ligne);




        }

        Eleve? eleve;
        private void buttonAddEl_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                Nom = textBoxNomEl.Text,
                Prenom = textBoxPrenomEl.Text,
            };
            MessageBox.Show(eleve + "");

            var jsonDataManager = new DAL.JsonDataManager<Models.Eleve>();
            List<Eleve> list = jsonDataManager.DataList;

            list.Add(eleve);

            jsonDataManager.SaveJsonData(list);

        }        
        

        Classe? classe;
        List<Niveau> niveauList;
        private void button2_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                Label_Classe = textBoxNomClasse.Text,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
            };
            MessageBox.Show(classe + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.DataList;


            foreach (var item in list) { comboBox1.Items.Add(item.ToString()); }

            foreach (var item in list) { textBox1.Text += item.ToString() + " "; }

            foreach (var item in list) { listBox1.Items.Add(item.ToString()); }
                      


            List<Niveau> ListeNiveau = new List<Niveau>();
            Niveau niveau1 = new Niveau() { Label_Niveau = "CP"};
            Niveau niveau2 = new Niveau() { Label_Niveau = "CE1" };
            Niveau niveau3 = new Niveau() { Label_Niveau = "CE2" };

            ListeNiveau.Add(niveau1);
            ListeNiveau.Add(niveau2);
            ListeNiveau.Add(niveau3);

            string jsonString = JsonSerializer.Serialize<List<Niveau>>(ListeNiveau)!;
            MessageBox.Show(jsonString);
            
            

            bool stop = true;
        }

        private void button4_Click(object sender, EventArgs e) // afficher la liste des professeurs
        {
            listBox2.Items.Clear();
            listView1.Items.Clear();
            var jsonDataManager = new DAL.JsonDataManager<Models.Professeur>();
            List<Professeur> list = jsonDataManager.DataList;

            foreach (var item in list) { listBox2.Items.Add(item.ToString()); }

          
            foreach (Professeur professeur in list)             
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = professeur.Nom.ToString();
                ligne.SubItems.Add(professeur.Prenom.ToString());
                ligne.SubItems.Add(professeur.Id.ToString());
                listView1.Items.Add(ligne);
                
            }                   
            
        }

        private void button5_Click(object sender, EventArgs e) // afficher la liste des élèves
        {
            listBox2.Items.Clear();
            listView1.Items.Clear();
            var jsonDataManager = new DAL.JsonDataManager<Models.Eleve>();
            List<Eleve> list = jsonDataManager.DataList;

            foreach (var item in list) { listBox2.Items.Add(item.ToString()); }

            foreach (Eleve eleve in list)
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = eleve.Nom.ToString();
                ligne.SubItems.Add(eleve.Prenom.ToString());
                ligne.SubItems.Add(eleve.Id.ToString());
                listView1.Items.Add(ligne);

            }
        }

        private void button6_Click(object sender, EventArgs e) // supprimer un professeur de la liste
        {
            //var jsonDataManager = new DAL.JsonDataManager<Models.Professeur>();
            //List<Professeur> list = jsonDataManager.DataList;

            //professeur = listBox2.SelectedItem as Professeur;
            //listBox2.Items.Remove(professeur);

            //var prof = listView1.SelectedItems ;

            //var test = prof.Cast<Professeur>() ;

            //list.Remove(test);

            //var eleveJdM = new JsonDataManager<Eleve>();
            //var eleveListe = eleveJdM.GetWhere();
            //var elevePrenomCatha = eleveJdM.GetWhere(item => item.Prenom == "Catha");
            //var eleve37 = eleveJdM.GetById("37");
            //var eleve201 = eleveJdM.GetById("201");

            ListView.SelectedListViewItemCollection selection = listView1.SelectedItems ;
                        
            foreach (ListViewItem item in selection)
            {
               string IdProf = item.SubItems[2].Text;
                var profJdM = new JsonDataManager<Professeur>();
                List<Professeur> list = profJdM.DataList;
                var deleteProf = profJdM.GetById(IdProf);
                list.Remove(deleteProf);

                profJdM.SaveJsonData(list);

            }
               

            //var profJdM = new JsonDataManager<Professeur>();
            //List<Professeur> list = profJdM.DataList;
            //var profprof = profJdM.GetById("8de3fc0a-5ee5-4a53-971a-6faf0c2b278c");
            //list.Remove(profprof);

            //profJdM.SaveJsonData(list);

            bool stop = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selection = listView1.SelectedItems;

            foreach (ListViewItem item in selection)
            {
                string IdEleve = item.SubItems[2].Text;
                var eleveJdM = new JsonDataManager<Eleve>();
                List<Eleve> list = eleveJdM.DataList;
                var deleteEleve = eleveJdM.GetById(IdEleve);
                list.Remove(deleteEleve);

                eleveJdM.SaveJsonData(list);

            }
        }
    }
}
