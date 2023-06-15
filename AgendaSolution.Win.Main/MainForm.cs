using AgendaSolution.Win.Cadastros;

namespace AgendaSolution.Win.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ContatoConsultaForm();
            //form.MdiParent = this;
            form.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}