using Microsoft.VisualBasic;
using SchoolApp.DAL;
using SchoolApp.Models;
using SchoolApp.UserControls;
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
        UserControl1 userControl1;

        public FormTest()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void buttonGestion2_Click(object sender, EventArgs e)
        {
            //UserControl1 myUserControl = new UserControl1() { Dock= DockStyle.Fill };
            //panelGestion.Controls.Add(myUserControl);
            userControl1 = new UserControl1();
            panelGestion.Controls.Add(userControl1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Matiere math    = new Matiere() { Nom = "Math" };
            Matiere french  = new Matiere() { Nom = "Français" };
            Matiere english = new Matiere() { Nom = "Anglais" };

            Niveau cp   = new Niveau() { Nom = "CP" };
            Niveau ce1  = new Niveau() { Nom = "CE1" };
            Niveau ce2  = new Niveau() { Nom = "CE2" };
            Niveau cm1  = new Niveau() { Nom = "CM1" };

            // Possible grace à params
            cp.ajouterMatiere(math, french);
            ce1.ajouterMatiere(math, english, french);
            // Ajouter plusieurs matieres d'un coup:
            Matiere[] matiereArray = new Matiere[] { math, french };
            ce2.ajouterMatiere(matiereArray);
            // Methode classique :
            cm1.ajouterMatiere(math);
            cm1.ajouterMatiere(french);
            cm1.ajouterMatiere(english);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            //Desérialise :
            List<Niveau> newList = jsonDataManager.DataList;
            //debugg pour voir la liste :
            for (int i = 0; i < newList.Count; i++)
            {
                MessageBox.Show(Convert.ToString(newList[i]));
            }

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
            //Sérialise :
            jsonDataManager.SaveJSonData(ListeNiveau);
            */

            
            var jsonDataManager2 = new DAL.JsonDataManager<Models.Professeur>();
            List<Professeur> ListeProf = new List<Professeur>();
            Professeur prof1 = new Professeur() { Nom = "Allart", Prenom="Maxence", Login = "admin", Password= "admin", IsAdmin=true };
            Professeur prof2 = new Professeur() { Nom = "Billy", Prenom = "Bob", Login = "admin", Password= "admin", IsAdmin=false };
            Professeur prof3 = new Professeur() { Nom = "Toto", Prenom = "Tata", Login = "admin", Password= "admin", IsAdmin=false };
            ListeProf.Add(prof1);
            ListeProf.Add(prof2);
            ListeProf.Add(prof3);
            //Sérialise :
            jsonDataManager2.SaveJSonData(ListeProf);
            

        } //Btn save
    }
}