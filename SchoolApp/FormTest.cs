using SchoolApp.Models;
using SchoolApp.UserControls;

namespace SchoolApp
{
    public partial class FormTest : Form
    {
        List<Eleve>         listeEleves         = new List<Eleve>();
        List<Professeur>    listeProfesseurs    = new List<Professeur>();
        List<Classe>        listeClasses        = new List<Classe>();
        List<Matiere>       listeMatieres       = new List<Matiere>();

        public FormTest()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGestion2_Click(object sender, EventArgs e)
        {
            UserControl1 myUserControl = new UserControl1() { Dock= DockStyle.Fill };
            panelGestion.Controls.Add(myUserControl);
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
    }
}