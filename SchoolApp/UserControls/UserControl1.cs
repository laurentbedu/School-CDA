using SchoolApp.Models;
using System.ComponentModel;


namespace SchoolApp.UserControls
{
    public partial class UserControl1 : UserControl
    {
        List<Eleve>         listeEleves                                     = new List<Eleve>();
        List<Professeur>    listeProfesseurs                                = new List<Professeur>();
        List<Classe>        listeClasses                                    = new List<Classe>();
        List<Matiere>       listeMatieres                                   = new List<Matiere>();
        List<Niveau>        listeNiveaux                                    = new List<Niveau>();
        List<Note>          listeNotes                                      = new List<Note>();
        DAL.JsonDataManager<Models.Niveau>      jsonDataManagerNiveau       = new DAL.JsonDataManager<Models.Niveau>();
        DAL.JsonDataManager<Models.Eleve>       jsonDataManagerEleve        = new DAL.JsonDataManager<Models.Eleve>();
        DAL.JsonDataManager<Models.Professeur>  jsonDataManagerProfesseur   = new DAL.JsonDataManager<Models.Professeur>();
        DAL.JsonDataManager<Models.Classe>      jsonDataManagerClasse       = new DAL.JsonDataManager<Models.Classe>();
        DAL.JsonDataManager<Models.Matiere>     jsonDataManagerMatiere      = new DAL.JsonDataManager<Models.Matiere>();
        DAL.JsonDataManager<Models.Note>        jsonDataManagerNote         = new DAL.JsonDataManager<Models.Note>();
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
        private void majTabNote()
        {
            var bindingListNote = new BindingList<Note>(listeNotes);
            var sourceNote = new BindingSource(bindingListNote, null);
            dataGridViewNotes.DataSource = sourceNote;
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
            //Boxes notes :
            textBoxValeurNote.Text = string.Empty;
        }
        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        public void majAllJson()
        {            
            listeEleves = jsonDataManagerEleve.DataList;
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Eleve" + ".json";
            textBoxCheminListe.Text = cheminFichierImporter;

            listeProfesseurs = jsonDataManagerProfesseur.DataList;
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Professeur" + ".json";
            textBoxCheminListeProff.Text = cheminFichierImporter;

            listeClasses = jsonDataManagerClasse.DataList;
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Classe" + ".json";
            textBoxCheminListeClasse.Text = cheminFichierImporter;

            listeMatieres = jsonDataManagerMatiere.DataList;
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Matiere" + ".json";
            textBoxCheminListeMatiere.Text = cheminFichierImporter;

            listeNiveaux = jsonDataManagerNiveau.DataList;
             cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
             cheminFichierImporter = cheminRoot + "Niveau" + ".json";
            textBoxCheminListeNiveaux.Text = cheminFichierImporter;

            listeNotes = jsonDataManagerNote.DataList;
            cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            cheminFichierImporter = cheminRoot + "Note" + ".json";
            textBoxCheminListeNote.Text = cheminFichierImporter;

            majAllTab();

        }
        public void majAllTab()
        {
            majTabClasse();
            majTabEleve();
            majTabMatiere();
            majTabNiveau();
            majTabProfesseur();
            majTabNote();
            comboBoxClasseProf.DataSource = listeProfesseurs;
            comboBoxClasseNivea.DataSource = listeNiveaux;
            comboBoxClasse.DataSource = listeClasses;
            comboBoxEleves.DataSource = listeEleves;
            comboBoxEleveClasses.DataSource = listeClasses;
            comboBoxNoteEleves.DataSource = listeEleves;
            comboBoxNoteMatiere.DataSource = listeMatieres;

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
            majAllJson();
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
            majAllTab();
            majAllJson();
        }   // ajouter Professeur  
        // ///////////////////////////////////////////// ///////////////////////////////////////////
        private void buttonAjouterClasse_Click(object sender, EventArgs e)
        {
            string nom              = textBoxNomClasse.Text;
            Classe nouvelleClasse   = new Classe() { Label = nom };
            listeClasses.Add(nouvelleClasse);
            resetBoxes();
            majAllTab();
            majAllJson();
            comboBoxClasse.DataSource = listeClasses;
        }   // ajouter Classe
        private void buttonAjouterMatiere_Click(object sender, EventArgs e) {
            string nom = textBoxNomMatiere.Text;
            Matiere nouvelleMatiere = new Matiere() { label = nom };
            listeMatieres.Add(nouvelleMatiere);
            resetBoxes();
            majAllTab();
            majAllJson();
        }   // ajouter Matiere
        private void buttonAjouterNiveau_Click(object sender, EventArgs e) {
            string nom = textBoxNomNiveau.Text;
            Niveau nouveauNiveau = new Niveau() { Label = nom };
            listeNiveaux.Add(nouveauNiveau);
            resetBoxes();
            majAllTab();
            majAllJson();
        } // ajouter Niveau

