using SchoolApp.Models;
using System.ComponentModel;


namespace SchoolApp.UserControls
{
    public partial class UserControl1 : UserControl
    {
        List<Eleve>     listeEleves                                         = new List<Eleve>();
        DAL.JsonDataManager<Models.Eleve> jsonDataManagerEleve              = new DAL.JsonDataManager<Models.Eleve>();

        List<Professeur>listeProfesseurs                                    = new List<Professeur>();
        DAL.JsonDataManager<Models.Professeur> jsonDataManagerProfesseur    = new DAL.JsonDataManager<Models.Professeur>();

        List<Classe>    listeClasses                                        = new List<Classe>();
        DAL.JsonDataManager<Models.Classe> jsonDataManagerClasse            = new DAL.JsonDataManager<Models.Classe>();

        List<Matiere>   listeMatieres                                       = new List<Matiere>();
        DAL.JsonDataManager<Models.Matiere> jsonDataManagerMatiere          = new DAL.JsonDataManager<Models.Matiere>();

        List<Niveau>    listeNiveaux                                        = new List<Niveau>();
        DAL.JsonDataManager<Models.Niveau> jsonDataManagerNiveau            = new DAL.JsonDataManager<Models.Niveau>();

        List<Note>      listeNotes                                          = new List<Note>();
        DAL.JsonDataManager<Models.Note> jsonDataManagerNote                = new DAL.JsonDataManager<Models.Note>();
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        public UserControl1()
        {
            InitializeComponent();            
        }
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        private void majTabEleve()
        {
            var bindingListEleve                = new BindingList<Eleve>(listeEleves);
            var sourceEleve                     = new BindingSource(bindingListEleve, null);
            dataGridViewEleve.DataSource        = sourceEleve;
        }
        private void majTabProfesseur()
        {
            var bindingListProfesseur           = new BindingList<Professeur>(listeProfesseurs);
            var sourceProfesseur                = new BindingSource(bindingListProfesseur, null);
            dataGridViewProfesseurs.DataSource  = sourceProfesseur;
        }
        private void majTabClasse()
        {
            var bindingListClasse               = new BindingList<Classe>(listeClasses);
            var sourceClasse                    = new BindingSource(bindingListClasse, null);
            dataGridViewClasse.DataSource       = sourceClasse;
        }
        private void majTabMatiere()
        {
            var bindingListMatiere              = new BindingList<Matiere>(listeMatieres);
            var sourceMatiere                   = new BindingSource(bindingListMatiere, null);
            dataGridViewMatiere.DataSource      = sourceMatiere;
        }
        private void majTabNiveau()
        {
            var bindingListNiveau               = new BindingList<Niveau>(listeNiveaux);
            var sourceNiveau                    = new BindingSource(bindingListNiveau, null);
            dataGridViewNiveaux.DataSource      = sourceNiveau;
        }
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        private void resetBoxes()
        {
            //Boxes eleve:
            textBoxEleveNom.Text = "";
            textBoxElevePrenom.Text = "";
            textBoxEleveAnciennete.Text = "";
            //Boxes Classe:
            textBoxNomClasse.Text = "";
            //Boxes Prof:
            textBoxNomProf.Text = string.Empty;
            textBoxPrenomProf.Text = string.Empty;
            textBoxLoginProf.Text= string.Empty;
            textBoxMdpProf.Text= string.Empty;
        }
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        public void majAllJson()
        {
            listeEleves = jsonDataManagerEleve.DataList;
            majTabEleve();
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Eleve" + ".json";
            textBoxCheminListe.Text = cheminFichierImporter;

            listeProfesseurs = jsonDataManagerProfesseur.DataList;
            majTabProfesseur();
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Professeur" + ".json";
            textBoxCheminListeProff.Text = cheminFichierImporter;

            listeClasses = jsonDataManagerClasse.DataList;
            majTabClasse();
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Classe" + ".json";
            textBoxCheminListeClasse.Text = cheminFichierImporter;

            listeMatieres = jsonDataManagerMatiere.DataList;
            majTabMatiere();
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Matiere" + ".json";
            textBoxCheminListeMatiere.Text = cheminFichierImporter;

            listeNiveaux = jsonDataManagerNiveau.DataList;
            majTabNiveau();
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Niveau" + ".json";
            textBoxCheminListeNiveaux.Text = cheminFichierImporter;
        }
        // Différents boutons AJOUTER :
        ///////////////////////////////
        private void buttonAjouterEleve_Click(object sender, EventArgs e)
        {
            string nom = textBoxEleveNom.Text;
            string prenom = textBoxElevePrenom.Text;
            string anciennete = textBoxEleveAnciennete.Text;
            Eleve nouvelEleve = new Eleve{ Nom = nom, Prenom = prenom, Anciennete = Convert.ToInt16(anciennete)};
            listeEleves.Add(nouvelEleve);
            resetBoxes();
            majTabEleve();
        }   // ajouter eleve
        private void buttonAjouterProf_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomProf.Text;
            string prenom = textBoxPrenomProf.Text;
            string login = textBoxLoginProf.Text;
            string mdp = textBoxMdpProf.Text;
            if (checkBoxSuperAdmin.Checked) {
                Professeur nouveauProf = new Professeur { Nom = nom, Prenom = prenom, Login = login, Password = mdp, IsAdmin = true };
                listeProfesseurs.Add(nouveauProf);
            }
            else {
                Professeur nouveauProf = new Professeur { Nom = nom, Prenom = prenom, Login = login, Password = mdp, IsAdmin = false };
                listeProfesseurs.Add(nouveauProf);
            }
            resetBoxes();
            majTabProfesseur();
        }   // ajouter Professeur  
        // ///////////////////////////////////////////// ///////////////////////////////////////////
        private void buttonAjouterClasse_Click(object sender, EventArgs e)
        {
            string nom              = textBoxNomClasse.Text;
            Classe nouvelleClasse   = new Classe() { Label = nom };
            listeClasses.Add(nouvelleClasse);
            resetBoxes();
            majTabClasse();
        }   // ajouter Classe
        private void buttonAjouterMatiere_Click(object sender, EventArgs e) {
            string nom = textBoxNomMatiere.Text;
            Matiere nouvelleMatiere = new Matiere() { label = nom };
            listeMatieres.Add(nouvelleMatiere);
            resetBoxes();
            majTabMatiere();
        }   // ajouter Matiere
        private void buttonAjouterNiveau_Click(object sender, EventArgs e) {
            string nom = textBoxNomNiveau.Text;
            Niveau nouveauNiveau = new Niveau() { Label = nom };
            listeNiveaux.Add(nouveauNiveau);
            resetBoxes();
            majTabNiveau();
        } // ajouter Niveau
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        private void buttonChargerListeEleve_Click(object sender, EventArgs e) {
            majAllJson();
        }

