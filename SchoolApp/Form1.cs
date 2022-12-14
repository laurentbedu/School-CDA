namespace SchoolApp
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleve newEleve = new Eleve("all", "max","2ans");
            MessageBox.Show(newEleve.ToString());
        }
    }
}