        // ///////////////////////////////////////////
        // ///////////////////////////////////////////
        private void buttonChargerListeEleve_Click(object sender, EventArgs e) {
            majAllJson();
            majAllTab();
        }

        private void buttonImportProfs_Click(object sender, EventArgs e) {
            majAllJson();
            majAllTab();
        }
        private void buttonImportClasses_Click(object sender, EventArgs e) {
            majAllJson();
            majAllTab();
        }
        private void buttonImportMatieres_Click_Click(object sender, EventArgs e) {
            majAllJson();
            majAllTab();
        }
        private void buttonImportNiveaux_Click(object sender, EventArgs e) {
            majAllJson();
            majAllTab();
        }
        private void buttonImportNote_Click(object sender, EventArgs e)
        {
            majAllJson();
            majAllTab();
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
        private void buttonExportNote_Click(object sender, EventArgs e)
        {
            jsonDataManagerNote.SaveJSonData();
            //Affichage URL:
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + "Note" + ".json";
            textBoxCheminListeNote.Text = cheminFichierImporter;
            MessageBox.Show("Exportation avec succès!");
        }
        private void buttonClasseLierProf_Click(object sender, EventArgs e)
        {            
            string ClasseSelected = comboBoxClasse.Text;
            string ProfSelected = comboBoxClasseProf.Text;
            string[] ProfSplit = ProfSelected.Split(" ");
            string nomProf = ProfSplit[0];
            string prenomProf = ProfSplit[1];
            
            var classe = jsonDataManagerClasse.GetWhere(item => item.Label == ClasseSelected);
            var prof = jsonDataManagerProfesseur.GetWhere(item => item.Nom == nomProf);

            classe[0].ajouterProfesseur(prof[0]);

            majAllTab();
        }
        private void buttonClasseLierClasse_Click(object sender, EventArgs e)
        {
            string ClasseSelected = comboBoxClasse.Text;
            string NiveauSelected = comboBoxClasseNivea.Text;

            var classe = jsonDataManagerClasse.GetWhere(item => item.Label == ClasseSelected);
            var niveau = jsonDataManagerNiveau.GetWhere(item => item.Label == NiveauSelected);
            
            classe[0].Niveau = niveau[0];

            majAllTab();
        }

        private void buttonEleveLierClasse_Click(object sender, EventArgs e)
        {
            string ClasseSelected = comboBoxEleveClasses.Text;
            string EleveSelected = comboBoxEleves.Text;
            string[] EleveSplit = EleveSelected.Split(" ");
            string nomEleve = EleveSplit[0];
            string prenomEleve = EleveSplit[1];

            var classe = jsonDataManagerClasse.GetWhere(item => item.Label == ClasseSelected);
            var eleve = jsonDataManagerEleve.GetWhere(item => item.Nom == nomEleve);

            classe[0].AddEleve(eleve[0]);

            jsonDataManagerClasse.SaveJSonData();
            jsonDataManagerEleve.SaveJSonData();
            majAllTab();
        }
        private void buttonAjouterNote_Click(object sender, EventArgs e)
        {

            string valeur = textBoxValeurNote.Text;
            Note nouvelleNote = new Note() { Valeur = Convert.ToDouble(valeur) };
            listeNotes.Add(nouvelleNote);

            string EleveSelected = comboBoxNoteEleves.Text;
            string[] EleveSplit = EleveSelected.Split(" ");
            string nomEleve = EleveSplit[0];
            string prenomEleve = EleveSplit[1];

            var eleve = jsonDataManagerEleve.GetWhere(item => item.Nom == nomEleve);
            eleve[0].ajouterNote(nouvelleNote);

            string MatiereSelected = comboBoxNoteMatiere.Text;
            var matiere = jsonDataManagerMatiere.GetWhere(item => item.label == MatiereSelected);

            nouvelleNote.matiereId = matiere[0].Id;

            resetBoxes();
            majAllJson();
            majAllTab();
        } // ajouter note
    }
}