        private void buttonImportProfs_Click(object sender, EventArgs e) {
            majAllJson();
        }
        private void buttonImportClasses_Click(object sender, EventArgs e) {
            majAllJson();
        }
        private void buttonImportMatieres_Click_Click(object sender, EventArgs e) {
            majAllJson();
        }
        private void buttonImportNiveaux_Click(object sender, EventArgs e) {
            majAllJson();
        }
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        private void buttonSauvegarderListeEleve_Click(object sender, EventArgs e) {
            jsonDataManagerEleve.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Eleve" + ".json";
            textBoxCheminListe.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }
        private void buttonExportProfs_Click(object sender, EventArgs e) {
            jsonDataManagerProfesseur.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Professeur" + ".json";
            textBoxCheminListeProff.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }
        private void buttonExportClasses_Click(object sender, EventArgs e) {
            jsonDataManagerClasse.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Classe" + ".json";
            textBoxCheminListeClasse.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }
        private void buttonExportMatiere_Click_Click(object sender, EventArgs e) {
            jsonDataManagerMatiere.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Matiere" + ".json";
            textBoxCheminListeMatiere.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }
        private void buttonExportNiveaux_Click(object sender, EventArgs e) {
            jsonDataManagerNiveau.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Niveau" + ".json";
            textBoxCheminListeNiveaux.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }

    }
}