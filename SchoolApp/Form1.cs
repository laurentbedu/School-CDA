namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professeur professeur1 = new Professeur() { Nom = "Manson", Prenom = "Charles"};
            textBoxProf.Text = professeur1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eleve eleve1 = new Eleve() {Nom = "Petit", Prenom = "Gregory" };
            textBoxEleve.Text = eleve1.ToString();
        }
    }
}