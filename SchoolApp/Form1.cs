using SchoolApp.Models;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            niveauList = new List<Niveau>
            {
                new Niveau() { Label = "CP" },
                new Niveau() { Label = "CE1"},
                new Niveau() { Label = "CE2"},
                new Niveau() { Label = "CM1"},
                new Niveau() { Label = "CM2"}
            };
            matiereList = new List<Matiere> {
                new Matiere() {Label = "Mathématique"},
                new Matiere() {Label = "Français"},
                new Matiere() {Label = "Anglais"},
                new Matiere() {Label = "Sciences"},
                new Matiere() {Label = "Histoire"},
                new Matiere() {Label = "Géographie"}
            };
            niveauList.Find(e => e.Label == "CP")?.AddMatieres(matiereList[0], matiereList[1]);
            niveauList.Find(e => e.Label == "CE1")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2]);
            niveauList.Find(e => e.Label == "CE2")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2], matiereList[3]);
            niveauList.Find(e => e.Label == "CM1")?.AddMatieres(matiereList[0], matiereList[1], matiereList[2], matiereList[3], matiereList[4]);
            niveauList.Find(e => e.Label == "CM2")?.AddMatieres(matiereList.ToArray());

            cbNiveauClasse.DataSource = niveauList;
        }

        Professeur? professeur;
        private void button1_Click_1(object sender, EventArgs e)
        {
            professeur = new Professeur()
            {
                Nom = tbProfesseurNom.Text,
                Prenom = tbProfesseurPrenom.Text,
                Login = tbProfesseurLogin.Text,
                Password = TbProfesseurPassword.Text,
            };
            MessageBox.Show(professeur + "");
        }

        Classe? classe;
        List<Niveau> niveauList;

        private void button2_Click(object sender, EventArgs e)
        {
            classe = new Classe()
            {
                Label = tbClasseLabel.Text,
                Niveau = cbNiveauClasse.SelectedItem as Niveau
            };
            MessageBox.Show(classe + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            professeur.AddClasse(classe);
            MessageBox.Show(professeur + "\n" + professeur.Classe?.ToString(true));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            professeur.RemoveClasse(classe);
            MessageBox.Show(professeur + "\n" + professeur.Classe?.ToString(true));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            classe.AddProfesseur(professeur);
            MessageBox.Show(classe + "\n" + classe.Professeur?.ToString(true));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            classe.RemoveProfesseur(professeur);
            MessageBox.Show(classe + "\n" + classe.Professeur?.ToString(true));
        }

        Eleve eleve;
        private void button7_Click(object sender, EventArgs e)
        {
            eleve = new Eleve()
            {
                Nom = tbEleveNom.Text,
                Prenom = tbElevePrenom.Text,
            };
            MessageBox.Show(eleve + "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eleve.Classe = classe;
            cbMatiere.DataSource = eleve.Classe.Niveau.MatiereList;
            MessageBox.Show(eleve + "");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eleve.Classe = null;
            cbMatiere.DataSource = null;
            MessageBox.Show(eleve + "");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            classe.AddEleve(eleve);
            MessageBox.Show(classe + "\n Nb eleve :" + classe.EleveList.Count);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            classe.RemoveEleve(eleve);
            MessageBox.Show(classe + "\n Nb eleve :" + classe.EleveList.Count);
        }

        List<Matiere> matiereList;

        private void button12_Click(object sender, EventArgs e)
        {
            Note note = new Note() { Eleve = eleve, Matiere = (Matiere)cbMatiere.SelectedItem, Valeur = Double.Parse(nudNoteValeur.Value.ToString()) };
            eleve.AddNote(note);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Matiere math = new Matiere() { Label = "Math" };
            Matiere french = new Matiere() { Label = "Français" };
            Matiere english = new Matiere() { Label = "Anglais" };

            Niveau cp = new Niveau() { Label = "CP" };
            Niveau ce1 = new Niveau() { Label = "CE1" };
            Niveau ce2 = new Niveau() { Label = "CE2" };

            cp.AddMatieres(math, french);
            ce1.AddMatieres(math, english, french);

            Matiere[] matiereArray = new Matiere[] { math, french };
            ce2.AddMatieres(matiereArray);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var jsonDataManager = new DAL.JsonDataManager<Models.Niveau>();
            List<Niveau> list = jsonDataManager.DataList;
        }
    }
}