using SchoolApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class FormGestion : Form
    {
        List<Eleve> listeEleves = new List<Eleve>();
        List<Professeur> listeProfesseurs = new List<Professeur>();
        public FormGestion()
        {
            InitializeComponent();
        }
        private void majDataGridView()
        {
            //dataGridViewEleve.DataSource = listeEleves; // <= ne marche pas / merci stackoverflow =>
            var bindingList = new BindingList<Eleve>(listeEleves);
            var source = new BindingSource(bindingList, null);
            dataGridViewEleve.DataSource = source;
        }
        private void resetBoxes()
        {
            textBoxEleveNom.Text            = "";
            textBoxElevePrenom.Text         = "";
            textBoxEleveAnciennete.Text     = "";
        }
        private void buttonAjouterEleve_Click(object sender, EventArgs e)
        {
            string nom          = textBoxEleveNom.Text;
            string prenom       = textBoxElevePrenom.Text;
            string anciennete   = textBoxEleveAnciennete.Text;
            Eleve nouvelEleve   = new Eleve(nom, prenom, anciennete);
            listeEleves.Add(nouvelEleve);
            resetBoxes();
            majDataGridView();
        }
        private void buttonSauvegarderListeEleve_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (textBoxCheminListe.Text != "")
            {
                saveFileDialog1.InitialDirectory = textBoxCheminListe.Text;
            }
            string[] toSave = listeEleves.Select(i => now + "--" + i.ToString()).ToArray(); // merci stackoverflow
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

            for (int i = 0; i<toLoad.Length; i++)
            {
                toLoad[i] = toLoad[i].Remove(0, 21); // pour retirer la date et le -- qui prend 21 char.
                string[] aDecomposer= toLoad[i].Split(' ');
                string newNom       = aDecomposer[0];
                string newPrenom    = aDecomposer[1];
                string newAnciennete= aDecomposer[2];
                listeEleves.Add(new Eleve(newNom, newPrenom, "1an"));
                majDataGridView();
            }
        }
    }
}
