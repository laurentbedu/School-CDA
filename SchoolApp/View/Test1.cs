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

            //niveauList = new List<Niveau>
            //{
            //    new Niveau() { Label_Niveau = "CP" },
            //    new Niveau() { Label_Niveau = "CE1"},
            //    new Niveau() { Label_Niveau = "CE2"},
            //    new Niveau() { Label_Niveau = "CM1"},
            //    new Niveau() { Label_Niveau = "CM2"}
            //};
            //matiereList = new List<Matiere> {
            //    new Matiere() {Label_Matiere = "Mathématique"},
            //    new Matiere() {Label_Matiere = "Français"},
            //    new Matiere() {Label_Matiere = "Anglais"},
            //    new Matiere() {Label_Matiere = "Sciences"},
            //    new Matiere() {Label_Matiere = "Histoire"},
            //    new Matiere() {Label_Matiere = "Géographie"}
            //};
            //niveauList.Find(e => e.Label_Niveau == "CP")?.AddMatiere(matiereList[0], matiereList[1]);
            //niveauList.Find(e => e.Label_Niveau == "CE1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2]);
            //niveauList.Find(e => e.Label_Niveau == "CE2")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            //niveauList.Find(e => e.Label_Niveau == "CM1")?.AddMatiere(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            //niveauList.Find(e => e.Label_Niveau == "CM2")?.AddMatiere(matiereList.ToArray());

            //comboBoxNiveauClasse.DataSource = niveauList;

            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.DataList;

            foreach (var item in list) { comboBoxNiveauClasse.Items.Add(item.ToString()); }


            var jDMMatiere = new DAL.JsonDataManager<Models.Matiere>();
            List<Matiere> listMatiere = jDMMatiere.DataList;

            foreach (var item in listMatiere) { cbListeMatiere.Items.Add(item.ToString()); }

        }

        List<Matiere> matiereList;

        

        Professeur? professeur; 
        private void button1_Click(object sender, EventArgs e) // Créer professeur
        {
            professeur = new Professeur()
            {
                Nom = textBoxNomProf.Text,
                Prenom = textBoxPrenomProf.Text,
                Login = textBoxLogProf.Text,
                Password = textBoxPassProf.Text,
            };
            //MessageBox.Show(professeur + "");

            var jsonDataManager = new DAL.JsonDataManager<Models.Professeur>();
            List<Professeur> list = jsonDataManager.DataList;
                        
            list.Add(professeur);
                        
            jsonDataManager.SaveJsonData(list);

            ListViewItem ligne = new ListViewItem();
            ligne.Text = textBoxNomProf.Text;
            ligne.SubItems.Add(textBoxPrenomProf.Text);
            ligne.SubItems.Add(professeur.Id.ToString());

            listView1.Items.Add(ligne);      

        }

        Eleve? eleve;
        private void buttonAddEl_Click(object sender, EventArgs e) // Créer élève
        {
            eleve = new Eleve()
            {
                Nom = textBoxNomEl.Text,
                Prenom = textBoxPrenomEl.Text,
            };
            //MessageBox.Show(eleve + "");

            var jsonDataManager = new DAL.JsonDataManager<Models.Eleve>();
            List<Eleve> list = jsonDataManager.DataList;

            list.Add(eleve);

            jsonDataManager.SaveJsonData(list);

            ListViewItem ligne = new ListViewItem();
            ligne.Text = textBoxNomEl.Text;
            ligne.SubItems.Add(textBoxPrenomEl.Text);
            ligne.SubItems.Add(eleve.Id.ToString());

            listView1.Items.Add(ligne);

        }        
        

        Classe? classe;
        List<Niveau> niveauList; 
        private void button2_Click(object sender, EventArgs e) // Créer classe
        {
            classe = new Classe()
            {
                Label_Classe = textBoxNomClasse.Text,
                Niveau = comboBoxNiveauClasse.SelectedItem as Niveau
                Matiere = cbListeMatiere.SelectedItem.ToString;
            };
            MessageBox.Show(classe + "");

            var JDMClasse = new DAL.JsonDataManager<Models.Classe>();
            List<Classe> list = JDMClasse.DataList;

            list.Add(classe);

            JDMClasse.SaveJsonData(list);



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
            listView1.Items.Remove(listView1.SelectedItems[0]);

            bool stop = true;
        }

        private void button7_Click(object sender, EventArgs e) // supprimer un élève
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
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void cbListeMatiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
