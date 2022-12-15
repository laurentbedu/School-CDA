using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UserControls
{
    public partial class UserControl1 : UserControl
    {
        List<Eleve> listeEleves             = new List<Eleve>();
        List<Professeur> listeProfesseurs   = new List<Professeur>();
        List<Classe> listeClasses           = new List<Classe>();
        List<Matiere> listeMatieres         = new List<Matiere>();
        List<Niveau> listeNiveaux           = new List<Niveau>();
        public UserControl1()
        {
            InitializeComponent();
        }
        private void majTabEleve()
        {
            //dataGridViewEleve.DataSource = listeEleves; // <= ne marche pas / merci stackoverflow =>
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
            dataGridViewEleve.DataSource = sourceNiveau;
        }
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
        // Différents boutons AJOUTER :
        ///////////////////////////////
        private void buttonAjouterEleve_Click(object sender, EventArgs e)
        {
            string nom = textBoxEleveNom.Text;
            string prenom = textBoxElevePrenom.Text;
            string anciennete = textBoxEleveAnciennete.Text;
            Eleve nouvelEleve = new Eleve(nom, prenom, anciennete);
            listeEleves.Add(nouvelEleve);
            resetBoxes();
            majTabEleve();
        }   // ajouter eleve
        private void buttonAjouterProf_Click(object sender, EventArgs e)
        {
            string nom      = textBoxNomProf.Text;
            string prenom   = textBoxPrenomProf.Text;
            string login    = textBoxLoginProf.Text;
            string mdp      = textBoxMdpProf.Text;
            if (checkBoxSuperAdmin.Checked)
            {
                Professeur nouveauProf = new Professeur(nom, prenom, login, mdp) { IsAdmin = true };
                listeProfesseurs.Add(nouveauProf);
            }
            else
            {
                Professeur nouveauProf = new Professeur(nom, prenom, login, mdp) { IsAdmin = false };
                listeProfesseurs.Add(nouveauProf);
            }
            resetBoxes();
            majTabProfesseur();
        }   // ajouter Professeur  
        private void buttonAjouterClasse_Click(object sender, EventArgs e)
        {
            string nom              = textBoxNomClasse.Text;
            Classe nouvelleClasse   = new Classe() { Nom = nom };
            listeClasses.Add(nouvelleClasse);
            resetBoxes();
            majTabClasse();
        }   // ajouter Classe
        private void buttonAjouterMatiere_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomMatiere.Text;
            Matiere nouvelleMatiere = new Matiere() { Nom = nom };
            listeMatieres.Add(nouvelleMatiere);
            resetBoxes();
            majTabMatiere();
        }   // ajouter Matiere

        private void buttonSauvegarderListeEleve_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (textBoxCheminListe.Text != "")
            {
                saveFileDialog1.InitialDirectory = textBoxCheminListe.Text;
            }
            string[] toSave = listeEleves.Select(i => now + "--" + i.ToStringPourSave()).ToArray(); // merci stackoverflow
            string? cheminFicherExporter = ""; // ? car non nullable.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cheminFicherExporter = Path.GetDirectoryName(saveFileDialog1.FileName);
            }
            textBoxCheminListe.Text = cheminFicherExporter;
            File.AppendAllLines(saveFileDialog1.FileName, toSave);
        }

        private void buttonChargerListeEleve_Click(object sender, EventArgs e)
        {
            string cheminFichierImporter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cheminFichierImporter = Path.GetFullPath(openFileDialog1.FileName);
            }
            string[] toLoad = (File.ReadAllLines(cheminFichierImporter));

            for (int i = 0; i < toLoad.Length; i++)
            {
                toLoad[i] = toLoad[i].Remove(0, 21); // pour retirer la date et le -- qui prend 21 char.
                string[] aDecomposer = toLoad[i].Split(' ');
                string newNom = aDecomposer[0];
                string newPrenom = aDecomposer[1];
                string newAnciennete = aDecomposer[2];
                listeEleves.Add(new Eleve(newNom, newPrenom, "1an"));
                majTabEleve();
            }
        }


    }
}
