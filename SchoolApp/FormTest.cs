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


        public FormTest()
        {
            InitializeComponent();
        }
        public void importJSON()
        {            
            dataGridViewTest.Visible = true;
            var jsonDataManagerNiveau = new DAL.JsonDataManager<Models.Niveau>();
            listeNiveaux = jsonDataManagerNiveau.DataList;
            var jsonDataManagerEleve = new DAL.JsonDataManager<Models.Eleve>();
            listeEleves = jsonDataManagerEleve.DataList;
            var jsonDataManagerProfesseur = new DAL.JsonDataManager<Models.Professeur>();
            listeProfesseurs = jsonDataManagerProfesseur.DataList;
            var jsonDataManagerClasse = new DAL.JsonDataManager<Models.Classe>();
            listeClasses = jsonDataManagerClasse.DataList;
            var jsonDataManagerMatiere = new DAL.JsonDataManager<Models.Matiere>();
            listeMatieres = jsonDataManagerMatiere.DataList;
            var jsonDataManagerNote = new DAL.JsonDataManager<Models.Note>();
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
            /*
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> ListeNiveau = new List<Niveau>();
            Niveau cp = new Niveau()  { Nom = "CP" };
            Niveau ce1 = new Niveau() { Nom = "CE1" };
            Niveau ce2 = new Niveau() { Nom = "CE2" };
            Niveau cm1 = new Niveau() { Nom = "CM1" };
            ListeNiveau.Add(cp);
            ListeNiveau.Add(ce1);
            ListeNiveau.Add(ce2);
            ListeNiveau.Add(cm1);
            //SÚrialise :
            jsonDataManager.SaveJSonData(ListeNiveau);
            */

            /*
            var jsonDataManager2 = new DAL.JsonDataManager<Models.Professeur>();
            List<Professeur> ListeProf = new List<Professeur>();
            */
            /*
            Professeur prof1 = new Professeur() { Nom = "Allart", Prenom = "Maxence", Login = "admin", Password= "admin", IsAdmin=true };
            Professeur prof2 = new Professeur() { Nom = "Billy" , Prenom = "Bob"    , Login = "admin", Password= "admin", IsAdmin=false };
            Professeur prof3 = new Professeur() { Nom = "Toto"  , Prenom = "Tata"   , Login = "admin", Password= "admin", IsAdmin=false };
            Classe newClasse = new Classe() { Nom = "CLASSENAME" };
            prof1.ajouterClasse(newClasse);
            prof2.ajouterClasse(newClasse);
            prof3.ajouterClasse(newClasse);
            listeProfesseurs.Add(prof1);
            listeProfesseurs.Add(prof2);
            listeProfesseurs.Add(prof3);
            */
            //SÚrialise :
            //jsonDataManager2.SaveJSonData(ListeProfesseurs);

            Random rnd = new Random();
            for ( int i = 0 ; i < listeProfesseurs.Count ; i++ )
            {
                Professeur prof = listeProfesseurs[i];
                Classe classe = listeClasses[i];
                prof.ajouterClasse(classe);
            }     
            for ( int i = 0 ; i < listeClasses.Count ; i++ )
            {
                Classe classe = listeClasses[i];
                classe.Niveau = listeNiveaux[rnd.Next(listeNiveaux.Count)];                
            }
            for (int i = 0; i < listeEleves.Count; i++)
            {
                Eleve eleve = listeEleves[i];
                eleve.Classe = listeClasses[rnd.Next(listeClasses.Count)];
            }
            for (int i = 0; i < listeEleves.Count; i++)
            {
                Eleve eleve = listeEleves[i];
                eleve.ajouterNote(listeNotes[i]);
            }
            for ( int i = 0; i < listeNotes.Count; i++)
            {
                Note note = listeNotes[i];
                note.Matiere = listeMatieres[rnd.Next(listeMatieres.Count)];
            }
        } 
        private void button9_Click(object sender, EventArgs e)
        {
            var jsonDataManager2 = new DAL.JsonDataManager<Models.Professeur>();
            jsonDataManager2.SaveJSonData(listeProfesseurs);
        }//Btn save
    }
}