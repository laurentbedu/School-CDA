using SchoolApp.DAL;
using SchoolApp.Models;
using System.Collections.Generic;
using System.ComponentModel;


namespace SchoolApp.UserControls
{
    public partial class UserControl1 : UserControl
    {
        List<Eleve> listeEleves = new List<Eleve>();
        List<Professeur> listeProfesseurs = new List<Professeur>();
        List<Classe> listeClasses = new List<Classe>();
        List<Matiere> listeMatieres = new List<Matiere>();
        List<Niveau> listeNiveaux = new List<Niveau>();
        List<Note> listeNotes = new List<Note>();
        DAL.JsonDataManager<Models.Niveau> jsonDataManagerNiveau = new DAL.JsonDataManager<Models.Niveau>();
        DAL.JsonDataManager<Models.Eleve> jsonDataManagerEleve = new DAL.JsonDataManager<Models.Eleve>();
        DAL.JsonDataManager<Models.Professeur> jsonDataManagerProfesseur = new DAL.JsonDataManager<Models.Professeur>();
        DAL.JsonDataManager<Models.Classe> jsonDataManagerClasse = new DAL.JsonDataManager<Models.Classe>();
        DAL.JsonDataManager<Models.Matiere> jsonDataManagerMatiere = new DAL.JsonDataManager<Models.Matiere>();
        DAL.JsonDataManager<Models.Note> jsonDataManagerNote = new DAL.JsonDataManager<Models.Note>();

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
            var bindingListEleve = new BindingList<Eleve>(listeEleves);
            var sourceEleve = new BindingSource(bindingListEleve, null);
            dataGridViewEleve.DataSource = sourceEleve;
        }
        private void majTabProfesseur()
        {
            var bindingListProfesseur = new BindingList<Professeur>(listeProfesseurs);
            var sourceProfesseur = new BindingSource(bindingListProfesseur, null);
            dataGridViewProfesseurs.DataSource = sourceProfesseur;
        }
        private void majTabClasse()
        {
            var bindingListClasse = new BindingList<Classe>(listeClasses);
            var sourceClasse = new BindingSource(bindingListClasse, null);
            dataGridViewClasse.DataSource = sourceClasse;
        }
        private void majTabMatiere()
        {
            var bindingListMatiere = new BindingList<Matiere>(listeMatieres);
            var sourceMatiere = new BindingSource(bindingListMatiere, null);
            dataGridViewMatiere.DataSource = sourceMatiere;
        }
        private void majTabNiveau()
        {
            var bindingListNiveau = new BindingList<Niveau>(listeNiveaux);
            var sourceNiveau = new BindingSource(bindingListNiveau, null);
            dataGridViewNiveaux.DataSource = sourceNiveau;
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
            textBoxLoginProf.Text = string.Empty;
            textBoxMdpProf.Text = string.Empty;
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
        }
        public void majCheminJSON()
        {
            textBoxCheminListe.Text         = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Eleve" + ".json";
            textBoxCheminListeProff.Text    = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Professeur" + ".json";
            textBoxCheminListeClasse.Text   = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Classe" + ".json";
            textBoxCheminListeMatiere.Text  = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Matiere" + ".json";
            textBoxCheminListeNiveaux.Text  = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Niveau" + ".json";
            textBoxCheminListeNote.Text     = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - 25) + "\\JSON\\" + "Note" + ".json";
        }
        public void ImportFromJSON()
        {
            listeEleves = jsonDataManagerEleve.DataList;
            listeProfesseurs = jsonDataManagerProfesseur.DataList;
            listeClasses = jsonDataManagerClasse.DataList;
            listeMatieres = jsonDataManagerMatiere.DataList;
            listeNiveaux = jsonDataManagerNiveau.DataList;
            listeNotes = jsonDataManagerNote.DataList;
        }
        public void majDataSource()
        {
            //Maj des combos box après un ajout/suppression.
            comboBoxClasseProf.DataSource = null;
            comboBoxClasseProf.DataSource = listeProfesseurs;
            comboBoxClasseNivea.DataSource = null;
            comboBoxClasseNivea.DataSource = listeNiveaux;
            comboBoxClasse.DataSource = null;
            comboBoxClasse.DataSource = listeClasses;
            comboBoxEleves.DataSource = null;
            comboBoxEleves.DataSource = listeEleves;
            comboBoxEleveClasses.DataSource = null;
            comboBoxEleveClasses.DataSource = listeClasses;
            comboBoxNoteEleves.DataSource = null;
            comboBoxNoteEleves.DataSource = listeEleves;
            comboBoxNoteMatiere.DataSource = null;
            comboBoxNoteMatiere.DataSource = listeMatieres;
            comboBoxProfProf.DataSource = null;
            comboBoxProfProf.DataSource = listeProfesseurs;
        }
        public void majAllTab()
        {
            var bindingListEleve = new BindingList<Eleve>(listeEleves);
            var sourceEleve = new BindingSource(bindingListEleve, null);
            dataGridViewEleve.DataSource = sourceEleve;

            var bindingListProfesseur = new BindingList<Professeur>(listeProfesseurs);
            var sourceProfesseur = new BindingSource(bindingListProfesseur, null);
            dataGridViewProfesseurs.DataSource = sourceProfesseur;

            var bindingListClasse = new BindingList<Classe>(listeClasses);
            var sourceClasse = new BindingSource(bindingListClasse, null);
            dataGridViewClasse.DataSource = sourceClasse;

            var bindingListMatiere = new BindingList<Matiere>(listeMatieres);
            var sourceMatiere = new BindingSource(bindingListMatiere, null);
            dataGridViewMatiere.DataSource = sourceMatiere;

            var bindingListNiveau = new BindingList<Niveau>(listeNiveaux);
            var sourceNiveau = new BindingSource(bindingListNiveau, null);
            dataGridViewNiveaux.DataSource = sourceNiveau;

            var bindingListNote = new BindingList<Note>(listeNotes);
            var sourceNote = new BindingSource(bindingListNote, null);
            dataGridViewNotes.DataSource = sourceNote;
        }
        // Différents boutons AJOUTER :
        ///////////////////////////////
        private void buttonAjouterEleve_Click(object sender, EventArgs e)
        {
            string nom = textBoxEleveNom.Text;
            string prenom = textBoxElevePrenom.Text;
            string anciennete = textBoxEleveAnciennete.Text;
            Eleve nouvelEleve = new Eleve { Nom = nom, Prenom = prenom, Anciennete = Convert.ToInt16(anciennete) };
            listeEleves.Add(nouvelEleve);
            resetBoxes();
            majAllTab();
            majDataSource();
            majCheminJSON();
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
            majDataSource();
            majCheminJSON();
        }   // ajouter Professeur  
        private void buttonAjouterClasse_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomClasse.Text;
            Classe nouvelleClasse = new Classe() { Label = nom };
            listeClasses.Add(nouvelleClasse);
            resetBoxes();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }   // ajouter Classe
        private void buttonAjouterMatiere_Click(object sender, EventArgs e) {
            string nom = textBoxNomMatiere.Text;
            Matiere nouvelleMatiere = new Matiere() { label = nom };
            listeMatieres.Add(nouvelleMatiere);
            resetBoxes();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }   // ajouter Matiere
        private void buttonAjouterNiveau_Click(object sender, EventArgs e) {
            string nom = textBoxNomNiveau.Text;
            Niveau nouveauNiveau = new Niveau() { Label = nom };
            listeNiveaux.Add(nouveauNiveau);
            resetBoxes();
            majAllTab();
            majDataSource();
            majCheminJSON();
        } // ajouter Niveau
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
            majAllTab();
            majDataSource();
            majCheminJSON();
        } // ajouter note
        /////////////////////////////////////////////
        /////////////////////////////////////////////
        /////////////////////////////////////////////
        /////////////////////////////////////////////
        private void buttonChargerListeEleve_Click(object sender, EventArgs e)
        {
            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }

        private void buttonImportProfs_Click(object sender, EventArgs e)
        {

            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }
        private void buttonImportClasses_Click(object sender, EventArgs e)
        {
            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }
        private void buttonImportMatieres_Click_Click(object sender, EventArgs e)
        {
            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }
        private void buttonImportNiveaux_Click(object sender, EventArgs e)
        {
            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
        }
        private void buttonImportNote_Click(object sender, EventArgs e)
        {
            ImportFromJSON();
            majAllTab();
            majDataSource();
            majCheminJSON();
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
        /////////////////////////////////
        /////////////////////////////////
        /////////////////////////////////
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
            majDataSource();
            majCheminJSON();
        }
        private void buttonClasseLierClasse_Click(object sender, EventArgs e)
        {
            string ClasseSelected = comboBoxClasse.Text;
            string NiveauSelected = comboBoxClasseNivea.Text;

            var classe = jsonDataManagerClasse.GetWhere(item => item.Label == ClasseSelected);
            var niveau = jsonDataManagerNiveau.GetWhere(item => item.Label == NiveauSelected);
            
            classe[0].Niveau = niveau[0];

            majAllTab();
            majDataSource();
            majCheminJSON();
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

            majAllTab();
            majDataSource();
            majCheminJSON();
        }


        private void buttonRetirerEleve_Click(object sender, EventArgs e)
        {
            string EleveSelected = comboBoxNoteEleves.Text;
            string[] EleveSplit = EleveSelected.Split(" ");
            string nomEleve = EleveSplit[0];
            string prenomEleve = EleveSplit[1];
            
            var eleve = jsonDataManagerEleve.GetWhere(item => item.Nom == nomEleve);
            var classe = jsonDataManagerClasse.GetWhere(item => item.Id == eleve[0].classeId);

            listeEleves.Remove(eleve[0]);
            classe[0].EleveList.Remove(eleve[0]);

            majAllTab();
            majDataSource();
            majCheminJSON();

        }
        private void buttonRetirerProf_Click(object sender, EventArgs e)
        {
            string ProfSelected = comboBoxProfProf.Text;
            string[] ProfSplit = ProfSelected.Split(" ");
            string nomProf = ProfSplit[0];
            string prenomProf = ProfSplit[1];

            var prof = jsonDataManagerProfesseur.GetWhere(item => item.Nom == nomProf);
            var classe = jsonDataManagerClasse.GetWhere(item => item.Id == prof[0].classeId);

            classe[0].retirerProfesseur(prof[0]);
            prof[0].retirerClasse(classe[0]);
            listeProfesseurs.Remove(prof[0]);

            majAllTab();
            majDataSource();
            majCheminJSON();
        }

    }
}