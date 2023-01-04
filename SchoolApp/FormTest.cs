using Microsoft.VisualBasic;
using SchoolApp.DAL;
using SchoolApp.Models;
using SchoolApp.UserControls;
using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class FormTest : Form
    {
        List<Eleve>         listeEleves         = new List<Eleve>();
        List<Professeur>    listeProfesseurs    = new List<Professeur>();
        List<Classe>        listeClasses        = new List<Classe>();
        List<Matiere>       listeMatieres       = new List<Matiere>();
        List<Niveau>        listeNiveaux        = new List<Niveau>();
        List<Note>          listeNotes          = new List<Note>();
        UserControl1 userControl1;
        DAL.JsonDataManager<Models.Niveau>      jsonDataManagerNiveau       = new DAL.JsonDataManager<Models.Niveau>();
        DAL.JsonDataManager<Models.Eleve>       jsonDataManagerEleve        = new DAL.JsonDataManager<Models.Eleve>();
        DAL.JsonDataManager<Models.Professeur>  jsonDataManagerProfesseur   = new DAL.JsonDataManager<Models.Professeur>();
        DAL.JsonDataManager<Models.Classe>      jsonDataManagerClasse       = new DAL.JsonDataManager<Models.Classe>();
        DAL.JsonDataManager<Models.Matiere>     jsonDataManagerMatiere      = new DAL.JsonDataManager<Models.Matiere>();
        DAL.JsonDataManager<Models.Note>        jsonDataManagerNote         = new DAL.JsonDataManager<Models.Note>();

        public FormTest()
        {
            InitializeComponent();
        }
        public void importJSON()
        {            
            dataGridViewTest.Visible = true;

            listeNiveaux = jsonDataManagerNiveau.DataList;
            listeEleves = jsonDataManagerEleve.DataList;            
            listeProfesseurs = jsonDataManagerProfesseur.DataList;            
            listeClasses = jsonDataManagerClasse.DataList;            
            listeMatieres = jsonDataManagerMatiere.DataList;            
            listeNotes = jsonDataManagerNote.DataList;
        }
        private void buttonGestion2_Click(object sender, EventArgs e)
        {
            //UserControl1 myUserControl = new UserControl1() { Dock= DockStyle.Fill };
            //panelGestion.Controls.Add(myUserControl);
            dataGridViewTest.Visible = false;
            userControl1 = new UserControl1();
            panelGestion.Controls.Add(userControl1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListNiveau = new BindingList<Niveau>(listeNiveaux);
            var sourceNiveau = new BindingSource(bindingListNiveau, null);
            dataGridViewTest.DataSource = sourceNiveau;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListEleve = new BindingList<Eleve>(listeEleves);
            var sourceEleve = new BindingSource(bindingListEleve, null);
            dataGridViewTest.DataSource = sourceEleve;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListProfesseur = new BindingList<Professeur>(listeProfesseurs);
            var sourceProfesseur = new BindingSource(bindingListProfesseur, null);
            dataGridViewTest.DataSource = sourceProfesseur;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListClasse = new BindingList<Classe>(listeClasses);
            var sourceClasse = new BindingSource(bindingListClasse, null);
            dataGridViewTest.DataSource = sourceClasse;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListMatiere = new BindingList<Matiere>(listeMatieres);
            var sourceMatiere = new BindingSource(bindingListMatiere, null);
            dataGridViewTest.DataSource = sourceMatiere;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panelGestion.Controls.Remove(userControl1);
            var bindingListNote = new BindingList<Note>(listeNotes);
            var sourceNote = new BindingSource(bindingListNote, null);
            dataGridViewTest.DataSource = sourceNote;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           importJSON();
        } //Btn load

        private void button2_Click(object sender, EventArgs e)
        {

        } 
        private void button9_Click(object sender, EventArgs e)
        {
            /*
            var jsonDataManager2 = new DAL.JsonDataManager<Models.Professeur>();
            jsonDataManager2.SaveJSonData(listeProfesseurs);
            var jsonDataManager3 = new DAL.JsonDataManager<Models.Eleve>();
            jsonDataManager3.SaveJSonData(listeEleves);
            */
            jsonDataManagerNiveau.SaveJSonData();
            jsonDataManagerEleve.SaveJSonData();
            jsonDataManagerProfesseur.SaveJSonData();
            jsonDataManagerClasse.SaveJSonData();
            jsonDataManagerMatiere.SaveJSonData();
            jsonDataManagerNote.SaveJSonData();
        }//Btn save

        private void button10_Click(object sender, EventArgs e)
        {
            var jdmClasse = new DAL.JsonDataManager<Models.Classe>();
            var jdmNiveau = new DAL.JsonDataManager<Models.Niveau>();

            Classe classe1 = new Classe { Label = "Alpha" };
            Classe classe2 = new Classe { Label = "Beta" };
            List<Classe> classes= new List<Classe>();    
            

            Niveau niveau1 = new Niveau { Label = "CP" , Id = "1" };
            Niveau niveau2 = new Niveau { Label = "CE1", Id = "2" };
            List<Niveau> niveaux = new List<Niveau>();

            classe1.Niveau= niveau1;

            var TestList = jdmClasse.GetWhere();
            var TestId = jdmNiveau.GetById("3");

            classes.Add(classe1);
            classes.Add(classe2);
            niveaux.Add(niveau1);
            niveaux.Add(niveau2);
            //Serialisation :

            jdmClasse.SaveJSonData();
            jdmNiveau.SaveJSonData();

            bool stop = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var jdmEleve = new DAL.JsonDataManager<Models.Eleve>();

            Eleve eleve1 = new Eleve { Nom = "nomEleve1", Prenom = "prenomEleve1", Anciennete = 0 };
            Eleve eleve2 = new Eleve { Nom = "nomEleve2", Prenom = "prenomEleve2", Anciennete = 1 };
            Eleve eleve3 = new Eleve { Nom = "nomEleve3", Prenom = "prenomEleve3", Anciennete = 5 };
            Eleve eleve4 = new Eleve { Nom = "nomEleve4", Prenom = "prenomEleve4", Anciennete = 3 };
            Eleve eleve5 = new Eleve { Nom = "nomEleve5", Prenom = "prenomEleve5", Anciennete = 2 };
            List<Eleve> eleves = new List<Eleve>();
            eleves.Add(eleve1);            eleves.Add(eleve2);
            eleves.Add(eleve3);            eleves.Add(eleve4);
            eleves.Add(eleve5);

            jdmEleve.SaveJSonData();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var eleveJdM = new JsonDataManager<Eleve>();
            var eleveListe = eleveJdM.GetWhere();
            var elevePrenomEleve2 = eleveJdM.GetWhere(item => item.Prenom == "prenomEleve2");
            var eleve37 = eleveJdM.GetById("d0a24f76-4b75-4967-9b0b-87d5757131ca");
            var eleve201 = eleveJdM.GetById("111");

            bool stop = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var classeJdM = new JsonDataManager<Classe>();
            var classeListe = classeJdM.GetWhere();

            var professeurJdM = new JsonDataManager<Professeur>();
            var professeurListe = professeurJdM.GetWhere();

            var prof = professeurJdM.GetWhere(item => item.Nom == "Allart" && item.Prenom == "Maxence");
            var classe = classeJdM.GetWhere(item => item.Label == "Gamma");

            prof[0].ajouterClasse(classe[0]);
            //classe[0].ajouterProfesseur(prof[0]);

            Professeur PROF = prof[0];
            Classe CLASSE = classe[0];

            classeJdM.SaveJSonData();
            professeurJdM.SaveJSonData();

            bool stop = true;
        }
    }
}