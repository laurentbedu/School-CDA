using System.Runtime.ConstrainedExecution;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeNiveaux();
            InitializeClasses();
        }
        List<Classe> classes = new List<Classe>();
        Niveau cp;
        Niveau ce1;
        Niveau ce2;
        Niveau cm1;
        Niveau cm2;

        public void InitializeNiveaux()
        {
            cp = new Niveau() { id_niveau = "001", label = "CP" };
            ce1 = new Niveau() { id_niveau = "002", label = "CE1" };
            ce2 = new Niveau() { id_niveau = "003", label = "CE2" };
            cm1 = new Niveau() { id_niveau = "004", label = "CM1" };
            cm2 = new Niveau() { id_niveau = "005", label = "CM2" };

        }
        public void InitializeClasses()
        {
            Classe CP_1 = new Classe() { id_classe = 0011, label = "CP_1", niveau = cp };
            classes.Add(CP_1);
            comboBoxClasseEleve.Items.Add(CP_1.ToString());
            comboBoxClasseProf.Items.Add(CP_1.ToString());
            Classe CP_2 = new Classe() { id_classe = 0012, label = "CP_2", niveau = cp };
            classes.Add(CP_2);
            comboBoxClasseEleve.Items.Add(CP_2.ToString());
            comboBoxClasseProf.Items.Add(CP_2.ToString());
            Classe CP_3 = new Classe() { id_classe = 0013, label = "CP_3", niveau = cp };
            classes.Add(CP_3);
            comboBoxClasseEleve.Items.Add(CP_3.ToString());
            comboBoxClasseProf.Items.Add(CP_3.ToString());
            Classe CE1_1 = new Classe() { id_classe = 0021, label = "CE1_1", niveau = ce1 };
            classes.Add(CE1_1);
            comboBoxClasseEleve.Items.Add(CE1_1.ToString());
            comboBoxClasseProf.Items.Add(CE1_1.ToString());
            Classe CE1_2 = new Classe() { id_classe = 0022, label = "CE1_2", niveau = ce1 };
            classes.Add(CE1_2);
            comboBoxClasseEleve.Items.Add(CE1_2.ToString());
            comboBoxClasseProf.Items.Add(CE1_2.ToString());
            Classe CE2_1 = new Classe() { id_classe = 0031, label = "CE2_1", niveau = ce2 };
            classes.Add(CE2_1);
            comboBoxClasseEleve.Items.Add(CE2_1.ToString());
            comboBoxClasseProf.Items.Add(CE2_1.ToString());
            Classe CE2_2 = new Classe() { id_classe = 0032, label = "CE2_2", niveau = ce2 };
            classes.Add(CE2_2);
            comboBoxClasseEleve.Items.Add(CE2_2.ToString());
            comboBoxClasseProf.Items.Add(CE2_2.ToString());
            Classe CM1_1 = new Classe() { id_classe = 0041, label = "CM1_1", niveau = cm1 };
            classes.Add(CM1_1);
            comboBoxClasseEleve.Items.Add(CM1_1.ToString());
            comboBoxClasseProf.Items.Add(CM1_1.ToString());
            Classe CM2_1 = new Classe() { id_classe = 0051, label = "CM2_1", niveau = cm2 };
            classes.Add(CM2_1);
            comboBoxClasseEleve.Items.Add(CM2_1.ToString());
            comboBoxClasseProf.Items.Add(CM2_1.ToString());

        }

        private void buttonAddEleve_Click(object sender, EventArgs e)
        {
            string nom = textBoxNomEleve.Text;
            string prenom = textBoxPrenomEleve.Text;
            Classe classe = classes.GetValueOrDefault(comboBoxClasseEleve.SelectedItem);
            int anciennete = numericUpDownAncienneteEleve.SelectedItem;

        }
    }
}